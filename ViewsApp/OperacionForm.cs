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

        public OperacionForm()
        {
            InitializeComponent();
        }

        public OperacionForm(int code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void OperacionForm_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            cmbByType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbByType.DataSource = _proveedorController.GetAllProveedoresView();
            cmbByType.DisplayMember = "Descripcion";
            cmbByType.ValueMember = "Code";
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            Compra cmp = new Compra()
            {
               CodigoOperacion = code,
               TipoOperacion = "Compra",
               ProductosCompra = listProducts,
               
            };
            _operacionController.SaveCompra(cmp);
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
            }
            else if (dr == DialogResult.Cancel)
            {
                frm.Close();
            }
        }

        private void btnDelProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvProductos.DataSource as List<ProductoOperacion>;
                if (dgvProductos.DataSource != null)
                {
                    if (dataDGV.Count > 1)
                        dataDGV.Remove((ProductoOperacion)dgvProductos.CurrentRow.DataBoundItem);
                }
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = dataDGV;
                //dgvProductos.Columns["ID"].Visible = false;
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

    }
}
