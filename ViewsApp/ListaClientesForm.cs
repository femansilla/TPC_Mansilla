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
    public partial class ListaClientesForm : Form
    {
        private readonly ClienteController _clienteController = new ClienteController();
        private List<Cliente> listaClientes = new List<Cliente>();

        public ListaClientesForm()
        {
            InitializeComponent();
            LoadClientes();
            txtSearch.Text = "Buscar...";
            listaClientes = dgvClientes.DataSource as List<Cliente>;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            new HomeForm().Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FichaClienteForm().ShowDialog();
        }

        private void LoadClientes()
        {
            dgvClientes.DataSource = _clienteController.GetAllClientes();
            dgvClientes.Columns["email"].Visible = false;
            dgvClientes.Columns["Sex"].Visible = false;
            dgvClientes.Columns["ClientType"].Visible = false;
            dgvClientes.Columns["ID"].Visible = false;

            dgvClientes.Columns["Nombre"].DisplayIndex = 0;
            dgvClientes.Columns["Apellido"].DisplayIndex = 1;
            dgvClientes.Columns["CUIT"].DisplayIndex = 2;
            dgvClientes.Columns["SexDescription"].DisplayIndex = 3;
            dgvClientes.Columns["FechaNac"].DisplayIndex = 4;
            dgvClientes.Columns["SexDescription"].DisplayIndex = 5;
            dgvClientes.Columns["ClientTypeDescripcion"].DisplayIndex = 6;

            dgvClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void ListaClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void editCliente()
        {
            Cliente proveedorSelected = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            new FichaClienteForm(proveedorSelected.ID).ShowDialog();
            LoadClientes();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editCliente();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente clienteSelected = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            _clienteController.EliminarCliente(clienteSelected.ID);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dgvClientes.DataSource = listaClientes;
            else if (txtSearch.Text != "Buscar...")
            {
                List<Cliente> lista;
                lista = listaClientes.FindAll(m => m.Apellido.ToLower().Contains(txtSearch.Text.ToLower()));
                dgvClientes.DataSource = lista;
            }
        }
    }
}
