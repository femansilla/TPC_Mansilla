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
    public partial class CatalogoProductoForm : Form
    {
        private int ProvCode;
        private readonly ProductoController _productoController = new ProductoController();


        public CatalogoProductoForm()
        {
            InitializeComponent();
            LoadProductos();
        }

        public CatalogoProductoForm(int iD)
        {
            InitializeComponent();
            this.ProvCode = iD;
            LoadProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMProductosProveedorForm form = new ABMProductosProveedorForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _productoController.CreateRelationProductoProveedor(ProvCode, form.productCode);
                form.Close();
                LoadProductos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedProducto = (ProductoDescripcion)dgvDescripcion.CurrentRow.DataBoundItem;
            _productoController.DeleteRelationProductoProveedor(selectedProducto.Code, ProvCode);
            LoadProductos();
        }

        public void LoadProductos()
        {
            dgvDescripcion.DataSource = null;
            dgvDescripcion.DataSource = _productoController.GetCatalogoByProveedor(ProvCode);
            dgvDescripcion.Columns[0].Visible = false;
            dgvDescripcion.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDescripcion.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }   
    }
}
