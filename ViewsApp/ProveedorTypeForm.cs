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
    public partial class productTypeForm : Form
    {
        private int code;
        public ProveedorType retType = new ProveedorType();
        public productTypeForm()
        {
            InitializeComponent();
            CancelButton = button2;
            this.code = 0;
        }

        public productTypeForm(int code)
        {
            InitializeComponent();
            CancelButton = button2;
            this.code = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retType.Code = code;
            retType.Descripcion = textBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ProveedorTypeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = retType.Descripcion;
        }
    }
}
