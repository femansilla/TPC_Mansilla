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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usr = this.txtUserName.Text.Trim();
            string pass = this.txtPassword.Text.Trim();
            bool val = controller.iniciarSesion(usr, pass);
            if (!val)
                MessageBox.Show("Usuario o clave incorrecto. \r\nVerifique por favor.");
            else
            {
                new HomeForm().Show();
                this.Dispose(false);
            }
                
        }
    }
}
