using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;

namespace ViewsApp
{
    public partial class ListaProveedoresForm : Form
    {
        private readonly ProveedorController _proveedorController = new ProveedorController();

        public ListaProveedoresForm()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }
    }
}
