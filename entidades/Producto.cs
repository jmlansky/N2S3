using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        public long idProducto { set; get; }
        public String nombreProducto { set; get; }
        public decimal precioX1 { set; get; }
        public decimal precioX2 { set; get; }
        public decimal precioX3 { set; get; }
        public String observacionProducto { set; get; }

        public Producto()
        {
            idProducto = 0;
            nombreProducto = "";
            observacionProducto = "";
            precioX1 = 0;
            precioX2 = 0;
            precioX3 = 0;
        }

        public Producto(long idProducto, String nombreProducto, String observacionProducto, decimal precioX1, decimal precioX2, decimal precioX3)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.observacionProducto = observacionProducto;
            this.precioX1 = precioX1;
            this.precioX2 = precioX2;
            this.precioX3 = precioX3;
        }
    }
}
