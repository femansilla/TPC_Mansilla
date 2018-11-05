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
        private readonly ProveedorController _operacionesController = new ProveedorController();
        private List<Compra> listaCompras = new List<Compra>();

        public ListaComprasForm()
        {
            InitializeComponent();
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {
            //LoadCompras();
            txtSearch.Text = "Buscar...";
            //listaCompras = dgvCompras.DataSource as List<Compra>;
        }

        private void LoadCompras()
        {
            //dgvCompras.DataSource = _operacionesController.GetAllCompras();
            dgvCompras.Columns["Password"].Visible = false;
            dgvCompras.Columns["CUIT"].Visible = false;
            dgvCompras.Columns["Sex"].Visible = false;
            dgvCompras.Columns["UserTypeCode"].Visible = false;
            dgvCompras.Columns["IDUser"].Visible = false;

            dgvCompras.Columns["Nombre"].DisplayIndex = 0;
            dgvCompras.Columns["Apellido"].DisplayIndex = 1;
            dgvCompras.Columns["SexDescription"].DisplayIndex = 2;
            dgvCompras.Columns["FechaNac"].DisplayIndex = 3;
            dgvCompras.Columns["UserName"].DisplayIndex = 4;
            dgvCompras.Columns["UserType"].DisplayIndex = 5;

            dgvCompras.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                dgvCompras.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
