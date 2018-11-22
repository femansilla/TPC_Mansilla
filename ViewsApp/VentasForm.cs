using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;


namespace ViewsApp
{
    public partial class VentasForm : Form
    {
        private readonly ProductoController controller = new ProductoController();
        private List<Producto> listaP;
        public List<ProductoOperacion> list = new List<ProductoOperacion>();
        public Usuario currentUser;

        public VentasForm()
        {
            InitializeComponent();
        }

        private void CargarComboProductType()
        {
            cmbProductTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ///cmbPerfilType.Text = "Seleccione...";
            var todo = new ProveedorType() { Code = 0, Descripcion = "Todo" };
            var listCmb = controller.GetAllTypes();
            listCmb.Add(todo);
            listCmb = listCmb.OrderBy(x => x.Code).ToList();
            cmbProductTypeFilter.DataSource = listCmb;
            cmbProductTypeFilter.DisplayMember = "Descripcion";
            cmbProductTypeFilter.ValueMember = "Code";
        }

        private void CargarProductosEnForm()
        {
            listaP = controller.GetProductos();
            var a = listaP;
            List<ProductoForm> lista = new List<ProductoForm>();
            foreach (var item in a)
            {
                item.Precio = controller.GetPrecioPrd(item.IDProducto);
                item.ProductType = controller.GetDescripcionTipoProducto(item.IDProducto);
                ProductoForm frmView = new ProductoForm()
                {
                    Code = item.IDProducto,
                    Descripcion = item.Descripcion,
                    Precio = item.Precio
                };
                frmView.TopLevel = false;
                frmView.SetearImagen(item.ImagenByte);
                Products.Controls.Add(frmView);
                frmView.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            CargarProductosEnForm();
            CargarComboProductType();
            btnDelFilterType_Click(sender, e);
        }

        private void dgvVentaActual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDialog();
        }

        private void txtCantidad_MouseClick(object sender, MouseEventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void btnAgregarPrdADgv_Click(object sender, EventArgs e)
        {
            if (dgvVentaActual.DataSource != null)
            {
                list = dgvVentaActual.DataSource as List<ProductoOperacion>;
            }

            foreach (ProductoForm i in Products.Controls)
            {
                if (i.DialogResult == DialogResult.OK)
                {
                    i.color = (!i.color) ? true : false;
                    int cant = int.Parse(txtCantidad.Text);
                    list.Add(new ProductoOperacion()
                    {
                        IDProducto = i.Code,
                        Descripcion = i.Descripcion,
                        Precio = i.Precio,
                        Cantidad = cant,
                        Subtotal = i.Precio * cant
                    });
                    i.DialogResult = DialogResult.None;
                    dgvVentaActual.DataSource = null;
                    dgvVentaActual.DataSource = list;
                }
                else
                {
                    MessageBox.Show("No selecciono ningun producto...");
                    return;
                }
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("No indico la cantidad para la operacion...");
                    return;
                }
                i.Refresh();
            }

            dgvVentaActual.Columns[0].Visible = false;
            dgvVentaActual.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvVentaActual.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvVentaActual.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvVentaActual.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            txtCantidad.Text = "Cantidad...";
        }

        private void cmbProductTypeFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedType = (ProveedorType)cmbProductTypeFilter.SelectedItem;
            List<Producto> ret = new List<Producto>();
            if (selectedType.Code != 0)
                ret = listaP.FindAll(p => p.ProductType == selectedType.Descripcion);
            ReloadProducts(ret);
        }

        private void ReloadProducts(List<Producto> ret)
        {
            var a = ret;
            List<ProductoForm> lista = new List<ProductoForm>();
            Products.Controls.Clear();
            foreach (var item in a)
            {
                ProductoForm frmView = new ProductoForm()
                {
                    Code = item.IDProducto,
                    Descripcion = item.Descripcion,
                    Precio = item.Precio
                };
                frmView.TopLevel = false;
                frmView.SetearImagen(item.ImagenByte);
                Products.Controls.Add(frmView);
                frmView.Show();
            }
            Refresh();
        }

        private void btnDelFilterType_Click(object sender, EventArgs e)
        {
            var ret = listaP;
            cmbProductTypeFilter.SelectedValue = 0;
            ReloadProducts(ret);
        }
    }
}
