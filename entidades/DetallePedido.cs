using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetallePedido
    {
        public int idDetallePedido { set; get; }
        public long idPedido { set; get; }
        public long idProducto { set; get; }
        public int cantidadProductoDetallePedido { set; get; }
        public String observacionDetallePedido { set; get; }
        public decimal precioX1 { set; get; }
        public decimal precioX2 { set; get; }
        public decimal precioX3 { set; get; }

        public DetallePedido()
        {
            idDetallePedido = 0;
            idPedido = 0;
            idProducto = 0;
            cantidadProductoDetallePedido = 0;
            observacionDetallePedido = "";
            precioX1 = 0;
            precioX2 = 0;
            precioX3 = 0;
        }

        public DetallePedido(DetallePedido dp)
        {
            this.idDetallePedido = dp.idDetallePedido;
            this.idPedido = dp.idPedido;
            this.idProducto = dp.idProducto;
            this.cantidadProductoDetallePedido = dp.cantidadProductoDetallePedido;
            this.observacionDetallePedido = dp.observacionDetallePedido;
            this.precioX1 = dp.precioX1;
            this.precioX2 = dp.precioX2;
            this.precioX3 = dp.precioX3;
        }
    }
}
