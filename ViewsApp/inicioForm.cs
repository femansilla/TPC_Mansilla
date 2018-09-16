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
    public partial class inicioForm : Form
    {
        private UsuarioController controller = new UsuarioController();
        public inicioForm()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usr = this.txtUserName.Text;
            string pass = this.txtPassword.Text;
            bool val = controller.iniciarSesion(usr, pass);
            if (!val)
                MessageBox.Show("Usuario o clave incorrecto. \r\nVerifique por favor.");
            else
            {
                new ListaProductos().Show();
                this.Hide();
            }
                
        }
    }
}
