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

namespace FrmMenu
{
    public partial class FrmLlamador : Form
    {
        public Centralita centralita;

        public FrmLlamador(Centralita dataCentralita)
        {
            InitializeComponent();
            centralita = dataCentralita;

        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));

        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Limpiar()
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
        }

        private void TxtNroDestino_TextChanged(object sender, EventArgs e)
        {
            switch ()
            {
                default:
                    break;
            }
        }
    }
}
