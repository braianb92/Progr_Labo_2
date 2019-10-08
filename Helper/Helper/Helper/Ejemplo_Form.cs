using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Ejemplo_Form
    {
        //********************
        //* EJEMPLO DE FORM  *
        //********************

        //private DirectorTecnico dt;

        //public FormDT()
        //{
        //    InitializeComponent();
        //}

        //private void FormDT_Load(object sender, EventArgs e)
        //{

        //}

        //private void buttonValidar_Click(object sender, EventArgs e)
        //{
        //    if (dt == null)
        //        MessageBox.Show("Aún no se ha creado el DT del formulario");
        //    else
        //    {
        //        string mensaje = (dt.ValidarAptitud()) ? "El DT es Apto" : "El DT no es Apto";
        //        MessageBox.Show(mensaje);
        //    }
        //}

        //private void buttonCrear_Click(object sender, EventArgs e)
        //{
        //    DirectorTecnico director = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text,
        //        (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value,
        //        (int)numericUpDownExperiencia.Value);

        //    if (director.ValidarDirector())
        //    {
        //        this.dt = director;
        //        MessageBox.Show("Se ha creado el DT!");
        //    }
        //    else
        //        MessageBox.Show("Ocurrio un error");

        //}

        //******************
        //EJEMPLO OTRO FORM
        //******************

        //public FrAgregar()
        //{
        //    InitializeComponent();
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
        //}

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    switch (this.cmbTipoEmpleado.Text)
        //    {
        //        case "Empleado":
        //            this.persona = (new Empleado(txtNombre.Text, Convert.ToInt32(txtCuil.Text), (float)Convert.ToDouble(txtSueldo.Text)));
        //            break;
        //        case "Jefe":
        //            this.persona = (new Jefe(txtNombre.Text, Convert.ToInt32(txtCuil.Text), (float)Convert.ToDouble(txtSueldo.Text), Convert.ToInt32(txtBono.Text)));
        //            break;
        //        case "Vendedor":
        //            this.persona = (new Vendedor(txtNombre.Text, Convert.ToInt32(txtCuil.Text), (float)Convert.ToDouble(txtSueldo.Text), Convert.ToInt32(txtObjetivo.Text)));
        //            break;
        //        default:
        //            break;
        //    }
        //    Limpiar();

        //}

        //public void Manejador_BonoObjetvio()
        //{
        //    lblBono.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
        //    txtBono.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;

        //    lblObjetivo.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
        //    txtObjetivo.Visible = ((ETipoEmpleado)cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
        //}



        //private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Manejador_BonoObjetvio();
        //}

        //public void Limpiar()
        //{
        //    txtNombre.Text = "";
        //    txtCuil.Text = "";
        //    txtObjetivo.Text = "";
        //    txtBono.Text = "";
        //    txtSueldo.Text = "";
        //}

        //FORM COMPLEMENTARIO DEL DE ARRIBA

        //public List<Persona> personas;

        //public frAumentar()
        //{
        //    personas = new List<Persona>();
        //    InitializeComponent();
        //}

        //private void frAumentar_Load(object sender, EventArgs e)
        //{
        //    listBox.DataSource = personas;
        //}


        //private void btnAplicarAumento_Click(object sender, EventArgs e)
        //{

        //}

        //private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    listBox.DataSource = null;
        //    listBox.DataSource = personas;
        //}

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    FrAgregar frAgregar = new FrAgregar();
        //    frAgregar.Show();
        //    personas.Add(frAgregar.Persona);
        //    listBox.DataSource = null;
        //    listBox.DataSource = personas;
        //}
    }
}
