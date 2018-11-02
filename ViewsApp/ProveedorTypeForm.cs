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

namespace ViewsApp
{
    public partial class ProveedorTypeForm : Form
    {
        private int code;
        public ProveedorType retType = new ProveedorType();
        public ProveedorTypeForm()
        {
            InitializeComponent();
            CancelButton = btnCancelar;
            this.code = 0;
        }

        public ProveedorTypeForm(int code)
        {
            InitializeComponent();
            CancelButton = btnCancelar;
            this.code = code;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            retType.Code = code;
            retType.Descripcion = txtDescripcion.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ProveedorTypeForm_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = retType.Descripcion;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
