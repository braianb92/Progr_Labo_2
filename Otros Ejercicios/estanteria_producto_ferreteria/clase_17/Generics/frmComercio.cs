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
    public partial class frmComercio : Form
    {
        public List<Estanteria<Producto>> estanterias;

        public List<Estanteria<Producto>> Estanterias
        {
            get { return this.estanterias; }
        }

        public frmComercio()
        {
            InitializeComponent();
        }

        private void frmComercio_Load(object sender, EventArgs e)
        {
            estanterias = Estanterias;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Estanteria<Producto> estanteria = new Estanteria<Producto>(100);
            frmEstanteria FrmEstanteria = new frmEstanteria(estanteria);
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

    }
}
