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
            CargarComboLocalidad();
            CargarComboCalle();
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
                Altura = (txtAltura.Text == "") ? 0 : int.Parse(txtAltura.Text),
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
            cmbProvincias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProvincias.Text = "Seleccione...";
            cmbProvincias.DataSource = _domicilioController.GetAllProvincias();
            cmbProvincias.DisplayMember = "Descripcion";
            cmbProvincias.ValueMember = "Code";
        }

        private void CargarComboLocalidad()
        {
            var provSelected = (Provincia)cmbProvincias.SelectedItem; 
            cmbLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocalidad.Text = "Seleccione...";
            cmbLocalidad.DataSource = _domicilioController.GetLocalidad(provSelected.Code);
            cmbLocalidad.DisplayMember = "Descripcion";
            cmbLocalidad.ValueMember = "Code";
        }

        private void CargarComboCalle()
        {
            var provSelected = (Provincia)cmbProvincias.SelectedItem;
            cmbCalle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCalle.Text = "Seleccione...";
            cmbCalle.DataSource = _domicilioController.GetCalle(provSelected.Code);
            cmbCalle.DisplayMember = "Descripcion";
            cmbCalle.ValueMember = "Code";
        }
        private void cmbProvincias_TextChanged(object sender, EventArgs e)
        {
            List<Provincia> list = cmbProvincias.DataSource as List<Provincia>;
            if (list != null)
                if (list.Contains(new Provincia() { Descripcion = cmbProvincias.Text }))
                    cmbProvincias.DataSource = list.Where(m => m.Descripcion.ToLower().Contains(cmbProvincias.Text.ToLower())).ToList();
        }

        private void cmbProvincias_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarComboLocalidad();
            CargarComboCalle();
        }
    }
}
