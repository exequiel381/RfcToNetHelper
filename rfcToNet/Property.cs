using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rfcToNet
{
    public class Property
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        public string rfc { get; set; }
        
        public string type { get; set; }
        public string isDate { get; set; }

        public string decoratorType { get; set; }
        public string net
        {
            get
            {
                var a = this.rfc.ToLower();
                return textInfo.ToTitleCase(rfc.ToLower());
            }
        }
    }
}
