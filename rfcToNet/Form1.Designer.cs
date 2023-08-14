
namespace rfcToNet
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbRfc = new System.Windows.Forms.RichTextBox();
            this.rtbNet = new System.Windows.Forms.RichTextBox();
            this.btnToNet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbRfc
            // 
            this.rtbRfc.Location = new System.Drawing.Point(12, 12);
            this.rtbRfc.Name = "rtbRfc";
            this.rtbRfc.Size = new System.Drawing.Size(468, 507);
            this.rtbRfc.TabIndex = 1;
            this.rtbRfc.Text = "";
            // 
            // rtbNet
            // 
            this.rtbNet.Location = new System.Drawing.Point(650, 12);
            this.rtbNet.Name = "rtbNet";
            this.rtbNet.Size = new System.Drawing.Size(468, 507);
            this.rtbNet.TabIndex = 2;
            this.rtbNet.Text = "";
            // 
            // btnToNet
            // 
            this.btnToNet.Location = new System.Drawing.Point(520, 249);
            this.btnToNet.Name = "btnToNet";
            this.btnToNet.Size = new System.Drawing.Size(75, 23);
            this.btnToNet.TabIndex = 3;
            this.btnToNet.Text = "toNet";
            this.btnToNet.UseVisualStyleBackColor = true;
            this.btnToNet.Click += new System.EventHandler(this.btnToNet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 565);
            this.Controls.Add(this.btnToNet);
            this.Controls.Add(this.rtbNet);
            this.Controls.Add(this.rtbRfc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbRfc;
        private System.Windows.Forms.RichTextBox rtbNet;
        private System.Windows.Forms.Button btnToNet;
    }
}

