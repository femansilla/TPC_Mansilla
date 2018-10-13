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
    public partial class FichaUsuarioForm : Form
    {
        private int iDUser;
        private readonly UsuarioController _usuarioController = new UsuarioController();

        public FichaUsuarioForm()
        {
            InitializeComponent();
            CargarComboProfileType();
        }

        public FichaUsuarioForm(int iDUser)
        {
            this.iDUser = iDUser;
            InitializeComponent();
            CargarComboProfileType();
            CargarContenidoUsuario();
            
        }

        private void CargarComboProfileType()
        {
            cmbPerfilType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfilType.Text = "Seleccione...";
            var loqiesea = _usuarioController.GetAllUserTypes();
            cmbPerfilType.DataSource = _usuarioController.GetAllUserTypes();
            cmbPerfilType.DisplayMember = "Descripcion";
            cmbPerfilType.ValueMember = "Code";
        }
        private void CargarContenidoUsuario()
        {
            Usuario u = _usuarioController.GetUsuarioById(iDUser);
            txtApellido.Text = u.Apellido;
            txtNombre.Text = u.Nombre;
            dtFechaNac.Value = u.FechaNac;
            if (u.Sex)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            lblUsuarioID.Text = u.UserName;
            cmbPerfilType.SelectedValue = 2;
        }

        private void btnAddDomicilio_Click(object sender, EventArgs e)
        {
            DomicilioForm formDomi = new DomicilioForm();
            formDomi.ShowDialog();
            ReLoadDgvDomicilio(formDomi);
            formDomi.Close();
        }

        private void ReLoadDgvDomicilio(DomicilioForm FD)
        {
            var li = new List<Direccion>();
            var dataList = dgvDomicilios.DataSource as List<Direccion>;
            if (dgvDomicilios.DataSource != null)
            {
                foreach (var domi in dataList)
                {
                    li.Add(domi);
                }
                li.Add(FD.GetDomicilioIngresado());
            }
            else
            {
                li.Add(FD.GetDomicilioIngresado());
            }
            dgvDomicilios.DataSource = li;
        }

        private void btnDelDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void dgvDomicilios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
