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
        private readonly ProductoController _productoController = new ProductoController();
        private readonly OperacionesController _operacionesController = new OperacionesController();
        private List<Producto> listaP;
        public List<ProductoOperacion> list = new List<ProductoOperacion>();
        public Usuario currentUser;
        public int clienteCde;


        public VentasForm()
        {
            InitializeComponent();
        }

        private void CargarComboProductType()
        {
            cmbProductTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ///cmbPerfilType.Text = "Seleccione...";
            var todo = new ProveedorType() { Code = 0, Descripcion = "Todo" };
            var listCmb = _productoController.GetAllTypes();
            listCmb.Add(todo);
            listCmb = listCmb.OrderBy(x => x.Code).ToList();
            cmbProductTypeFilter.DataSource = listCmb;
            cmbProductTypeFilter.DisplayMember = "Descripcion";
            cmbProductTypeFilter.ValueMember = "Code";
        }

        private void CargarProductosEnForm()
        {
            listaP = _productoController.GetProductos();
            var a = listaP;
            List<ProductoForm> lista = new List<ProductoForm>();
            foreach (var item in a)
            {
                item.Precio = _productoController.GetPrecioPrd(item.IDProducto);
                item.ProductType = _productoController.GetDescripcionTipoProducto(item.IDProducto);
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
            var DR = MessageBox.Show("Perdera los datos de la venta, esta seguro que desea continuar");
            DialogResult = (DR == DialogResult.OK) ? DialogResult.Cancel : DialogResult.OK;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            CargarCliente();
            CargarComboProductType();
            btnDelFilterType_Click(sender, e);
        }

        private void CargarCliente()
        {
            try
            {
                SelectionVentaForm selectClient = new SelectionVentaForm();
                selectClient.ShowDialog();
                if (selectClient.DialogResult == DialogResult.OK)
                {
                    clienteCde = selectClient.clienteCode;
                    CargarProductosEnForm(selectClient.ListCode);
                    selectClient.Close();
                }
                else
                {
                    selectClient.Close();
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarProductosEnForm(int listCode)
        {
            listaP = _productoController.GetProductos();
            var a = listaP;
            List<ProductoForm> lista = new List<ProductoForm>();
            foreach (var item in a)
            {
                item.Precio = _productoController.GetPrecioPrdByListPrice(item.IDProducto, listCode);
                item.ProductType = _productoController.GetDescripcionTipoProducto(item.IDProducto);
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

        private void dgvVentaActual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = (ProductoOperacion)dgvVentaActual.CurrentRow.DataBoundItem;
            try
            {
                ModificarCantPrdVentaForm frm = new ModificarCantPrdVentaForm();
                frm.cant = selectedItem.Cantidad;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    selectedItem.Cantidad = frm.cant;
                    selectedItem.Subtotal = selectedItem.Precio * selectedItem.Cantidad;
                    dgvVentaActual.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            bool selecPrd = false;
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No indico la cantidad para la operacion...");
                return;
            }
            foreach (ProductoForm i in Products.Controls)
            {
                if (i.DialogResult == DialogResult.OK)
                {
                    selecPrd = true;
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
                i.Refresh();
            }
            if(!selecPrd)
            {
                MessageBox.Show("No selecciono ningun producto...");
                return;
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
            if(listaP != null)
            {
                var ret = listaP;
                cmbProductTypeFilter.SelectedValue = 0;
                ReloadProducts(ret);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var a = _operacionesController.SaveVenta(new Venta()
            {
                ClienteCode = this.clienteCde,
                EstadoCode = 3,
                Fecha = DateTime.Now,
                ProductosVenta = dgvVentaActual.DataSource as List<ProductoOperacion>,
                UsuarioRealizoAccionCode = currentUser.IDUser
            });
            if (a) MessageBox.Show("Se guardo la venta correctamente");
            else MessageBox.Show("Ocurrieron errores al guardar la venta");
        }
    }
}
