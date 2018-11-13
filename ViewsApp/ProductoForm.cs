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

namespace ViewsApp
{
    public partial class ProductoForm : Form
    {
        public string Descripcion { get; set; }
        public int Code { get; set; }
        public decimal Precio { get; set; }

        public ProductoForm()
        {
            InitializeComponent();
        }

        private void ProductoForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void ProductoForm_Load(object sender, EventArgs e)
        {
            label1.Text = Descripcion;
        }

        public void SetearImagen(Byte[] data)
        {
            if(data != null)
            {
                Byte[] _data = new Byte[0];
                _data = data;
                MemoryStream mem = new MemoryStream(_data);
                imgProduct.Image = Image.FromStream(mem);
            }
        }

        private void ProductoForm_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgProduct_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
