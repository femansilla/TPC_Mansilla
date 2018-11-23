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
        private List<Venta> listaVentas = new List<Venta>();
        public Usuario currentUser;
        private string Tipo;

        public ListaComprasForm()
        {
            InitializeComponent();
        }

        public ListaComprasForm(string tipo)
        {
            InitializeComponent();
            this.Tipo = tipo;
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Buscar...";
            dateFrom.MaxDate = DateTime.Now;
            dateTo.MaxDate = DateTime.Now;
            if(Tipo == "Compra")
            {
                LoadCompras();
                listaCompras = dgvCompras.DataSource as List<Compra>;

            }
            else
            {
                LoadVentas();
                listaVentas = dgvCompras.DataSource as List<Venta>;
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;

            }
        }

        private void LoadCompras()
        {
            dgvCompras.DataSource = _operacionesController.GetAllCompras();
            FormatDGVCompras();
        }
        private void LoadVentas()
        {
            dgvCompras.DataSource = _operacionesController.GetAllVentas();
            FormatDGVentas();
            
        }

        private void FormatDGVCompras()
        {
            dgvCompras.Columns["CodigoOperacion"].Visible = false;
            dgvCompras.Columns["ProveedorCode"].Visible = false;
            dgvCompras.Columns["EstadoCode"].Visible = false;
            dgvCompras.Columns["TipoOperacion"].Visible = false;
            dgvCompras.Columns["UsuarioRealizoAccionCode"].Visible = false;
            dgvCompras.Columns["Nombre"].Visible = false;
            dgvCompras.Columns["Apellido"].Visible = false;
            dgvCompras.Columns["CUIT"].Visible = false;

            dgvCompras.Columns["Proveedor"].DisplayIndex = 0;
            dgvCompras.Columns["Referencia"].DisplayIndex = 1;
            dgvCompras.Columns["Fecha"].DisplayIndex = 2;
            dgvCompras.Columns["Importe"].DisplayIndex = 3;
            dgvCompras.Columns["Estado"].DisplayIndex = 4;
            dgvCompras.Columns["UsuarioRealizoAccion"].DisplayIndex = 5;

            dgvCompras.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompras.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompras.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void FormatDGVentas()
        {
            dgvCompras.Columns["CodigoOperacion"].Visible = false;
            dgvCompras.Columns["TipoOperacion"].Visible = false;
            dgvCompras.Columns["EstadoCode"].Visible = false;
            dgvCompras.Columns["ClienteCode"].Visible = false;
            dgvCompras.Columns["UsuarioRealizoAccionCode"].Visible = false;
            
            dgvCompras.Columns["UsuarioRealizoAccion"].DisplayIndex = 0;
            dgvCompras.Columns["Fecha"].DisplayIndex = 1;
            dgvCompras.Columns["Referencia"].DisplayIndex = 2;
            dgvCompras.Columns["Cliente"].DisplayIndex = 3;
            dgvCompras.Columns["Estado"].DisplayIndex = 4;
            dgvCompras.Columns["Total"].DisplayIndex = 5;

            dgvCompras.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompras.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvCompras.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCompras.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OperacionForm opCompra = new OperacionForm();
            opCompra.currentUser = this.currentUser;
            opCompra.ShowDialog();
            if(opCompra.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Compra guardada correctamente.");
                opCompra.Close();
                LoadCompras();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvCompras.DataSource as List<Compra>;
                var selected = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                if (dgvCompras.DataSource != null)
                {
                    if (dataDGV.Count > 1)
                    {
                        dataDGV.Remove(selected);
                        _operacionesController.CancelarOperacion("Compra", selected.CodigoOperacion);
                        dgvCompras.Rows.RemoveAt(dgvCompras.CurrentRow.Index);
                    }
                }
                dgvCompras.DataSource = null;
                dgvCompras.DataSource = dataDGV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Compra selectedCMP;
            Venta selectedVTS;
            if(Tipo == "Compra")
            {
                selectedCMP = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                OperacionForm opCompra = new OperacionForm(Tipo, selectedCMP.CodigoOperacion);
                opCompra.ShowDialog();
            }
            else{
                selectedVTS = (Venta)dgvCompras.CurrentRow.DataBoundItem;
                OperacionForm opCompra = new OperacionForm(Tipo, selectedVTS.CodigoOperacion);
                opCompra.ShowDialog();
            }
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            dateTo.MinDate = dateFrom.Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(Tipo == "Compra")
            {
                if (txtSearch.Text == "")
                    dgvCompras.DataSource = listaCompras;
                else if (txtSearch.Text != "Buscar...")
                {
                    List<Compra> lista;
                    lista = listaCompras.FindAll(m => m.CUIT.ToLower().Contains(txtSearch.Text.ToLower()));
                    dgvCompras.DataSource = lista;
                    FormatDGVCompras();
                }
            }
            else
            {
                if (txtSearch.Text == "")
                    dgvCompras.DataSource = listaVentas;
                else if (txtSearch.Text != "Buscar...")
                {
                    List<Venta> lista;
                    lista = listaVentas.FindAll(m => m.UsuarioRealizoAccion.ToLower().Contains(txtSearch.Text.ToLower()));
                    dgvCompras.DataSource = lista;
                    FormatDGVentas();
                }
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
