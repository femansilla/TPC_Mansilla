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
    public partial class ProductoOperacionForm : Form
    {


        public ProductoOperacionForm()
        {
            InitializeComponent();
        }

        private void dgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("gola");
        }

        private void ProductoOperacionForm_Load(object sender, EventArgs e)
        {
            //DataGridViewTextBoxColumn txtCode;
            //DataGridViewCheckBoxColumn columCheck;
            //DataGridViewTextBoxColumn txtDescripcion;
            //DataGridViewButtonColumn btnBajarCant;
            //DataGridViewTextBoxColumn txtCant;
            //DataGridViewButtonColumn btnMasCant;
            //DataGridViewTextBoxColumn txtImporte;
        }
    }
}
