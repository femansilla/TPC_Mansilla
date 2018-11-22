using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsApp
{
    public partial class ModificarCantPrdVentaForm : Form
    {
        public int cant;

        public ModificarCantPrdVentaForm()
        {
            InitializeComponent();
        }

        private void ModificarCantPrdVentaForm_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = cant.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("el campo no puede estar vacio.");
                return;
            }
            cant = int.Parse(txtCantidad.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
