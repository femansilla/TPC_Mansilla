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
    public partial class ListaComprasForm : Form
    {
        private readonly OperacionesController _operacionesController = new OperacionesController();
        private List<Compra> listaCompras = new List<Compra>();

        public ListaComprasForm()
        {
            InitializeComponent();
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {
            LoadCompras();
            txtSearch.Text = "Buscar...";
            listaCompras = dgvCompras.DataSource as List<Compra>;
        }

        private void LoadCompras()
        {
            dgvCompras.DataSource = _operacionesController.GetAllCompras();

            dgvCompras.Columns["CodigoOperacion"].DisplayIndex = 0;
            dgvCompras.Columns["Proveedor"].DisplayIndex = 1;
            dgvCompras.Columns["Referencia"].DisplayIndex = 2;
            dgvCompras.Columns["Fecha"].DisplayIndex = 3;
            dgvCompras.Columns["Importe"].DisplayIndex = 4;
            dgvCompras.Columns["Estado"].DisplayIndex = 5;

            dgvCompras.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OperacionForm opCompra = new OperacionForm();
            opCompra.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvCompras.DataSource as List<Direccion>;
                if (dgvCompras.DataSource != null)
                {
                    if (dataDGV.Count > 1)
                        dataDGV.Remove((Direccion)dgvCompras.CurrentRow.DataBoundItem);
                    //dgvDomicilios.Rows.RemoveAt(dgvDomicilios.CurrentRow.Index);
                }
                dgvCompras.DataSource = null;
                dgvCompras.DataSource = dataDGV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
