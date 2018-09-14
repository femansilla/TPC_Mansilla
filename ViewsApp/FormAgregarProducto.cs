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
    public partial class FormAgregarProducto : Form
    {
        private ProductoController controller = new ProductoController();
        public FormAgregarProducto()
        {
            InitializeComponent();
        }
        public Producto getProducto()
        {
            return new Producto()
            {
                Descripcion = textBox1.Text
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            controller.AgregarProducto(getProducto());
            Application.UseWaitCursor = false;
            this.textBox1.Clear();
            MessageBox.Show("Producto agregado correctamente.");
        }
    }
}
