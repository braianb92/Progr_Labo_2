using Clase_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public List<Persona> personas { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.personas = new List<Persona>();
            this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (this.cmbTipoEmpleado.Text)
            {
                case "Empleado":
                    personas.Add(new Empleado(txtNombre.Text, Convert.ToInt32(txtCuil.Text), (float)Convert.ToDouble(txtSueldo.Text)));
                    break;
                case "Jefe":
                    personas.Add(new Jefe(txtNombre.Text, Convert.ToInt32(txtCuil.Text), (float)Convert.ToDouble(txtSueldo.Text),Convert.ToInt32(txtBono.Text)));
                    break;
                case "Vendedor":
                    personas.Add(new Vendedor(txtNombre.Text, Convert.ToInt32(txtCuil.Text), (float)Convert.ToDouble(txtSueldo.Text), Convert.ToInt32(txtObjetivo.Text)));
                    break;
                default:
                    break;
            }
            Limpiar();
            
        }

        public void Manejador_BonoObjetvio()
        {
            lblBono.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            txtBono.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;

            lblObjetivo.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
            txtObjetivo.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
        }



        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Manejador_BonoObjetvio();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtCuil.Text = "";
            txtObjetivo.Text = "";
            txtBono.Text = "";
            txtSueldo.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in personas)
            {
                MessageBox.Show(item.Mostrar());
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            frAumentar formAumentar = new frAumentar(personas);
            formAumentar.Show(this);
        }
    }

    
}
