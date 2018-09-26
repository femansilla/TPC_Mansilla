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
        private readonly ProductoController controller = new ProductoController();
        public ListaProductosForm()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new FichaProductoForm().ShowDialog();
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            var a = controller.GetProductos();
            List<ProductoForm> lista = new List<ProductoForm>();
            foreach (var item in a)
            {
                ProductoForm frmView = new ProductoForm()
                {
                    Descripcion = item.Descripcion
                };
                lista.Add(frmView);
            }
            dgvProductos.DataSource = a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            var productoSelected = new Producto();
            foreach (DataGridViewRow row in dgvProductos.SelectedRows)
            {
                productoSelected = (Producto)row.DataBoundItem;             
            }
            new FichaProductoForm(productoSelected.IDProducto).ShowDialog();            
        }
    }
}
