using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetallePromocion
    {
        public long idPedido { set; get; }
        public long idProducto { set; get; }
        public string nombreProducto { set; get; }
        public int cantidadProducto { set; get; }
        public decimal precioX1 { set; get; }
        public decimal precioX2 { set; get; }
        public decimal precioX3 { set; get; }
        public String observacionProducto { set; get; }
        public int idDetallePromocion { set; get; }
        public decimal precioElegido { set; get; }


        public DetallePromocion()
        {
            idPedido = 0;
            idProducto = 0;
            nombreProducto = "";
            cantidadProducto = 0;
            precioX1 = 0;
            precioX2 = 0;
            precioX3 = 0;
            observacionProducto = "";
            idDetallePromocion = 0;
            precioElegido = 0;
        }

        public DetallePromocion(DetallePromocion dp)
        {
            this.idProducto = dp.idProducto;
            this.idPedido = dp.idPedido;
            this.nombreProducto = dp.nombreProducto;
            this.cantidadProducto = dp.cantidadProducto;
            this.precioX1 = dp.precioX1;
            this.precioX2 = dp.precioX2;
            this.precioX3 = dp.precioX3;
            this.observacionProducto = dp.observacionProducto;
            this.idDetallePromocion = dp.idDetallePromocion;
            this.precioElegido = dp.precioElegido;
        }

        public String getDatos()
        {
            return cantidadProducto + "- " + nombreProducto + " ("+observacionProducto +").\n";
        }
    }
}
