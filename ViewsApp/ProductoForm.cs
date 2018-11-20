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
        public bool color = false;

        public ProductoForm()
        {
            InitializeComponent();
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
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void imgProduct_Click(object sender, EventArgs e)
        {
            if ((Color)imgProduct.Tag == Color.Yellow) { imgProduct.Tag = Color.Red; }
            else { imgProduct.Tag = Color.White; }
            imgProduct.Refresh();
            DialogResult = DialogResult.OK;
        }

        private void imgProduct_MouseHover(object sender, EventArgs e)
        {
            if ((Color)imgProduct.Tag == Color.White)
                { imgProduct.Tag = Color.Yellow; }
            else if ((Color)imgProduct.Tag == Color.Red)
                { imgProduct.Tag = Color.Yellow; }
            imgProduct.Refresh();
        }

        private void imgProduct_Paint(object sender, PaintEventArgs e)
        {
            if (imgProduct.Tag == null || color) { imgProduct.Tag = Color.White; } //Sets a default color
            ControlPaint.DrawBorder(e.Graphics, imgProduct.ClientRectangle, (Color)imgProduct.Tag, ButtonBorderStyle.Solid);

        }

        private void imgProduct_MouseLeave(object sender, EventArgs e)
        {
            if ((Color)imgProduct.Tag == Color.Red)
                { imgProduct.Tag = Color.Red; }
            else if((Color)imgProduct.Tag == Color.Yellow)
                { imgProduct.Tag = Color.White; }
            else if ((Color)imgProduct.Tag == Color.White)
                { imgProduct.Tag = Color.White; }
            imgProduct.Refresh();
        }
    }
}
