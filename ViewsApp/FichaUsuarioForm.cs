using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain
{
    public partial class FichaUsuarioForm : Form
    {
        private int iDUser;

        public FichaUsuarioForm()
        {
            InitializeComponent();
        }

        public FichaUsuarioForm(int iDUser)
        {
            this.iDUser = iDUser;
        }

        private void FichaUsuarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
