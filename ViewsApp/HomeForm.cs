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
            new FormListaUsuariosForm().Show();
            this.Dispose(false);
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            new ListaProductosForm().Show();
            this.Dispose(false);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            new VentasForm().Show();
            this.Dispose(false);
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            new ListaClientesForm().Show();
            this.Dispose(false);
        }

        private void btnControlStock_Click(object sender, EventArgs e)
        {
            new StockForm().Show();
            this.Dispose(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestionProveedores_Click(object sender, EventArgs e)
        {
            new ListaProveedoresForm().Show();
            this.Dispose(false);
        }
    }
}
