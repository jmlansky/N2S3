using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Entidades
{
  public class PedidosLista:List<Pedido>
    {
      /// <summary>
      /// Constructor que recibe un datatable y lo parsea a si mismo a una lista de pedidos
      /// </summary>
        /// <param name="pPedidos">DataTable</param>
      public PedidosLista(DataTable pPedidos)
      {
          Pedido oPedido = null;
          foreach (DataRow pedRow in pPedidos.Rows)
          {

              oPedido = new Pedido();
              oPedido.idPedido = Convert.ToInt32(pedRow["idPedido"].ToString());
              oPedido.fechaPedido = pedRow["fechaPedido"].ToString();
              oPedido.horaPedido = pedRow["horaPedido"].ToString();
              oPedido.domicilioEntregaPedido = pedRow["domicilioEntregaPedido"].ToString();
              oPedido.montoTotalPedido = Convert.ToDecimal(pedRow["montoTotalPedido"].ToString());

              this.Add(oPedido);
          }
      }

      /// <summary>
      /// Constructor si parametros
      /// </summary>
      public PedidosLista()
      {

      }

    }
}
