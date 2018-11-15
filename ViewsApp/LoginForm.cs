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
    public partial class LoginForm : Form
    {
        private UsuarioController _usuarioController = new UsuarioController();
        public Usuario currentUser;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginUser()
        {
            string usr = this.txtUserName.Text.Trim();
            string pass = this.txtPassword.Text.Trim();
            int val = _usuarioController.iniciarSesion(usr, pass);
            if (val != 0)
            {
                DialogResult = DialogResult.OK;
                currentUser = _usuarioController.GetUsuarioById(val);
                Close();
            }
            else
                MessageBox.Show("Usuario o clave incorrecto. \r\nVerifique por favor.");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentUser.IDUser == 0)
            {
                Application.Exit();
            }
        }
    }
}
