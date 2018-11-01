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
    public partial class ProductTypesForm : Form
    {
        private readonly ProveedorController _productoController = new ProveedorController();

        public ProductTypesForm()
        {
            InitializeComponent();
        }

        private void ProductTypesForm_Load(object sender, EventArgs e)
        {
            CargarTypes();
        }

        public void CargarTypes()
        {
            dgvDescripcion.DataSource = _productoController.GetAllTypes();
            dgvDescripcion.Columns[0].Visible = false;
            dgvDescripcion.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void editType()
        {
            if (dgvDescripcion.DataSource != null)
            {
                ProveedorType typeSelected = (ProveedorType)dgvDescripcion.CurrentRow.DataBoundItem;
                productTypeForm frm = new productTypeForm(typeSelected.Code);
                frm.retType.Descripcion = typeSelected.Descripcion;
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    _productoController.SaveType(new ProveedorType()
                    { Code = frm.retType.Code, Descripcion = frm.retType.Descripcion });
                }
                else if (dr == DialogResult.Cancel)
                {
                    frm.Close();
                }
                CargarTypes();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productTypeForm frm = new productTypeForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                _productoController.SaveType(new ProveedorType()
                { Code = frm.retType.Code, Descripcion = frm.retType.Descripcion });
            }
            else if (dr == DialogResult.Cancel)
            {
                frm.Close();
            }
            CargarTypes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editType();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDescripcion != null)
            {
                ProveedorType typeSelected = (ProveedorType)dgvDescripcion.CurrentRow.DataBoundItem;
                _productoController.EliminarType(typeSelected.Code);
                CargarTypes();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
            new HomeForm().Show();
        }

    }
}
