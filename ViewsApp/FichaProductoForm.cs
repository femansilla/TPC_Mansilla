using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Business;

namespace ViewsApp
{
    public partial class FichaProductoForm : Form
    {
        private ProductoController _productoController = new ProductoController();

        public FichaProductoForm()
        {
            InitializeComponent();
            btnActualizar.Hide();
            lblIdProduct.Visible = false;
        }

        public FichaProductoForm(int id)
        {
            InitializeComponent();
            btnGuardar.Hide();
            lblIdProduct.Visible = false;
            lblIdProduct.Text = id.ToString();
            var prd = _productoController.GetProducto(id);
            txtDescripcion.Text = prd.Descripcion;
        }

        public Producto getProducto()
        {
            return new Producto()
            {
                Descripcion = txtDescripcion.Text
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            _productoController.AgregarProducto(getProducto());
            Application.UseWaitCursor = false;
            this.txtDescripcion.Clear();
            MessageBox.Show("Producto agregado correctamente.");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _productoController.EditarProducto(txtDescripcion.Text, int.Parse(lblIdProduct.Text));
        }
    }
}
