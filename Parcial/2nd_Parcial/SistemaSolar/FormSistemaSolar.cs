using Entidades;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        public Planeta<Satelite> planeta;

        public FormSistemaSolar()
        {
            InitializeComponent();
            planeta = new Planeta<Satelite>(20, 20, "Jupiter");
        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if(planeta.HiloRotacion == null)
            {
                //Thread hilo = new Thread(new ParameterizedThreadStart(planeta.RunEvbtRotar));
            }
            
        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {

        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txOrbita.Text,out int orb) && int.TryParse(txRota.Text, out int rota))
            {            
                try
                {
                    Satelite satelite = new Satelite(orb, rota, txNombre.Text);
                    if(this.planeta + satelite)
                    {
                        SateliteDB satDB = new SateliteDB();
                        satDB.Guardar(satelite);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
           
        }

        public void MostrarMensajeRotar(string elemento)
        {
            MessageBox.Show(elemento);
        }
    }
}
