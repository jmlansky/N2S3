using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Pedido
    {
        public int idCliente { set; get; }
        public int idPedido { set; get; }
        public decimal montoTotalPedido { set; get; }
        public String fechaPedido { set; get; }
        public String horaPedido { set; get; }
        public String observacionPedido { set; get; }
        public String domicilioEntregaPedido { set; get; }
        public List<Promocion> listaPromociones { set; get; }
        public Decimal montoAbono { set; get; }
        public int tiempoDemora { set; get; }
        public int descuento { set; get; }
        public String nombreClienteMostrador { get; set; }

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
            this.idCliente = ped.idCliente; ;
            this.idPedido = ped.idPedido;
            this.montoTotalPedido = ped.montoTotalPedido;
            this.fechaPedido = ped.fechaPedido;
            this.horaPedido = ped.horaPedido;
            this.observacionPedido = ped.observacionPedido;
            this.domicilioEntregaPedido = ped.domicilioEntregaPedido;
            this.listaPromociones = ped.listaPromociones;
            this.montoAbono = ped.montoAbono;
            this.tiempoDemora = ped.tiempoDemora;
            this.descuento = ped.descuento;
            this.nombreClienteMostrador = ped.nombreClienteMostrador;
        }

        public void addPromocion(Promocion promo)
        {
            if (listaPromociones == null)
            {
                listaPromociones = new List<Promocion>();
            }
            else
                listaPromociones.Add(promo);
        }
    }
}
