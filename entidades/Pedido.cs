using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Pedido
    {
        public long idCliente { set; get; }
        public long idPedido { set; get; }
        public decimal montoTotalPedido { set; get; }
        public string fechaPedido { set; get; }
        public string horaPedido { set; get; }
        public string observacionPedido { set; get; }
        public string domicilioEntregaPedido { set; get; }
        public List<Promocion> listaPromociones { set; get; } 
        public decimal montoAbono { set; get; }
        public int tiempoDemora { set; get; }
        public int descuento { set; get; }
        public string nombreClienteMostrador { get; set; }

        public Pedido()
        {
            idCliente = 0;
            idPedido = 0;
            montoTotalPedido = 0;
            fechaPedido = "00/00/00";
            horaPedido = "00:00";
            observacionPedido = "";
            domicilioEntregaPedido = "";
            listaPromociones = new List<Promocion>();
            montoAbono = 0;
            tiempoDemora = 0;
            descuento = 0;
            nombreClienteMostrador = "";
        }

        public Pedido(Pedido ped)
        {
            idCliente = ped.idCliente; ;
            idPedido = ped.idPedido;
            montoTotalPedido = ped.montoTotalPedido;
            fechaPedido = ped.fechaPedido;
            horaPedido = ped.horaPedido;
            observacionPedido = ped.observacionPedido;
            domicilioEntregaPedido = ped.domicilioEntregaPedido;
            listaPromociones = ped.listaPromociones;
            montoAbono = ped.montoAbono;
            tiempoDemora = ped.tiempoDemora;
            descuento = ped.descuento;
            nombreClienteMostrador = ped.nombreClienteMostrador;
        }

        public void AddPromocion(Promocion promo)
        {
            if (listaPromociones == null)
                listaPromociones = new List<Promocion>();

            listaPromociones.Add(promo);
        }
    }
}
