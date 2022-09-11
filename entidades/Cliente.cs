using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        public long idCliente { set; get; }
        public String nombreCliente { set; get; }
        public String domicilioCliente { set; get; }
        public String telefonoCliente { set; get; }
        public Int64 dniCliente { set; get; }
        public string nroTarjetaTerritorioCliente { set; get; }

        public Cliente()
        {
            idCliente = 0;
            nombreCliente = "";
            domicilioCliente = "";
            telefonoCliente = "";
            dniCliente = 0;
            nroTarjetaTerritorioCliente = "";
        }

        public Cliente(int idCliente, String nombreCliente, String domicilioCliente, String telefonoCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.domicilioCliente = domicilioCliente;
            this.telefonoCliente = telefonoCliente;
            //this.dniCliente = pDni;
            //this.nroTarjetaTerritorioCliente = pNroTarjeta;
        }
    }
}
