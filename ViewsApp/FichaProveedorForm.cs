using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Business;

namespace ViewsApp
{
    public partial class FichaProveedorForm : Form
    {
        private int iD;
        private DomicilioForm formDomi;
        private readonly ProveedorController _proveedorController = new ProveedorController();

        public FichaProveedorForm()
        {
            InitializeComponent();
            CargarComboType();
        }

        public FichaProveedorForm(int iD)
        {
            InitializeComponent();
            this.iD = iD;
            CargarComboType();
            CargarDatosProveedor();
        }

        private void CargarComboType()
        {
            cmbPerfilType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfilType.DataSource = _proveedorController.GetAllTypes();
            cmbPerfilType.DisplayMember = "Descripcion";
            cmbPerfilType.ValueMember = "Code";
        }

        private void CargarDatosProveedor()
        {
            Proveedor u = _proveedorController.GetProveedor(iD);
            txtApellido.Text = u.Apellido;
            txtNombre.Text = u.Nombre;
            dtFechaNac.Value = u.FechaNac;
            if (u.Sex)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            txtCUIT.Text = u.CUIT;
            cmbPerfilType.SelectedValue = u.ProveedorTypeCode;
            //dgvDomicilios.DataSource = _domicilioController.GetDomiciliosByPersonCode(iD);
            //dgvDomicilios.Columns["ID"].Visible = false;
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedorType prvType = (ProveedorType)cmbPerfilType.SelectedItem;
            Proveedor prov = new Proveedor()
            {
                ID = this.iD,
                CUIT = txtCUIT.Text,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Sex = (rdMale.Checked) ? true : false,
                SexDescription = (rdMale.Checked) ? "M" : "F",
                FechaNac = dtFechaNac.Value,
                ProveedorTypeCode = prvType.Code,
                ProveedorTypeDescripcion = prvType.Descripcion,
                //DomicilioUser = dgvDomicilios.DataSource as List<Direccion>
            };
            _proveedorController.GuardarProveedor(prov);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void btnDelDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void FichaProveedorForm_Load(object sender, EventArgs e)
        {
            if (dgvDomicilios.DataSource != null)
            {
                dgvDomicilios.Columns["ID"].Visible = false;
                btnDelDomicilio.Enabled = true;
            }
            else
            {
                btnDelDomicilio.Enabled = false;
            }
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            new CatalogoProductoForm(this.iD).Show();
        }
    }
}
