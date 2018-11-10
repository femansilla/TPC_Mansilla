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
    public partial class OperacionForm : Form
    {
        private OperacionesController _operacionController = new OperacionesController();
        private ProveedorController _proveedorController = new ProveedorController();
        List<ProductoOperacion> listProducts = new List<ProductoOperacion>();
        int code;
        string tipo;

        public OperacionForm()
        {
            InitializeComponent();
        }

        public OperacionForm(string tipo, int code)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.code = code;
            this.Enabled = false;
            CargarOperacion();
            cmbStatusOp.Enabled = true;
            btnAcept.Enabled = true;
        }

        private void CargarOperacion()
        {
            if (tipo.Equals("Compra"))
            {
                Compra op = _operacionController.GetOperacion("Compra", code) as Compra;
                txtReferencia.Text = op.Referencia;
                cmbByType.SelectedValue = op.ProveedorCode;
                dtFecha.Value = op.Fecha;
                dgvProductos.DataSource = op.ProductosCompra;
                CalcularTotalOperacion();
                cmbStatusOp.SelectedValue = op.EstadoCode;
            }
            else
            {
                Venta op = _operacionController.GetOperacion("Compra", code) as Venta;
                txtReferencia.Text = op.Referencia;
                cmbByType.SelectedValue = op.ClienteCode;
                dtFecha.Value = op.Fecha;
                dgvProductos.DataSource = op.ProductosVenta;
                CalcularTotalOperacion();
                cmbStatusOp.SelectedValue = op.EstadoCode;
            }
        }

        private void OperacionForm_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            cmbByType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbByType.DataSource = _proveedorController.GetAllProveedoresView();
            cmbByType.DisplayMember = "Descripcion";
            cmbByType.ValueMember = "Code";

            cmbStatusOp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusOp.DataSource = _operacionController.GetAllEstadosForOperacion();
            cmbStatusOp.DisplayMember = "Descripcion";
            cmbStatusOp.ValueMember = "Code";
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            var selected = (ProveedorType)cmbByType.SelectedItem;
            var selectedEstado = (ProveedorType)cmbStatusOp.SelectedItem;
            string total = lblTotalOperacion.Text;
            if (code != 0)
            {
                _operacionController.ModificarEstadoOperacion("Compra", code, selected.Code);
            }
            else
            {
                Compra cmp = new Compra()
                {
                    CodigoOperacion = code,
                    TipoOperacion = "Compra",
                    Fecha = dtFecha.Value,
                    EstadoCode = selectedEstado.Code,
                    ProveedorCode = selected.Code,
                    Referencia = txtReferencia.Text,
                    Importe = decimal.Parse(total.Substring(7)),
                    ProductosCompra = listProducts,
                };
                _operacionController.SaveCompra(cmp);
            }
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            int selectedProv = (int)cmbByType.SelectedValue;
            ProductoCompraForm frm = new ProductoCompraForm(selectedProv);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                listProducts.Add(frm.prdCmp);
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listProducts;
                dgvProductos.Columns["IDProducto"].Visible = false;
                CalcularTotalOperacion();
            }
            else if (dr == DialogResult.Cancel)
            {
                frm.Close();
            }
        }

        private void CalcularTotalOperacion()
        {
            List<ProductoOperacion> calculateInside = dgvProductos.DataSource as List<ProductoOperacion>;
            decimal tot = 0;
            foreach (var i in calculateInside)
            {
                tot += i.Subtotal;
            }
            lblTotalOperacion.Text = "Total: " + tot.ToString();
        }

        private void btnDelProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvProductos.DataSource as List<ProductoOperacion>;
                if (dgvProductos.DataSource != null)
                {
                    var selected = (ProductoOperacion)dgvProductos.CurrentRow.DataBoundItem;
                    if (dataDGV.Count > 1)
                        dataDGV.Remove(selected);
                }
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = dataDGV;
                dgvProductos.Columns["IDProducto"].Visible = false;
                CalcularTotalOperacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbByType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
