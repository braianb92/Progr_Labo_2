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
        public Queue<Patente> cola;

        public Visor()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            cola = new Queue<Patente>();
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
                cola = patentes;
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
            FinalizarSimulacion();
            ProximaPatente(vistaPatente1);
            ProximaPatente(vistaPatente2);

        }

        public void ProximaPatente(VistaPatente vistaPatente)
        {
            if(cola.Count > 0)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(vistaPatente.MostrarPatente));
                foreach (Patente patente in cola)
                {
                    thread.Start(patente);
                    hilos.Add(thread);
                }
                
            }
            
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
