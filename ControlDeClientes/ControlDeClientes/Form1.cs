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
            else
            {
                Guid id = Guid.NewGuid();
                Ficha ficha = new Ficha(txtNombre.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text, txtDireccion.Text, txtAnotaciones.Text, txtObservaciones.Text, txtFechas.Text, txtDeuda.Text,id.ToString());
                control.agregarFicha(ficha);
                MessageBox.Show("Ficha agregada exitosamente!");
                refreshData();
            } 
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
                dtDatos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8],datos[9]);
            }

            if (lista.Count == 0)
            {
                MessageBox.Show("Ningun dato coincide con el criterio de busqueda!");
            }
        }

        private void dtDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDatos.SelectedCells.Count == 10)
            {
                picEditar.Visible = true;
            }
            else
            {
                picEditar.Visible = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            picEditar.Visible = false;
            Ficha ficha = new Ficha(dtDatos.SelectedCells[0].Value.ToString(), dtDatos.SelectedCells[1].Value.ToString(), dtDatos.SelectedCells[2].Value.ToString(), dtDatos.SelectedCells[3].Value.ToString(), dtDatos.SelectedCells[4].Value.ToString(), dtDatos.SelectedCells[5].Value.ToString(), dtDatos.SelectedCells[6].Value.ToString(), dtDatos.SelectedCells[7].Value.ToString(), dtDatos.SelectedCells[8].Value.ToString(), dtDatos.SelectedCells[9].Value.ToString());
            Edicion edicion = new Edicion();
            edicion.Show();
            edicion.editarFicha(ficha);
        }
    }
}
