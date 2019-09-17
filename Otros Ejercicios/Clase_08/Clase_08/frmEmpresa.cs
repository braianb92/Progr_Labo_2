using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Clase_08
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float.TryParse(lblGanancias.Text, out float ganancias);
            Empresa empresa = new Empresa(lblRazonSocial.Text,lblDireccion.Text,ganancias);
        }
    }
}
