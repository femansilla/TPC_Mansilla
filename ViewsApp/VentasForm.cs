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
    public partial class VentasForm : Form
    {
        private readonly ProveedorController controller = new ProveedorController();
        public VentasForm()
        {
            InitializeComponent();
        }

        private void CargarProductosEnForm()
        {
            var a = controller.GetProductos();

            List<ProductoForm> lista = new List<ProductoForm>();
            foreach (var item in a)
            {
                ProductoForm frmView = new ProductoForm()
                {
                    Descripcion = item.Descripcion                   
                };
                frmView.TopLevel = false;
                frmView.setLblDescripcion();
                flProducts.Controls.Add(frmView);
                frmView.Show();
                //lvProducts.Controls.Add(frmView);
                //frmView.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            CargarProductosEnForm();
        }
    }
}
