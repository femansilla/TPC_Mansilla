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
    public partial class ProveedorTypesForm : Form
    {
        private readonly ProveedorController _proveedorController = new ProveedorController();

        public ProveedorTypesForm()
        {
            InitializeComponent();
            CargarTypes();
        }

        public void CargarTypes()
        {
            dgvDescripcion.DataSource = _proveedorController.GetAllTypes();
            dgvDescripcion.Columns[0].Visible = false;
            dgvDescripcion.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorTypeForm frm = new ProveedorTypeForm();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                _proveedorController.SaveType(new ProveedorType()
                { Code = frm.retType.Code, Descripcion = frm.retType.Descripcion });
            }
            else if (dr == DialogResult.Cancel)
            {
                frm.Close();
            }
            CargarTypes();
        }

        private void editType()
        {
            if(dgvDescripcion.DataSource != null)
            {
                ProveedorType typeSelected = (ProveedorType)dgvDescripcion.CurrentRow.DataBoundItem;
                ProveedorTypeForm frm = new ProveedorTypeForm(typeSelected.Code);
                frm.retType.Descripcion = typeSelected.Descripcion;
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    _proveedorController.SaveType(new ProveedorType()
                    { Code = frm.retType.Code, Descripcion = frm.retType.Descripcion });
                }
                else if (dr == DialogResult.Cancel)
                {
                    frm.Close();
                }
                CargarTypes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editType();
        }

        private void dgvDescripcion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editType();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvDescripcion != null)
            {
                ProveedorType typeSelected = (ProveedorType)dgvDescripcion.CurrentRow.DataBoundItem;
                _proveedorController.EliminarType(typeSelected.Code);
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
