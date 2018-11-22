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
        private readonly DomicilioController _domicilioController = new DomicilioController();

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
            dgvDomicilios.DataSource = _domicilioController.GetDomiciliosByPerson("Proveedor", iD);
            FormatDGV();
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
                DomicilioUser = dgvDomicilios.DataSource as List<Direccion>
            };
            try
            {
                _proveedorController.GuardarProveedor(prov);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
        }

        private void btnAddDomicilio_Click(object sender, EventArgs e)
        {
            formDomi = new DomicilioForm();
            formDomi.ShowDialog();
            if (formDomi.ActiveControl.Text != "Cancelar")
                ReLoadDgvDomicilio(formDomi);
            formDomi.Close();
        }

        private void btnDelDomicilio_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvDomicilios.DataSource as List<Direccion>;
                if (dgvDomicilios.DataSource != null)
                {
                    if (dataDGV.Count > 1)
                        dataDGV.Remove((Direccion)dgvDomicilios.CurrentRow.DataBoundItem);
                    //dgvDomicilios.Rows.RemoveAt(dgvDomicilios.CurrentRow.Index);
                }
                dgvDomicilios.DataSource = null;
                dgvDomicilios.DataSource = dataDGV;
                FormatDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormatDGV()
        {
            dgvDomicilios.Columns["Provincia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDomicilios.Columns["Localidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDomicilios.Columns["Calle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDomicilios.Columns["ID"].Visible = false;
            dgvDomicilios.Columns["Piso"].Visible = false;
            dgvDomicilios.Columns["Departamento"].Visible = false;
        }

        private void ReLoadDgvDomicilio(DomicilioForm FD)
        {
            var li = new List<Direccion>();
            var dataList = dgvDomicilios.DataSource as List<Direccion>;
            if (dgvDomicilios.DataSource != null)
            {
                foreach (var domi in dataList)
                    li.Add(domi);
                li.Add(FD.GetDomicilioIngresado());
            }
            else
                li.Add(FD.GetDomicilioIngresado());
            dgvDomicilios.DataSource = li;
            FormatDGV();
        }

        private void ReLoadDgvDomicilio(List<Direccion> li)
        {
            var dataList = dgvDomicilios.DataSource as List<Direccion>;
            if (dgvDomicilios.DataSource != null)
            {
                foreach (var domi in dataList)
                    li.Add(domi);
            }
            dgvDomicilios.DataSource = li;
            FormatDGV();
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
            if(iD == 0)
            {
                btnVerCatalogo.Enabled = false;
            }
            else
            {
                btnVerCatalogo.Enabled = true;
            }
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            new CatalogoProductoForm(this.iD).Show();
        }
    }
}
