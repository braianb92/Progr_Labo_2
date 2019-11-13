namespace FormSistemaSolar
{
    partial class FormSistemaSolar
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
            this.lblNombrePlaneta = new System.Windows.Forms.Label();
            this.lblTiempoOrbita = new System.Windows.Forms.Label();
            this.lblTiempoRotacion = new System.Windows.Forms.Label();
            this.lblLunas = new System.Windows.Forms.Label();
            this.lblTipoPlaneta = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.numSatelite = new System.Windows.Forms.NumericUpDown();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblSatelite = new System.Windows.Forms.Label();
            this.lblTiempoCompletadoOrbita = new System.Windows.Forms.Label();
            this.lblTiempoCompletadoRotacion = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombrePlaneta
            // 
            this.lblNombrePlaneta.AutoSize = true;
            this.lblNombrePlaneta.Location = new System.Drawing.Point(12, 18);
            this.lblNombrePlaneta.Name = "lblNombrePlaneta";
            this.lblNombrePlaneta.Size = new System.Drawing.Size(99, 13);
            this.lblNombrePlaneta.TabIndex = 0;
            this.lblNombrePlaneta.Text = "Nombre del planeta";
            // 
            // lblTiempoOrbita
            // 
            this.lblTiempoOrbita.AutoSize = true;
            this.lblTiempoOrbita.Location = new System.Drawing.Point(12, 52);
            this.lblTiempoOrbita.Name = "lblTiempoOrbita";
            this.lblTiempoOrbita.Size = new System.Drawing.Size(135, 13);
            this.lblTiempoOrbita.TabIndex = 1;
            this.lblTiempoOrbita.Text = "Tiempo en completar orbita";
            // 
            // lblTiempoRotacion
            // 
            this.lblTiempoRotacion.AutoSize = true;
            this.lblTiempoRotacion.Location = new System.Drawing.Point(12, 88);
            this.lblTiempoRotacion.Name = "lblTiempoRotacion";
            this.lblTiempoRotacion.Size = new System.Drawing.Size(147, 13);
            this.lblTiempoRotacion.TabIndex = 2;
            this.lblTiempoRotacion.Text = "Tiempo en completar rotacion";
            // 
            // lblLunas
            // 
            this.lblLunas.AutoSize = true;
            this.lblLunas.Location = new System.Drawing.Point(12, 123);
            this.lblLunas.Name = "lblLunas";
            this.lblLunas.Size = new System.Drawing.Size(92, 13);
            this.lblLunas.TabIndex = 3;
            this.lblLunas.Text = "Cantidad de lunas";
            // 
            // lblTipoPlaneta
            // 
            this.lblTipoPlaneta.AutoSize = true;
            this.lblTipoPlaneta.Location = new System.Drawing.Point(12, 162);
            this.lblTipoPlaneta.Name = "lblTipoPlaneta";
            this.lblTipoPlaneta.Size = new System.Drawing.Size(82, 13);
            this.lblTipoPlaneta.TabIndex = 4;
            this.lblTipoPlaneta.Text = "Tipo de Planeta";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(158, 15);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(153, 20);
            this.txtNombrePlaneta.TabIndex = 5;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(158, 49);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(153, 20);
            this.txtOrbitaPlaneta.TabIndex = 6;
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(158, 86);
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(153, 20);
            this.numRotacion.TabIndex = 7;
            // 
            // numSatelite
            // 
            this.numSatelite.Location = new System.Drawing.Point(158, 121);
            this.numSatelite.Name = "numSatelite";
            this.numSatelite.Size = new System.Drawing.Size(153, 20);
            this.numSatelite.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(158, 159);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(153, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(349, 18);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(43, 13);
            this.lblPlaneta.TabIndex = 10;
            this.lblPlaneta.Text = "Planeta";
            // 
            // lblSatelite
            // 
            this.lblSatelite.AutoSize = true;
            this.lblSatelite.Location = new System.Drawing.Point(349, 48);
            this.lblSatelite.Name = "lblSatelite";
            this.lblSatelite.Size = new System.Drawing.Size(97, 13);
            this.lblSatelite.TabIndex = 11;
            this.lblSatelite.Text = "Nombre del satelite";
            // 
            // lblTiempoCompletadoOrbita
            // 
            this.lblTiempoCompletadoOrbita.AutoSize = true;
            this.lblTiempoCompletadoOrbita.Location = new System.Drawing.Point(349, 84);
            this.lblTiempoCompletadoOrbita.Name = "lblTiempoCompletadoOrbita";
            this.lblTiempoCompletadoOrbita.Size = new System.Drawing.Size(146, 13);
            this.lblTiempoCompletadoOrbita.TabIndex = 12;
            this.lblTiempoCompletadoOrbita.Text = "Tiempo en completar la orbita";
            // 
            // lblTiempoCompletadoRotacion
            // 
            this.lblTiempoCompletadoRotacion.AutoSize = true;
            this.lblTiempoCompletadoRotacion.Location = new System.Drawing.Point(349, 119);
            this.lblTiempoCompletadoRotacion.Name = "lblTiempoCompletadoRotacion";
            this.lblTiempoCompletadoRotacion.Size = new System.Drawing.Size(147, 13);
            this.lblTiempoCompletadoRotacion.TabIndex = 13;
            this.lblTiempoCompletadoRotacion.Text = "Tiempo en completar rotacion";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(507, 15);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(153, 21);
            this.cmbPlanetas.TabIndex = 14;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(507, 45);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(153, 20);
            this.txtNombreSatelite.TabIndex = 15;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(507, 82);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(153, 20);
            this.numOrbitaSatelite.TabIndex = 16;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(507, 117);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(153, 20);
            this.numRotacionSatelite.TabIndex = 17;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(44, 207);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(246, 42);
            this.btnAgregarPlaneta.TabIndex = 18;
            this.btnAgregarPlaneta.Text = "Agregar Planeta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.btnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(307, 207);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(246, 42);
            this.btnAgregarSatelite.TabIndex = 19;
            this.btnAgregarSatelite.Text = "Agregar Satelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.btnAgregarSatelite_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(44, 255);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(509, 42);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "Mostrar Informacion";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(47, 303);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(506, 42);
            this.btnMoverAstros.TabIndex = 21;
            this.btnMoverAstros.Text = "Mover Astros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.btnMoverAstros_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(674, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 327);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // FormSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 357);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblTiempoCompletadoRotacion);
            this.Controls.Add(this.lblTiempoCompletadoOrbita);
            this.Controls.Add(this.lblSatelite);
            this.Controls.Add(this.lblPlaneta);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.numSatelite);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.lblTipoPlaneta);
            this.Controls.Add(this.lblLunas);
            this.Controls.Add(this.lblTiempoRotacion);
            this.Controls.Add(this.lblTiempoOrbita);
            this.Controls.Add(this.lblNombrePlaneta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSistemaSolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Baldino Braian";
            this.Load += new System.EventHandler(this.FormSistemaSolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePlaneta;
        private System.Windows.Forms.Label lblTiempoOrbita;
        private System.Windows.Forms.Label lblTiempoRotacion;
        private System.Windows.Forms.Label lblLunas;
        private System.Windows.Forms.Label lblTipoPlaneta;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.NumericUpDown numSatelite;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Label lblSatelite;
        private System.Windows.Forms.Label lblTiempoCompletadoOrbita;
        private System.Windows.Forms.Label lblTiempoCompletadoRotacion;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

