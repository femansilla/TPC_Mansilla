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
            new ListaUsuariosForm().ShowDialog();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            new ListaProductosForm().Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            new VentasForm().Show();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            new ListaClientesForm().Show();
        }

        private void btnControlStock_Click(object sender, EventArgs e)
        {
            new ListaComprasForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            new ListaProveedoresForm().Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new ProveedorTypesForm().Show();
        }
    }
}
