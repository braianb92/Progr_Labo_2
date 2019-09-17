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

namespace Clase_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtLegajo.Text = "";
            mtxtSalario.Text = "";
            cmbPuesto.Text = "";

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
