using Clase_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class frAumentar : Form
    {
        public List<Persona> listaPersonas;

        public frAumentar(List<Persona> personas)
        {
            InitializeComponent();
            listaPersonas = personas;
        }

        private void frAumentar_Load(object sender, EventArgs e)
        {
            listBox.DataSource = listaPersonas;
        }


        private void btnAplicarAumento_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.DataSource = null;
            listBox.DataSource = listaPersonas;
        }
    }
}
