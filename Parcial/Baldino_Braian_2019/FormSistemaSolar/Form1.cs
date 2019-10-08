using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        static List<Astro> planetas;


        public FormSistemaSolar()
        {
            InitializeComponent();
            FormSistemaSolar.planetas = new List<Astro>();
        }

        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Tipo));          
        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && int.TryParse(txtOrbitaPlaneta.Text,out int numOrbita))
            {
                if(numOrbita>0)
                {
                    Planeta planeta = new Planeta(numOrbita, (int)numRotacion.Value, txtNombrePlaneta.Text,
                                                (int)numSatelite.Value, (Tipo)cmbTipo.SelectedItem);

                    FormSistemaSolar.planetas.Add(planeta);
                    //this.cmbPlanetas.DataSource = FormSistemaSolar.planetas;
                    MessageBox.Show("Se agrego Correctamente!");
                }
                else
                    MessageBox.Show("El numero de orbita no es valido!");

            }
            else
                MessageBox.Show("Ocurrio un problema!");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            foreach (Astro astro in FormSistemaSolar.planetas)
            {
                richTextBox1.Text = (string)astro;
            }
        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {

        }



    }
}
