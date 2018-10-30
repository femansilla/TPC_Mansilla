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
    public partial class ListaComprasForm : Form
    {
        public ListaComprasForm()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {

        }
    }
}
