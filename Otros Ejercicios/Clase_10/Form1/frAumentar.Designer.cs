namespace Form1
{
    partial class frAumentar
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
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.btnAplicarAumento = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(22, 25);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(25, 51);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(108, 20);
            this.txtPorcentaje.TabIndex = 2;
            // 
            // btnAplicarAumento
            // 
            this.btnAplicarAumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarAumento.Location = new System.Drawing.Point(420, 42);
            this.btnAplicarAumento.Name = "btnAplicarAumento";
            this.btnAplicarAumento.Size = new System.Drawing.Size(82, 32);
            this.btnAplicarAumento.TabIndex = 3;
            this.btnAplicarAumento.Text = "Aplicar";
            this.btnAplicarAumento.UseVisualStyleBackColor = true;
            this.btnAplicarAumento.Click += new System.EventHandler(this.btnAplicarAumento_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 111);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(521, 342);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(420, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 38);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frAumentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 535);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnAplicarAumento);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblPorcentaje);
            this.Name = "frAumentar";
            this.Text = "frMostrar";
            this.Load += new System.EventHandler(this.frAumentar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button btnAplicarAumento;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnAgregar;
    }
}