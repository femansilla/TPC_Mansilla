using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            new FormListaUsuarios().Show();
            this.Hide();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            new ListaProductosForm().Show();
            this.Hide();
        }
    }
}
