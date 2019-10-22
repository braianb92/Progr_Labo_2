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

namespace Generics
{
    public partial class frmEstanteria : Form
    {
        List<Estanteria<Producto>> estanterias { get; set; }


        public frmEstanteria(Estanteria<Producto> estanteria)
        {
            InitializeComponent();
            
        }

        private void frmEstanteria_Load(object sender, EventArgs e)
        {
            cmbParametro.DataSource = estanterias;
        }
    }
}
