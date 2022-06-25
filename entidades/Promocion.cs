using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Promocion
    {
        public int idPromocion { set; get;}
        public List<DetallePromocion> listaDetallePromo { set; get; }


        public Promocion()
        {
            idPromocion = 0;
            listaDetallePromo = new List<DetallePromocion>();
        }

        public Promocion(int idPromocion, List<DetallePromocion> lista)
        {
            this.idPromocion = idPromocion;
            listaDetallePromo = lista;
        }
    }
}
