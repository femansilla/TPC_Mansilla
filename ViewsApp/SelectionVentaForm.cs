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
    public partial class SelectionVentaForm : Form
    {
        private readonly ClienteController _clienteController = new ClienteController();
        public int ListCode;
        public int clienteCode;
        private List<UserTypes> list;


        public SelectionVentaForm()
        {
            InitializeComponent();
        }

        private void btnVentaMostrador_Click(object sender, EventArgs e)
        {
            ListCode = list.Where(d => d.Descripcion == "Mostrador").Select(c => c.Code).FirstOrDefault();
            clienteCode = 0;
            DialogResult = DialogResult.OK;
        }

        private void SelectionVentaForm_Load(object sender, EventArgs e)
        {
            list = _clienteController.GetAllPriceList();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            List<Cliente> list = _clienteController.GetAllClientes();
            List<ClienteVM> data = list.Select(c => new ClienteVM
            {
                Code = c.ID,
                Descripcion = c.Apellido + ", " + c.Nombre,
                ListPriceCode = c.ClientType,
                ListPrice = c.ClientTypeDescripcion
            }).ToList();
            dgvAllClients.DataSource = data;
            dgvAllClients.Columns["Code"].Visible = false;
            dgvAllClients.Columns["ListPriceCode"].Visible = false;
            dgvAllClients.Columns["ListPrice"].Visible = false;
            dgvAllClients.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dgvAllClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var clienteSelected = (ClienteVM)dgvAllClients.CurrentRow.DataBoundItem;
            ListCode = clienteSelected.ListPriceCode;
            clienteCode = clienteSelected.Code;
            DialogResult = DialogResult.OK;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
