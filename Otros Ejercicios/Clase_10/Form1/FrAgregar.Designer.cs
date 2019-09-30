namespace Form1
{
    partial class FrAgregar
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.lblBono = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(31, 147);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(24, 13);
            this.lblCuil.TabIndex = 1;
            this.lblCuil.Text = "Cuil";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(31, 203);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo";
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(34, 33);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(180, 21);
            this.cmbTipoEmpleado.TabIndex = 3;
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(54, 163);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(145, 20);
            this.txtCuil.TabIndex = 5;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(54, 219);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(145, 20);
            this.txtSueldo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(54, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(119, 330);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 42);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(34, 14);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 10;
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(54, 272);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(145, 20);
            this.txtBono.TabIndex = 12;
            this.txtBono.Visible = false;
            // 
            // lblBono
            // 
            this.lblBono.AutoSize = true;
            this.lblBono.Location = new System.Drawing.Point(31, 256);
            this.lblBono.Name = "lblBono";
            this.lblBono.Size = new System.Drawing.Size(32, 13);
            this.lblBono.TabIndex = 11;
            this.lblBono.Text = "Bono";
            this.lblBono.Visible = false;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(54, 272);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(145, 20);
            this.txtObjetivo.TabIndex = 14;
            this.txtObjetivo.Visible = false;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(31, 256);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(46, 13);
            this.lblObjetivo.TabIndex = 13;
            this.lblObjetivo.Text = "Objetivo";
            this.lblObjetivo.Visible = false;
            // 
            // FrAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(356, 414);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.lblBono);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.Label lblBono;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Label lblObjetivo;
    }
}

