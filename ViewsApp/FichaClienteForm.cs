using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsApp
{
    public partial class FichaClienteForm : Form
    {
        private readonly ClienteController _clienteController = new ClienteController();
        private readonly DomicilioController _domicilioController = new DomicilioController();
        DomicilioForm formDomi;
        private int iD;

        public FichaClienteForm()
        {
            InitializeComponent();
            CargarComboListaPrecio();
        }

        public FichaClienteForm(int iD)
        {
            InitializeComponent();
            this.iD = iD;
            CargarComboListaPrecio();
            CargarDatosCliente();
        }

        private void CargarComboListaPrecio()
        {
            cmbPriceList.DropDownStyle = ComboBoxStyle.DropDownList;
            ///cmbPerfilType.Text = "Seleccione...";
            cmbPriceList.DataSource = _clienteController.GetAllPriceList();
            cmbPriceList.DisplayMember = "Descripcion";
            cmbPriceList.ValueMember = "Code";
        }

        private void CargarDatosCliente()
        {
            Cliente c = _clienteController.GetCliente(iD);
            txtApellido.Text = c.Apellido;
            txtNombre.Text = c.Nombre;
            dtFechaNac.Value = c.FechaNac;
            if (c.Sex)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            cmbPriceList.SelectedValue = c.ClientType;
            lblUsuarioID.Text = c.CUIT;
            dgvDomicilios.DataSource = _domicilioController.GetDomiciliosByPerson("Cliente", iD);
            FormatDGV();
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

        private void btnDelDomicilio_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvDomicilios.DataSource as List<Direccion>;
                if (dgvDomicilios.DataSource != null)
                {
                    if (dataDGV.Count > 1)
                        dataDGV.Remove((Direccion)dgvDomicilios.CurrentRow.DataBoundItem);
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

        private void btnAddDomicilio_Click(object sender, EventArgs e)
        {
            formDomi = new DomicilioForm();
            formDomi.ShowDialog();
            if (formDomi.ActiveControl.Text != "Cancelar")
                ReLoadDgvDomicilio(formDomi);
            formDomi.Close();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UserTypes priceList = (UserTypes)cmbPriceList.SelectedItem;
            Cliente client = new Cliente()
            {
                ID = this.iD,
                ClientType = priceList.Code,
                ClientTypeDescripcion = priceList.Descripcion,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Sex = (rdMale.Checked) ? true : false,
                SexDescription = (rdMale.Checked) ? "M" : "F",
                FechaNac = dtFechaNac.Value,
                CUIT = lblUsuarioID.Text,
                DomicilioUser = dgvDomicilios.DataSource as List<Direccion>
            };
            try
            {
                _clienteController.GuardarCliente(client);
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
            DialogResult = DialogResult.Cancel;
        }

        private void dgvDomicilios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            formDomi = new DomicilioForm(this.iD);
            formDomi.ShowDialog();
            ReLoadDgvDomicilio(formDomi);
            formDomi.Close();
        }

        private void FichaClienteForm_Load(object sender, EventArgs e)
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
    }
}
