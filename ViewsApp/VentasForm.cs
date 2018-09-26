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
            var a = controller.GetProductos();
            //List<ProductoForm> lista = new List<ProductoForm>();
            //foreach (var item in a)
            //{
            //    ProductoForm frmView = new ProductoForm()
            //    {
            //        Descripcion = item.Descripcion
            //    };
            //    (frmView);
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }
        
    }
}
