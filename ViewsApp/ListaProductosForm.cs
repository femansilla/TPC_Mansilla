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
    public partial class ListaProductosForm : Form
    {
        private readonly ProductoController _productoController = new ProductoController();
        public ListaProductosForm()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FichaProductoForm().ShowDialog();
            LoadProducts();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            dgvProductos.DataSource = _productoController.GetProductos();
        }
      
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            new HomeForm().Show();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            Producto productoSelected = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FichaProductoForm editProduct = new FichaProductoForm(productoSelected.IDProducto);
            editProduct.FormClosed += editProduct_FormClosed;
            editProduct.Show();
        }

        void editProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
                LoadProducts();
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto productoSelected = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FichaProductoForm editProduct = new FichaProductoForm(productoSelected.IDProducto);
            editProduct.FormClosed += editProduct_FormClosed;
            editProduct.Show();
        }
    }
}
