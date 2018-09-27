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
    public partial class VentasForm : Form
    {
        private readonly ProductoController controller = new ProductoController();
        public VentasForm()
        {
            InitializeComponent();
            CargarProductosEnForm();        
        }

        private void CargarProductosEnForm()
        {
            var a = controller.GetProductos();

            List<ProductoForm> lista = new List<ProductoForm>();
            foreach (var item in a)
            {
                ProductoForm frmView = new ProductoForm()
                {
                    Descripcion = item.Descripcion
                    
                };
                frmView.TopLevel = false;
                flProducts.Controls.Add(frmView);
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
        
    }
}
