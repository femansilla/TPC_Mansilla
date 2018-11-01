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
    public partial class OperacionForm : Form
    {
        private OperacionesController _operacionController = new OperacionesController();
        private proveedorController _proveedorController = new proveedorController();

        public OperacionForm()
        {
            InitializeComponent();
        }

        private void CargarCombo()
        {
            cmbByType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbByType.DataSource = _proveedorController.GetAllProveedores();
            cmbByType.DisplayMember = "Descripcion";
            cmbByType.ValueMember = "Code";
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnDelProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
