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
using System.IO;

namespace AppForms
{
    public partial class IndexForm : Form
    {
        public List<Mensaje> Mensajes;

        public IndexForm()
        {
            InitializeComponent();
            Mensajes = new List<Mensaje>();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("archivo.log",true);
            sw.WriteLine(DateTime.Now);           
            sw.Close();
            this.listBox.DataSource = null;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text != "" && txtUsuario.Text != "")
            {
                Mensaje mensaje = new Mensaje();

                mensaje.Usuario = txtUsuario.Text;
                mensaje.Texto = txtMensaje.Text;
                mensaje.Hora = DateTime.Now;
                this.Mensajes.Add(mensaje);
                listBox.DataSource = null;
                listBox.DataSource = this.Mensajes;
                
            }
            else
            {   
                MessageBox.Show("Los campos no pueden estar vacios!");
            }
        }
    }
}
