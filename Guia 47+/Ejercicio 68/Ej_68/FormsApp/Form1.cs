using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class FrmPersona : Form
    {
        private Persona persona;

        public FrmPersona()
        {
            InitializeComponent();
            
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text))
            {
                Persona p = new Persona();
                p.EventoString += NotificarCambio;

                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                persona = p;
                
                
                this.btnCrear.Text = "Actualizar";
                
            }
        }

        public void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}
