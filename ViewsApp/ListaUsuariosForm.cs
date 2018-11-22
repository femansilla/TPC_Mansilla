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
    public partial class ListaUsuariosForm : Form
    {
        private readonly UsuarioController _usuarioController = new UsuarioController();
        private List<Usuario> listaUsuarios = new List<Usuario>();
        public Usuario currentUser;

        public ListaUsuariosForm()
        {
            InitializeComponent();
            LoadUsuarios();
            txtSearch.Text = "Buscar...";
            listaUsuarios = dgvListaUsr.DataSource as List<Usuario>;
        }

        private void ListaUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadUsuarios()
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FichaUsuarioForm form = new FichaUsuarioForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se grabo correctamente el usuario...");
                form.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al grabar los datos...");
            }

            LoadUsuarios();
        }

        private void editUser()
        {
            Usuario usuarioSelected = (Usuario)dgvListaUsr.CurrentRow.DataBoundItem;
            FichaUsuarioForm form = new FichaUsuarioForm(usuarioSelected.IDUser);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Se grabo correctamente el usuario...");
                form.Close();
            }
            else if(form.DialogResult != DialogResult.Ignore)
            {
                MessageBox.Show("Ocurrio un error al grabar los datos...");
            }
            LoadUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editUser();
        }

        private void dgvListaUsr_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editUser();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelected = (Usuario)dgvListaUsr.CurrentRow.DataBoundItem;
            try
            {
                _usuarioController.EliminarUsuario(usuarioSelected.IDUser);
                MessageBox.Show("Se elimino el registro correctamente.");
            }
            catch (Exception)
            {
                throw;
            }
            LoadUsuarios();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dgvListaUsr.DataSource = listaUsuarios;
            else if (txtSearch.Text != "Buscar...")
            {
                List<Usuario> lista;
                lista = listaUsuarios.FindAll(m => m.Apellido.ToLower().Contains(txtSearch.Text.ToLower())
                                                || m.Nombre.ToLower().Contains(txtSearch.Text.ToLower())
                                                || m.Nombre.ToLower().Contains(txtSearch.Text.ToLower()));
                dgvListaUsr.DataSource = lista;
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

    }
}
