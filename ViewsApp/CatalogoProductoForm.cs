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
    public partial class CatalogoProductoForm : Form
    {
        private int ProvCode;
        private readonly ProductoController _productoController = new ProductoController();


        public CatalogoProductoForm()
        {
            InitializeComponent();
            LoadProductos();
        }

        public CatalogoProductoForm(int iD)
        {
            InitializeComponent();
            this.ProvCode = iD;
            LoadProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public void LoadProductos()
        {
            dgvDescripcion.DataSource = _productoController.GetCatalogoByProveedor(ProvCode);
            dgvDescripcion.Columns[0].Visible = false;
            dgvDescripcion.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
