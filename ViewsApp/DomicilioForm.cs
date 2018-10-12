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
    public partial class DomicilioForm : Form
    {
        public DomicilioForm()
        {
            InitializeComponent();
        }

        public Direccion GetDomicilioIngresado()
        {
            return new Direccion()
            {
                ID = int.Parse(lblCodeDireccion.Text),
                Provincia = txtProvincia.Text,
                Localidad = txtLocalidad.Text,
                Calle = txtCalle.Text,
                Altura = int.Parse(txtCalle.Text),
                Piso = int.Parse(txtPiso.Text),
                Departamento = int.Parse(txtDpto.Text)
            };
        }
    }
}
