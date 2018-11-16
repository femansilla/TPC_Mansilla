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
    public partial class HomeForm : Form
    {
        private UsuarioController _usuarioController = new UsuarioController();
        public Usuario currentUser = new Usuario();

        private void HomeForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    this.currentUser = login.currentUser;
                    CargarModulosByUsuario(currentUser.IDUser);
                }
                else
                    Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarModulosByUsuario(int iDUser)
        {
            btnGestionUsuarios.Enabled =
                (_usuarioController.AccessToModulo("gestionUsuarios", iDUser)) ? true : false;
            btnGestionProductos.Enabled =
                (_usuarioController.AccessToModulo("gestionProductos", iDUser)) ? true : false;
            btnGestionTiposProductos.Enabled = 
                (_usuarioController.AccessToModulo("gestionProductType", iDUser)) ? true : false;
            btnGestionClientes.Enabled =
                (_usuarioController.AccessToModulo("gestionClientes", iDUser)) ? true : false;
            btnGestionProveedores.Enabled =
                (_usuarioController.AccessToModulo("gestionProveedores", iDUser)) ? true : false;
            btnGestionTiposProveedores.Enabled =
                (_usuarioController.AccessToModulo("gestionProveedorType", iDUser)) ? true : false;
            btnGestionCompras.Enabled =
                (_usuarioController.AccessToModulo("gestionCompras", iDUser)) ? true : false;
            btnVentas.Enabled =
                (_usuarioController.AccessToModulo("gestionVentas", iDUser)) ? true : false;

        }


        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaUsuariosForm form = new ListaUsuariosForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaProductosForm form = new ListaProductosForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentasForm form = new VentasForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaClientesForm form = new ListaClientesForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }

        private void btnControlStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaComprasForm form = new ListaComprasForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaProveedoresForm form = new ListaProveedoresForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProveedorTypesForm form = new ProveedorTypesForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ListaComprasForm form = new ListaComprasForm();
            form.currentUser = this.currentUser;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
                this.Show();
            }
        }
    }
}
