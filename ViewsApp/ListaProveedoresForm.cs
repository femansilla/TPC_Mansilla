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
    public partial class ListaProveedoresForm : Form
    {
        private readonly ProveedorController _proveedorController = new ProveedorController();
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public ListaProveedoresForm()
        {
            InitializeComponent();
            txtSearch.Text = "Buscar...";
            listaProveedores = dgvProveedores.DataSource as List<Proveedor>;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            new HomeForm().Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FichaProveedorForm().ShowDialog();
            LoadProveedoores();
        }

        private void LoadProveedoores()
        {
            dgvProveedores.DataSource = _proveedorController.GetAllProveedores();
            dgvProveedores.Columns["ID"].Visible = false;
            dgvProveedores.Columns["Sex"].Visible = false;
            dgvProveedores.Columns["ProveedorTypeCode"].Visible = false;
            dgvProveedores.Columns["email"].Visible = false;

            dgvProveedores.Columns["CUIT"].DisplayIndex = 0;
            dgvProveedores.Columns["Nombre"].DisplayIndex = 1;
            dgvProveedores.Columns["Apellido"].DisplayIndex = 2;
            dgvProveedores.Columns["SexDescription"].DisplayIndex = 3;
            dgvProveedores.Columns["FechaNac"].DisplayIndex = 4;
            dgvProveedores.Columns["ProveedorTypeDescripcion"].DisplayIndex = 5;

            dgvProveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedores.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editProveedor();
        }

        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editProveedor();
        }

        private void editProveedor()
        {
            Proveedor proveedorSelected = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            new FichaProveedorForm(proveedorSelected.ID).ShowDialog();
            LoadProveedoores();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dgvProveedores.DataSource = listaProveedores;
            else if (txtSearch.Text != "Buscar...")
            {
                List<Proveedor> lista;
                lista = listaProveedores.FindAll(m => m.Apellido.ToLower().Contains(txtSearch.Text.ToLower()));
                dgvProveedores.DataSource = lista;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Proveedor proveedorSelected = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            _proveedorController.EliminarUsuario(proveedorSelected.ID);
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void ListaProveedoresForm_Load(object sender, EventArgs e)
        {

        }
    }
}
