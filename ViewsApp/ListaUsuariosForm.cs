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

        public ListaUsuariosForm()
        {
            InitializeComponent();
            LoadUsuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            new HomeForm().Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FichaUsuarioForm().ShowDialog();
            LoadUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelected = (Usuario)dgvListaUsr.CurrentRow.DataBoundItem;
            new FichaUsuarioForm(usuarioSelected.IDUser).ShowDialog();
            LoadUsuarios();
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuarioSelected = (Usuario)dgvListaUsr.CurrentRow.DataBoundItem;
        }

        public void LoadUsuarios()
        {
            dgvListaUsr.DataSource = _usuarioController.GetAllUsuarios();
            dgvListaUsr.Columns["Password"].Visible = false;
            dgvListaUsr.Columns["CUIT"].Visible = false;
            dgvListaUsr.Columns["Sex"].Visible = false;

            dgvListaUsr.Columns["IDUser"].DisplayIndex = 0;
            dgvListaUsr.Columns["Nombre"].DisplayIndex = 1;
            dgvListaUsr.Columns["Apellido"].DisplayIndex = 2;
            dgvListaUsr.Columns["SexDescription"].DisplayIndex = 3;
            dgvListaUsr.Columns["FechaNac"].DisplayIndex = 4;
            dgvListaUsr.Columns["UserName"].DisplayIndex = 5;
            dgvListaUsr.Columns["UserType"].DisplayIndex = 6;
        }

        private void dgvListaUsr_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario usuarioSelected = (Usuario)dgvListaUsr.CurrentRow.DataBoundItem;
            new FichaUsuarioForm(usuarioSelected.IDUser).ShowDialog();
            LoadUsuarios();
        }
    }
}
