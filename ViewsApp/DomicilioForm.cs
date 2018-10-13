using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;

namespace ViewsApp
{
    public partial class DomicilioForm : Form
    {
        public DomicilioForm()
        {
            InitializeComponent();
        }

        public Direccion GetDomicilioIngresado()
        {
            return new Direccion()
            {
                ID = (lblCodeDireccion.Text == "") ? 0 : int.Parse(lblCodeDireccion.Text),
                Provincia = txtProvincia.Text,
                Localidad = txtLocalidad.Text,
                Calle = txtCalle.Text,
                Altura = (txtCalle.Text == "") ? 0 : int.Parse(txtCalle.Text),
                Piso = (txtPiso.Text == "") ? 0 : int.Parse(txtPiso.Text),
                Departamento = (txtDpto.Text == "") ? 0 : int.Parse(txtDpto.Text)
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
