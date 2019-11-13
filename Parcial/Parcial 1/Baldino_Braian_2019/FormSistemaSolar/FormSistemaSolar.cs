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
            if (cmbPlanetas.Items.Count == 0)
                btnAgregarSatelite.Enabled = false;
        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if(planetas.Count>0 && txtNombreSatelite.Text != "" && 
                (int)numOrbitaSatelite.Value >= 0 && (int)numRotacionSatelite.Value >= 0)
            {
                    Satelite satelite = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);

                    foreach (Planeta planeta in planetas)
                    {
                        if ((string)planeta == (string)cmbPlanetas.SelectedItem && planeta!=satelite && planeta + satelite)
                        {
                            MessageBox.Show("El satelite fue agregado correctamente!");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("El satelite ya existe o el planeta no posee mas capacidad.");
                            break;
                        }
                            
                    }         
            }
            else
                MessageBox.Show("Uno o mas campos no son validos!");
            Limpiar();
        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && int.TryParse(txtOrbitaPlaneta.Text,out int numOrbita))
            {
                if(numOrbita>0 && (int)numRotacion.Value>=0 && (int)numSatelite.Value>=0)
                {
                    Planeta planeta = new Planeta(numOrbita, (int)numRotacion.Value, txtNombrePlaneta.Text,
                                                (int)numSatelite.Value, (Tipo)cmbTipo.SelectedItem);
                    FormSistemaSolar.planetas.Add(planeta);                   
                    cmbPlanetas.Items.Clear();
                    foreach (Astro item in planetas)
                    {
                        if (item is Planeta)
                        {
                            cmbPlanetas.Items.Add((string)item);
                        }
                    }
                    btnAgregarSatelite.Enabled = true;
                    MessageBox.Show("Se agrego Correctamente!");
                }
                else
                    MessageBox.Show("Solo se permiten valores positivos!");

            }
            else
                MessageBox.Show("Alguno de los campos no es valido!");
            Limpiar();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (Planeta planeta in FormSistemaSolar.planetas)
            {
                richTextBox1.Text += planeta.ToString();
            }
        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (Planeta planeta in planetas)
            {
                richTextBox1.Text += planeta.Orbitar() + "\n" + planeta.Rotar();
                foreach (Satelite satelite in planeta.Satelites)
                {
                    richTextBox1.Text += satelite.Orbitar() + satelite.Rotar();
                }
                richTextBox1.Text += "************\n";

            }

        }

        public void Limpiar()
        {
            txtNombrePlaneta.Text = "";
            txtNombreSatelite.Text = "";
            txtOrbitaPlaneta.Text = "";
            numRotacion.Value = 0;
            numRotacionSatelite.Value = 0;
            numOrbitaSatelite.Value = 0;
            numSatelite.Value = 0;
        }



    }
}
