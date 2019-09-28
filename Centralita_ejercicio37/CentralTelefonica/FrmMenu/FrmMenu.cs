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
    public partial class FrmMenu : Form
    {
        public Centralita centralita;

        public FrmMenu()
        {            
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            centralita = new Centralita();
        }

        private void BtnFacturacionProvincial_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacturacionTotal_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacturacionLocal_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamadaForm = new FrmLlamador();
            llamadaForm.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
