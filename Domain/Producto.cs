using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domain
{
    public class Producto
    {
        [DisplayName("Codigo")]
        public int IDProducto { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
        [DisplayName("Precio")]
        public decimal Precio { get; set; }
        [DisplayName("Tipo")]
        public string ProductType { get; set; }
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public Stock StockProduct { get; set; }
    }

    public class ProductoDescripcion
    {
        public int Code { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
    }

    public class ProductoOperacion
    {
        [DisplayName("Codigo")]
        public int IDProducto { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
        [DisplayName("Precio")]
        public decimal Precio { get; set; }
        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }
        [DisplayName("Subtotal")]
        public decimal Subtotal { get; set; }
    }
}
