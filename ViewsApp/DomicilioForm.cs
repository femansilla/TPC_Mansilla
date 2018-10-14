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
        private int iDUser;
        private readonly DomicilioController _domicilioController = new DomicilioController();
        
        public DomicilioForm()
        {
            InitializeComponent();
            CargarComboProvincias();
        }

        public DomicilioForm(int iDUser)
        {
            InitializeComponent();
            CargarComboProvincias();
            this.iDUser = iDUser;
        }

        public Direccion GetDomicilioIngresado()
        {
            return new Direccion()
            {
                ID = (lblCodeDireccion.Text == "") ? 0 : int.Parse(lblCodeDireccion.Text),
                Provincia = cmbProvincias.Text,
                Localidad = cmbLocalidad.Text,
                Calle = cmbCalle.Text,
                Altura = (cmbCalle.Text == "") ? 0 : int.Parse(cmbCalle.Text),
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

        private void txtDpto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarComboProvincias()
        {
            cmbProvincias.Text = "Seleccione...";
            cmbProvincias.DataSource = _domicilioController.GetAllProvincias();
            cmbProvincias.DisplayMember = "Descripcion";
            cmbProvincias.ValueMember = "Code";
        }

        private void cmbProvincias_TextChanged(object sender, EventArgs e)
        {
            List<Provincia> list = cmbProvincias.DataSource as List<Provincia>;
            if(list != null)
                if (list.Contains(new Provincia() { Descripcion = cmbProvincias.Text }));
                
        }
    }
}
