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

namespace ViewsApp
{
    public partial class ListaProductosForm : Form
    {
        private static ProductoController controller = new ProductoController();
        public ListaProductosForm()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            new AgregarProductoForm().Show();
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
    }
}
