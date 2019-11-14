using Archivos;
using Entidades;
using Patentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Visor : Form
    {
        public List<Thread> hilos;

        public Visor()
        {
            InitializeComponent();
            hilos = new List<Thread>();
        }

        private void Visor_Load(object sender, EventArgs e)
        {

        }

        private void Visor_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void BtnTxt_Click(object sender, EventArgs e)
        {
            Texto text = new Texto();
            try
            {
                FinalizarSimulacion();
                text.Leer("patentes.txt", out Queue<Patente> patentes);
                IniciarSimulacion();
            }
            catch (PatenteInvalidaException ex)
            {
                throw ex;
            }
        }

        private void BtnXml_Click(object sender, EventArgs e)
        {
            Xml<Queue<Patente>> xml = new Xml<Queue<Patente>>();
            try
            {
                FinalizarSimulacion();
                xml.Leer("patentes.xml", out Queue<Patente> patentes);
                IniciarSimulacion();
            }
            catch (PatenteInvalidaException ex)
            {
                throw ex;
            }
        }

        private void BtnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            try
            {
                FinalizarSimulacion();
                sql.Leer("patente", out Queue<Patente> patentes);
                IniciarSimulacion();
            }
            catch (PatenteInvalidaException ex)
            {
                throw ex;
            }
        }

        public void IniciarSimulacion()
        {
           
            
        }

        public void ProximaPatente(VistaPatente vistaPatente)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(vistaPatente.MostrarPatente));
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in hilos)
            {
                if (hilo.IsAlive)
                    hilo.Abort();
            }
        }

        
    }
}
