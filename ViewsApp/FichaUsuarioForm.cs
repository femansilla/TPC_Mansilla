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

namespace Domain
{
    public partial class FichaUsuarioForm : Form
    {
        private int iDUser;
        private readonly UsuarioController _usuarioController = new UsuarioController();

        public FichaUsuarioForm()
        {
            InitializeComponent();
            CargarComboProfileType();
        }

        private void CargarComboProfileType()
        {
            cmbPerfilType.DropDownStyle = ComboBoxStyle.DropDownList;
            var loqiesea = _usuarioController.GetAllUserTypes();
            cmbPerfilType.DataSource = _usuarioController.GetAllUserTypes();
            cmbPerfilType.DisplayMember = "Descripcion";
            cmbPerfilType.ValueMember = "Code";
        }

        public FichaUsuarioForm(int iDUser)
        {
            this.iDUser = iDUser;
            CargarComboProfileType();

        }

        private void FichaUsuarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
