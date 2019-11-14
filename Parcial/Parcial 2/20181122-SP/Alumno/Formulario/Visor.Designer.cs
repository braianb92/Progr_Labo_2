namespace Formulario
{
    partial class Visor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.vistaPatente1 = new Patentes.VistaPatente();
            this.vistaPatente2 = new Patentes.VistaPatente();
            this.SuspendLayout();
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(179, 148);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(129, 71);
            this.btnTxt.TabIndex = 3;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.BtnTxt_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(30, 148);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(129, 71);
            this.btnXml.TabIndex = 4;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(30, 91);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(278, 43);
            this.btnSql.TabIndex = 5;
            this.btnSql.Text = "SQL";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.BtnSql_Click);
            // 
            // vistaPatente1
            // 
            this.vistaPatente1.Location = new System.Drawing.Point(12, 12);
            this.vistaPatente1.Name = "vistaPatente1";
            this.vistaPatente1.Size = new System.Drawing.Size(128, 48);
            this.vistaPatente1.TabIndex = 6;
            // 
            // vistaPatente2
            // 
            this.vistaPatente2.Location = new System.Drawing.Point(180, 12);
            this.vistaPatente2.Name = "vistaPatente2";
            this.vistaPatente2.Size = new System.Drawing.Size(128, 48);
            this.vistaPatente2.TabIndex = 7;
            // 
            // Visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(344, 235);
            this.Controls.Add(this.vistaPatente2);
            this.Controls.Add(this.vistaPatente1);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Visor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Visor_FormClosing);
            this.Load += new System.EventHandler(this.Visor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnSql;
        private Patentes.VistaPatente vistaPatente1;
        private Patentes.VistaPatente vistaPatente2;
    }
}

