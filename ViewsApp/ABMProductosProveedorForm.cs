using Business;
using Domain;
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
    public partial class ABMProductosProveedorForm : Form
    {
        private readonly ProductoController _productoController = new ProductoController();
        public int productCode;

        public ABMProductosProveedorForm()
        {
            InitializeComponent();
        }

        private void ABMProductosProveedorForm_Load(object sender, EventArgs e)
        {
            dgvAllProducts.DataSource = _productoController.GetProductos();
            FormatDGV();
        }

        private void FormatDGV()
        {
            dgvAllProducts.Columns["IDProducto"].Visible = false;
            dgvAllProducts.Columns["Precio"].Visible = false;
            dgvAllProducts.Columns["ProductType"].Visible = false;
            dgvAllProducts.Columns["StockProduct"].Visible = false;
            dgvAllProducts.Columns["Categoria"].Visible = false;
            dgvAllProducts.Columns["Imagen"].Visible = false;
            dgvAllProducts.Columns["ImagenByte"].Visible = false;
            dgvAllProducts.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvAllProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarProductoSeleccionado();
        }

        private void CargarProductoSeleccionado()
        {
            var selectedProducto = (Producto)dgvAllProducts.CurrentRow.DataBoundItem;
            productCode = selectedProducto.IDProducto;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CargarProductoSeleccionado();
        }
    }
}
