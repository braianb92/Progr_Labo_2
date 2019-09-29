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

        public Centralita Centralita { get { return centralita; } }

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
            Random random = new Random();
            Llamada llamada;
            float duracionAleatoria = (float)random.Next(1, 50);

            if (txtNroDestino.Text.StartsWith("#"))
            {
                Provincial.Franja franja;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                Provincial nuevaLlamada = new Provincial(txtNroOrigen.Text,franja,llamada,duracionAleatoria,txtNroDestino.Text);

            }
            else
            {
               float costoAleatorio = random.Next(1, 5);
               Local nuevaLlamada = new Local(txtNroOrigen.Text,llamada,costoAleatorio,txtNroDestino.Text);
            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            WriteInput("6");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            WriteInput("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            WriteInput("3");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            WriteInput("1");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            WriteInput("5");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            WriteInput("4");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            WriteInput("7");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            WriteInput(".");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            WriteInput("0");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            WriteInput("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            WriteInput("9");
        }

        private void BtnHash_Click(object sender, EventArgs e)
        {
            WriteInput("#");
        }

        public void WriteInput(string strNumber)
        {
            if (txtNroDestino.Text == "Nro Destino")
            {
                txtNroDestino.Text = "";
                cmbFranja.Visible = strNumber is "#";
            }              
            txtNroDestino.Text += strNumber;
        }


        public void Limpiar()
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
            cmbFranja.Visible = false;
        }
    }
}
