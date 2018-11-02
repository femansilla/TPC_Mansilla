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
    public partial class ProductTypeForm : Form
    {
        public ProveedorType retType = new ProveedorType();
        private int code;

        public ProductTypeForm()
        {
            InitializeComponent();
        }

        public ProductTypeForm(int code)
        {
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

        private void ProductTypeForm_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = retType.Descripcion;
        }
    }
}
