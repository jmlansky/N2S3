using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class DetallePedidoLista:List<DetallePedido>
    {
       /// <summary>
       /// Constructor con el seteo de la tabla de detalles
       /// </summary>
       /// <param name="pListaDet"></param>
       public DetallePedidoLista(DataTable pListaDet)
       {
           DetallePedido oDetalle = null;

           // se recorre la tabla de detalles de pedidos
           foreach (DataRow oDetRow in pListaDet.Rows)
           {
               oDetalle = new DetallePedido();
               oDetalle.cantidadProductoDetallePedido = Convert.ToInt32(oDetRow["cantidadProductoDetallePedido"].ToString());
               oDetalle.idDetallePedido = Convert.ToInt32(oDetRow["idDetallePedido"].ToString());
               oDetalle.idPedido = Convert.ToInt32(oDetRow["idPedido"].ToString());
               oDetalle.idProducto = Convert.ToInt32(oDetRow["idProducto"].ToString());
               oDetalle.observacionDetallePedido = oDetRow["observacionDetallePedido"].ToString();

               // se agrega a la lista el nuevo detalle
               this.Add(oDetalle);
           }
       }
    }
}
