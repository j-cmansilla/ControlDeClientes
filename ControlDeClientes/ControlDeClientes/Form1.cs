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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text=="" || txtAnotaciones.Text == "" || txtDeuda.Text == "" || txtDireccion.Text == "" || txtFechas.Text == "" || txtObservaciones.Text == "" || txtTel1.Text=="" || txtTel2.Text == "" || txtTel3.Text=="")
            {
                MessageBox.Show("Llene todos los campos!");
            }
            Ficha ficha = new Ficha(txtNombre.Text, txtTel1.Text, txtTel2.Text, txtTel3.Text,txtDireccion.Text, txtAnotaciones.Text, txtObservaciones.Text,txtFechas.Text, txtDeuda.Text);
            control.agregarFicha(ficha);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
