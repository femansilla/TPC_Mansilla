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
using Business;
using System.IO;
using ViewsApp.Properties;
using System.Reflection;

namespace ViewsApp
{
    public partial class FichaProductoForm : Form
    {
        private ProductoController _productoController = new ProductoController();
        Producto prd = new Producto();

        public FichaProductoForm()
        {
            InitializeComponent();
            lblIdProduct.Visible = false;
        }

        public FichaProductoForm(int id)
        {
            InitializeComponent();
            lblIdProduct.Visible = false;
            lblIdProduct.Text = id.ToString();
            prd = _productoController.GetProducto(id);
        }

        private void CargarDatosProducto()
        {
            txtDescripcion.Text = prd.Descripcion;
            SelectTypeFromProduct(prd.ProductType);
            txtImagen.Text = prd.Imagen;
        }

        private void SelectTypeFromProduct(string descripcion)
        {
            var list = cmbTypeProduct.DataSource as List<ProveedorType>;
            var selected = list.Find(t => t.Descripcion == descripcion);
            cmbTypeProduct.SelectedValue = selected.Code;
        }

        public Producto getProducto()
        {
            return new Producto()
            {
                Descripcion = txtDescripcion.Text
            };
        }

        private void GuardarProducto()
        {
            //code, descripcion, tipo e imagen
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El Campo descripcion no puede estar vacio.");
                return;
            }
            if (txtImagen.Text.Equals("GenericProduct") || string.IsNullOrEmpty(txtImagen.Text))
            {
                //string assmblypath = Assembly.GetEntryAssembly().Location;
                //string appPath = Path.GetDirectoryName(assmblypath);
                //string path = Path.GetFullPath("..\\ViewApp\\Resources\\GenericProduct.png");
                string path = "C:\\Users\\Francisco Mansilla\\Pictures\\GenericProduct.png";
                txtImagen.Text = path;
            }
            var selectedType = (ProveedorType)cmbTypeProduct.SelectedItem;
            if (prd.IDProducto != 0)
            {
                _productoController.SaveProducto(prd.IDProducto, txtDescripcion.Text, selectedType.Code, txtImagen.Text);
                MessageBox.Show("Producto modificado correctamente.");
                Close();
            }
            else
            {
                _productoController.SaveProducto(prd.IDProducto, txtDescripcion.Text, selectedType.Code, txtImagen.Text);
                MessageBox.Show("Producto agregado correctamente.");
                Close();
            }
        }
        
        private void CargarComboCategorias()
        {
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.DataSource = _productoController.GetAllCategorias();
            cmbCategorias.DisplayMember = "Descripcion";
            cmbCategorias.ValueMember = "Code";
        }

        private void CargarComboTypes()
        {
            cmbTypeProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            ///cmbPerfilType.Text = "Seleccione...";
            cmbTypeProduct.DataSource = _productoController.GetAllTypes();
            cmbTypeProduct.DisplayMember = "Descripcion";
            cmbTypeProduct.ValueMember = "Code";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExaminar_MouseClick(object sender, MouseEventArgs e)
        {
            //OpenFileDialog para que abra la ventanita que te deja buscar
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            //Path.GetFullPath es para saber la dirección completa y poder guardarla.
            //para usarla tuve que incluir System.IO
            if (string.IsNullOrEmpty(file.FileName))
            {
                txtImagen.Text = "GenericProduct";
            }
            else
                txtImagen.Text = Path.GetFullPath(file.FileName);
        }

        private void FichaProductoForm_Load(object sender, EventArgs e)
        {
            //CargarComboCategorias();
            CargarComboTypes();
            if(prd.IDProducto != 0)
                CargarDatosProducto();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
