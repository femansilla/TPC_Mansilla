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
        private List<Producto> listProducts;
        public Usuario currentUser;
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
            FormatDGV();
        }

        private void FormatDGV()
        {
            dgvProductos.Columns["IDProducto"].Visible = false;
            dgvProductos.Columns["Categoria"].Visible = false;
            dgvProductos.Columns["Imagen"].Visible = false;
            dgvProductos.Columns["ImagenByte"].Visible = false;
            dgvProductos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadProducts()
        {
            listProducts = _productoController.GetProductos();
            foreach (var i in listProducts)
            {
                i.Precio = _productoController.GetPrecioPrd(i.IDProducto);
                i.StockProduct = _productoController.GetStockPrd(i.IDProducto);
            }
            dgvProductos.DataSource = listProducts;
        }
      
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            Producto productoSelected = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FichaProductoForm editProduct = new FichaProductoForm(productoSelected.IDProducto);
            editProduct.ShowDialog();
            LoadProducts();
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto productoSelected = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            FichaProductoForm editProduct = new FichaProductoForm(productoSelected.IDProducto);
            editProduct.ShowDialog();
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                dgvProductos.DataSource = listProducts;
            else if (txtSearch.Text != "Buscar...")
            {
                List<Producto> lista;
                lista = listProducts.FindAll(m => m.Descripcion.ToLower().Contains(txtSearch.Text.ToLower()));
                dgvProductos.DataSource = lista;
                FormatDGV();
            }
        }
    }
}
