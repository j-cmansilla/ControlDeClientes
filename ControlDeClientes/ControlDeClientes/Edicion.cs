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
    public partial class Edicion : Form
    {
        ControlDeFichas control = new ControlDeFichas();
        public Edicion()
        {
            InitializeComponent();
        }

        private void Edicion_Load(object sender, EventArgs e)
        {

        }

        public void editarFicha(Ficha ficha)
        {
            txtNombre.Text = ficha.nombre;
            txtTel1.Text = ficha.telefono1;
            txtTel2.Text = ficha.telefono2;
            txtTel3.Text = ficha.telefono3;
            txtDireccion.Text = ficha.direccion;
            txtAnotaciones.Text = ficha.anotaciones;
            txtObservaciones.Text = ficha.observaciones;
            txtDeuda.Text = ficha.deuda;
            txtFechas.Text = ficha.fechas;
            txtID.Text = ficha.ID;
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            Ficha fichaEditada = new Ficha(txtNombre.Text,txtTel1.Text,txtTel2.Text,txtTel3.Text,txtDireccion.Text, txtAnotaciones.Text, txtObservaciones.Text, txtFechas.Text, txtDeuda.Text, txtID.Text);
            if (control.editarFicha(fichaEditada))
            {
                MessageBox.Show("Datos correctamente editados!");
                this.Close();
            }
        }

        private void picDiscard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se edito nada!");
            this.Close();
        }
    }
}
