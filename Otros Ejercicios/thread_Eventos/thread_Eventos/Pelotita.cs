using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace thread_Eventos
{
    public delegate void Evento();

    public partial class Pelotita : UserControl
    {
        public Thread Hilo;
        public event Evento EliminarPelotitas;
        public event Evento FinalizarEvento;
        

        public Pelotita()
        {
            InitializeComponent();
        }

        private void Pelotita_Load(object sender, EventArgs e)
        {
            this.EliminarPelotitas += Eliminar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EliminarPelotitas();         
        }

        public void SetBackgroundImg(Bitmap img)
        {
            this.pictureBox1.BackgroundImage = img;
            this.BackColor = Color.Transparent;
        }

        public void Mover(Object finPantalla)
        {
            while(this.Left < (int)finPantalla - this.Width)
            {
                Thread.Sleep(110);
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.Left += 30;
                    });
                }
                else
                {
                    this.Left += 30;
                }
               
            }
            FinalizarEvento();
        }

        public void Eliminar()
        {
            if (this.Hilo.IsAlive)
                Hilo.Abort();
            this.Hide();
        }

    }
}
