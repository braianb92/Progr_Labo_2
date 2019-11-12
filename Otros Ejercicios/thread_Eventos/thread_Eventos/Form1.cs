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

namespace thread_Eventos
{
    public partial class Form1 : Form
    {
        public int puntos;
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.black_background;
            this.puntos = 0;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Pelotita pelotita = new Pelotita();
            Thread hilo = new Thread(new ParameterizedThreadStart( pelotita.Mover));

            pelotita.Hilo = hilo;
            pelotita.EliminarPelotitas += AumentarPuntaje;
            pelotita.FinalizarEvento += MostrarMensaje;
            pelotita.FinalizarEvento += EliminarTodasLasPelotitas;

            pelotita.SetBackgroundImg(Properties.Resources._33926_image_of_soccer_ball_free_download_png);
            this.Controls.Add(pelotita);

            pelotita.Hilo.Start(this.Width);
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            EliminarTodasLasPelotitas();
        }

        public  void AumentarPuntaje()
        {
            this.puntos++;
        }

        public void MostrarMensaje()
        {
            MessageBox.Show($"TOTAL PUNTOS: {this.puntos}");
        }

        public void EliminarTodasLasPelotitas()
        {
            foreach (Control control in this.Controls)
            {
                Application.DoEvents();
                if (control is Pelotita)
                    ((Pelotita)control).Eliminar();
            }
        }




    }
}
