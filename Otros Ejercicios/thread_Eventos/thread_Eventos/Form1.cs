using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Pelotita pelotita = new Pelotita();
            pelotita.BackgroundImage = Properties.Resources._33926_image_of_soccer_ball_free_download_png;
            this.Controls.Add(pelotita);
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {

        }

        public void 
        {
            
        }
    }
}
