using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DbFunctions
{
    public class DbScripts: IFunctions
    {      
        public string AlterTable()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["N2S3"].ConnectionString;

            var con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Open)
                con.Close();

            var tProducto = "Producto";
            var tDelivery = "Delivery";
            var tDetallePedido = "DetallePedido";
            var tEstadoPedido = "EstadoPedido";
            var tPedido = "Pedido";

            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.Transaction = tran;

                var cmd = $"ALTER TABLE {tDelivery} ALTER COLUMN preciodelivery decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();
                Console.WriteLine($"Actualizado {tDelivery}");

                cmd = $"ALTER TABLE Producto ALTER COLUMN precioX1 decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();

                cmd = $"ALTER TABLE Producto ALTER COLUMN precioX2 decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();

                cmd = $"ALTER TABLE {tProducto} ALTER COLUMN precioX3 decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();
                Console.WriteLine($"Actualizado {tProducto}");

                cmd = $"ALTER TABLE {tDetallePedido} ALTER COLUMN precioProducto decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();
                Console.WriteLine($"Actualizado {tDetallePedido}");

                cmd = $"ALTER TABLE {tEstadoPedido} ALTER COLUMN nombreEstado varchar(50);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();
                Console.WriteLine($"Actualizado {tEstadoPedido}");

                cmd = $"ALTER TABLE {tPedido} ALTER COLUMN montoTotalPedido decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();

                cmd = $"ALTER TABLE {tPedido} ALTER COLUMN montoAbono decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();

                cmd = $"ALTER TABLE {tPedido} ALTER COLUMN descuento decimal(18,2);";
                com.CommandText = cmd;
                com.ExecuteNonQuery();
                Console.WriteLine($"Actualizado {tPedido}");

                tran.Commit();
                return "EXITO AL ACTUALIZAR LA BASE DE DATOS";
            }
            catch (Exception ex)
            {                
                tran.Rollback();
                return $"HUBO UN ERROR AL ACTUALIZAR LA BASE DE DATOS: {ex.Message}";
            }
        }
    }
}
