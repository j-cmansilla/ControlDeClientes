using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeClientes
{
    public partial class Control : Form
    {
        ControlDeFichas control = new ControlDeFichas();
        public Control()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void refreshData()
        {
            txtNombre.Text = "";
            txtAnotaciones.Text = "";
            txtDeuda.Text = "";
            txtDireccion.Text = "";
            txtFechas.Text = "";
            txtObservaciones.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtTel3.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="" || txtAnotaciones.Text == "" || txtDeuda.Text == "" || txtDireccion.Text == "" || txtFechas.Text == "" || txtObservaciones.Text == "" || txtTel1.Text=="" || txtTel2.Text == "" || txtTel3.Text=="")
            {
                MessageBox.Show("Llene todos los campos!");
            }
            Ficha ficha = new Ficha(txtNombre.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text,txtDireccion.Text, txtAnotaciones.Text, txtObservaciones.Text,txtFechas.Text, txtDeuda.Text);
            control.agregarFicha(ficha);
            MessageBox.Show("Ficha agregada exitosamente!");
            refreshData();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<String> lista = control.buscarDatos(txtBusqueda.Text);
            for (int i = 0; i < lista.Count; i++)
            {
                String [] datos = lista.ElementAt(i).Split(',');
                dtDatos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8]);
            }

            if (lista.Count == 0)
            {
                MessageBox.Show("Ningun dato coincide con el criterio de busqueda!");
            }
        }
    }
}
