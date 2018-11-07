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
    public partial class ProductoCompraForm : Form
    {
        private ProductoController _productoController = new ProductoController();
        public ProductoOperacion prdCmp = new ProductoOperacion();
        int provCode;
        public ProductoCompraForm(int provCode)
        {
            InitializeComponent();
            this.provCode = provCode;
        }

        private void ProductoCompraForm_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.DataSource = _productoController.GetCatalogoByProveedor(this.provCode);
            cmbProductos.DisplayMember = "Descripcion";
            cmbProductos.ValueMember = "Code";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ProveedorType selected = (ProveedorType)cmbProductos.SelectedItem;
            prdCmp.IDProducto = (int)cmbProductos.SelectedValue;
            prdCmp.Descripcion = cmbProductos.Text;
            prdCmp.Cantidad = int.Parse(txtCant.Text);
            prdCmp.Precio = int.Parse(txtImporte.Text);
            prdCmp.Subtotal = int.Parse(txtCant.Text) * decimal.Parse(txtImporte.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
