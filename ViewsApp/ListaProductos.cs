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
    public partial class ListaProductos : Form
    {
        private static ProductoController controller;
        public ListaProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FormAgregarProducto();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            controller.GetProductos();
        }
    }
}
