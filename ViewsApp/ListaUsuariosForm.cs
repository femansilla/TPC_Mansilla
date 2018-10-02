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
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            new HomeForm().Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuariooSelected = (Usuario)dgListaUsr.CurrentRow.DataBoundItem;
            FichaUsuarioForm editUser = new FichaUsuarioForm(usuariooSelected.IDUser);
            editUser.FormClosed += editUser_FormClosed;
            editUser.Show();
        }

        void editUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
                LoadUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public void LoadUsuarios()
        {
            dgListaUsr.DataSource = _usuarioController.GetAllUsuarios();
        }
    }
}
