using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if(dt==null)
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            else
            {
                string mensaje = (dt.ValidarAptitud()) ? "El DT es Apto" : "El DT no es Apto";
                MessageBox.Show(mensaje);
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            DirectorTecnico director = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, 
                (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, 
                (int)numericUpDownExperiencia.Value);

            if(director.ValidarDirector())
            {
                this.dt = director;
                MessageBox.Show("Se ha creado el DT!");
            }
            else
                MessageBox.Show("Ocurrio un error");

        }
    }
}
