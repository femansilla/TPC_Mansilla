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

        public ListaClientesForm()
        {
            InitializeComponent();
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
            dgvListaUsr.DataSource = _usuarioController.GetAllUsuarios();
            dgvListaUsr.Columns["Password"].Visible = false;
            dgvListaUsr.Columns["CUIT"].Visible = false;
            dgvListaUsr.Columns["Sex"].Visible = false;
            dgvListaUsr.Columns["UserTypeCode"].Visible = false;
            dgvListaUsr.Columns["IDUser"].Visible = false;

            dgvListaUsr.Columns["Nombre"].DisplayIndex = 0;
            dgvListaUsr.Columns["Apellido"].DisplayIndex = 1;
            dgvListaUsr.Columns["SexDescription"].DisplayIndex = 2;
            dgvListaUsr.Columns["FechaNac"].DisplayIndex = 3;
            dgvListaUsr.Columns["UserName"].DisplayIndex = 4;
            dgvListaUsr.Columns["UserType"].DisplayIndex = 5;

            dgvListaUsr.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaUsr.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaUsr.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaUsr.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void ListaClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void editProveedor()
        {
            Proveedor proveedorSelected = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            new FichaProveedorForm(proveedorSelected.ID).ShowDialog();
            LoadProveedoores();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
