﻿using System;
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
        private DomicilioForm formDomi;
        private readonly UsuarioController _usuarioController = new UsuarioController();
        private readonly DomicilioController _domicilioController = new DomicilioController();


        public FichaUsuarioForm()
        {
            InitializeComponent();
            CargarComboProfileType();
            //dgvDomicilios.Columns["ID"].Visible = false;
        }

        public FichaUsuarioForm(int iDUser)
        {
            this.iDUser = iDUser;
            InitializeComponent();
            CargarComboProfileType();
            CargarDatosUsuario();
        }

        private void CargarComboProfileType()
        {
            cmbPerfilType.DropDownStyle = ComboBoxStyle.DropDownList;
            ///cmbPerfilType.Text = "Seleccione...";
            cmbPerfilType.DataSource = _usuarioController.GetAllUserTypes();
            cmbPerfilType.DisplayMember = "Descripcion";
            cmbPerfilType.ValueMember = "Code";
        }

        private void CargarDatosUsuario()
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
            cmbPerfilType.SelectedValue = u.UserTypeCode;
            dgvDomicilios.DataSource = _domicilioController.GetDomiciliosByPerson("Usuario", iDUser);
            FormatDGV();
        }

        private void FormatDGV()
        {
            dgvDomicilios.Columns["Provincia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDomicilios.Columns["Localidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDomicilios.Columns["Calle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDomicilios.Columns["ID"].Visible = false;
            dgvDomicilios.Columns["Piso"].Visible = false;
            dgvDomicilios.Columns["Departamento"].Visible = false;
        }

        private void btnAddDomicilio_Click(object sender, EventArgs e)
        {
            formDomi = new DomicilioForm();
            formDomi.ShowDialog();
            if(formDomi.ActiveControl.Text != "Cancelar")
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
                    li.Add(domi);
                li.Add(FD.GetDomicilioIngresado());
            }
            else
                li.Add(FD.GetDomicilioIngresado());
            dgvDomicilios.DataSource = li;
            FormatDGV();
        }

        private void btnDelDomicilio_Click(object sender, EventArgs e)
        {
            try
            {
                var dataDGV = dgvDomicilios.DataSource as List<Direccion>;
                if(dgvDomicilios.DataSource != null)
                {
                    if (dataDGV.Count > 1)
                         dataDGV.Remove((Direccion)dgvDomicilios.CurrentRow.DataBoundItem);
                         //dgvDomicilios.Rows.RemoveAt(dgvDomicilios.CurrentRow.Index);
                }
                dgvDomicilios.DataSource = null;
                dgvDomicilios.DataSource = dataDGV;
                FormatDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReLoadDgvDomicilio(List<Direccion> li)
        {
            var dataList = dgvDomicilios.DataSource as List<Direccion>;
            if (dgvDomicilios.DataSource != null)
            {
                foreach (var domi in dataList)
                    li.Add(domi);
            }
            dgvDomicilios.DataSource = li;
            FormatDGV();
        }

        private void dgvDomicilios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formDomi = new DomicilioForm(this.iDUser);
            formDomi.ShowDialog();
            ReLoadDgvDomicilio(formDomi);
            formDomi.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UserTypes usrType = (UserTypes)cmbPerfilType.SelectedItem;
            Usuario user = new Usuario()
            {
                IDUser = this.iDUser,
                UserName = lblUsuarioID.Text,
                UserTypeCode = usrType.Code,
                UserType = usrType.Descripcion,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Sex = (rdMale.Checked) ? true : false,
                SexDescription = (rdMale.Checked) ? "M" : "F",
                FechaNac = dtFechaNac.Value,
                DomicilioUser = dgvDomicilios.DataSource as List<Direccion>
            };
            try
            {
                _usuarioController.SaveUser(user);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
                throw;
            }
        }

        private void FichaUsuarioForm_Load(object sender, EventArgs e)
        {
            if(dgvDomicilios.DataSource != null)
            {
                dgvDomicilios.Columns["ID"].Visible = false;
                btnDelDomicilio.Enabled = true;
            }
            else
            {
                btnDelDomicilio.Enabled = false;
            }
        }

        private void dgvDomicilios_DataSourceChanged(object sender, EventArgs e)
        {
            btnDelDomicilio.Enabled = true;
        }
    }
}
