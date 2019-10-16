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
using static ClassLibrary.Llamada;

namespace FrmMenu
{
    public partial class FrmMostrar : Form
    {
        public Centralita centralita;
        public TipoLlamada tipo;

        public Centralita Centralita { get { return centralita; } }

        public FrmMostrar(Centralita dataCentralita, TipoLlamada tipo)
        {
            InitializeComponent();
            this.centralita = dataCentralita;
            this.tipo = tipo;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (tipo == Llamada.TipoLlamada.Todas)
            {
                foreach (Llamada llamada in Centralita.Llamadas)
                {
                    richTextBox1.Text += llamada.ToString(); 
                }
                richTextBox1.Text += $"Ganancia Total (Todas): {Centralita.GananciasPorTotal}";
            }
            else if (tipo == Llamada.TipoLlamada.Local)
            {
                foreach (Llamada llamada in Centralita.Llamadas)
                {
                    if (llamada is Local)
                    {
                        richTextBox1.Text += llamada.ToString();
                    }                  
                }
                richTextBox1.Text += $"Ganancia Total (Local): {Centralita.GananciasPorLocal}";
            }
            else if (tipo == Llamada.TipoLlamada.Provincial)
            {
                foreach (Llamada llamada in Centralita.Llamadas)
                {
                    if (llamada is Provincial)
                    {
                        richTextBox1.Text += llamada.ToString();
                    }
                }
                richTextBox1.Text += $"Ganancia Total (Provincial): {Centralita.GananciasPorProvincial}";
            }

        }
    }
}
