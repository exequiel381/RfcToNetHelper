using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rfcToNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnToNet_Click(object sender, EventArgs e)
        {
            rtbNet.Text = GetNetProperty(rtbRfc.Text);
            Clipboard.SetText(rtbNet.Text);
        }

        public static string GetNetProperty(string inputString)
        {
            string[] propsRfc = inputString.Split('<');
            string NamePattern = "AbapName := \"([A-Za-z0-9_]+)\"";
            List<Property> propFormat = new List<Property>();
            List<string> propsNet = new List<string>();

            string patternClass = "Public Class ([A-Za-z0-9_]+)";
            MatchCollection classMatch = Regex.Matches(inputString, patternClass);
            string nameClass = classMatch.Count == 0 ? "" : classMatch[0].Groups[1].Value;



            foreach (var item in propsRfc)
            {
                string patterDate = "RfcType:=RFCTYPE.([A-Za-z0-9_]+)"; 
                string patternType = "As ([A-Za-z0-9_]+)";
                MatchCollection typeMatch = Regex.Matches(item, patternType);
                MatchCollection dateMatch = Regex.Matches(item, patterDate);
                string typeName = typeMatch.Count == 0 ? "string" : typeMatch[0].Groups[1].Value.ToLower();
                string date = dateMatch.Count == 0 ? "" : dateMatch[0].Groups[1].Value.ToLower();
                string decoratorDecimaltype = typeName.Equals("decimal") ? ",RfcFieldType = typeof(decimal)" : "";
                string decoratorDate = !date.Equals("") && date.Contains("date") ? ",IsDateString = true" : "";

                MatchCollection nameMatches = Regex.Matches(item, NamePattern);
                if (nameMatches.Count > 0 && !nameMatches[0].Groups[1].Value.Equals(nameClass))
                {
                    propFormat.Add(new Property() { rfc = nameMatches[0].Groups[1].Value, type = typeName, decoratorType = decoratorDecimaltype, isDate= decoratorDate });
                }

            }

            foreach (var item in propFormat)
            {
                //agregar typeName y decoratorDecimaltype a la cadena 
                propsNet.Add("[SNCRfcField(RfcFieldName=\"" + item.rfc + "\"" + item.decoratorType+item.isDate + ")]\n" + "public " + item.type + " " + item.net + "{ get; set; }\n\n");
            }

            string classEstructure = "using ExCliSAPNco31.Utils;\n" + "namespace ExCliSAPNco31.DataTypes.SSHH\n{\npublic class " + nameClass + "\n{" + "\npublic const string TABLENAME =" + "\"" + nameClass + "Table\";\n\n";
            string endClass = "}\n}";
            return classEstructure + String.Join("", propsNet) + endClass;

        }
    }
}
