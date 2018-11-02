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

namespace ViewsApp
{
    public partial class LoginForm : Form
    {
        private UsuarioController controller = new UsuarioController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginUser()
        {
            string usr = this.txtUserName.Text.Trim();
            string pass = this.txtPassword.Text.Trim();
            bool val = controller.iniciarSesion(usr, pass);
            if (!val)
                MessageBox.Show("Usuario o clave incorrecto. \r\nVerifique por favor.");
            else
            {
                this.Close();
                //new HomeForm().Show();
                //this.Dispose(false);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LoginUser();
        }
    }
}
