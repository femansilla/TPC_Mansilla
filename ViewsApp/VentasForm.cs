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
        public VentasForm()
        {
            InitializeComponent();
        }

        private void CargarProductosEnForm()
        {
            var a = controller.GetProductos();

            List<ProductoForm> lista = new List<ProductoForm>();
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
                //lvProducts.Controls.Add(frmView);
                //frmView.Show();
            }
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            CargarProductosEnForm();
        }
    }
}
