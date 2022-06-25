using System.Collections.Generic;
using Entidades;

namespace NoHay2Sin3.Clases
{
    public static class clsPromocion
    {
        public static int idPromocion = 0;
        public static List<DetallePromocion> listaDetallePromo = new List<DetallePromocion>();
        public static List<Promocion> listaPromo = new List<Promocion>();

        public static void addPromocion()
        {
            idPromocion++;
        }

        public static void removePromocion()
        {
            idPromocion--;
        }
    }
}
