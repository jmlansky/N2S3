using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosPedido
    {
        public string insertarPedido(Pedido ped, List<DetallePromocion> dp)
        {
            string respuesta = "";
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            SqlTransaction tran = con.conection.BeginTransaction();
            try
            {
                //Crear el Pedido
                SqlCommand com = new SqlCommand("insert into Pedido (idCliente, montoTotalPedido, fechaPedido, horaPedido, observacionPedido, domicilioEntregaPedido, montoAbono, tiempoDemora, descuento, nombreClienteMostrador)" +
                    " values (@idCliente, @montoTotalPedido, @fechaPedido, @horaPedido, @observacionPedido, @domicilioEntregaPedido, @montoAbono, @tiempoDemora, @descuento, @nombreClienteMostrador)", con.conection);
                com.Parameters.AddWithValue("@idCliente", ped.idCliente);
                com.Parameters.AddWithValue("@montoTotalPedido", ped.montoTotalPedido);
                com.Parameters.AddWithValue("@fechaPedido", Convert.ToDateTime(ped.fechaPedido));
                com.Parameters.AddWithValue("@horaPedido", ped.horaPedido);
                com.Parameters.AddWithValue("@observacionPedido", ped.observacionPedido);
                com.Parameters.AddWithValue("@domicilioEntregaPedido", ped.domicilioEntregaPedido);
                com.Parameters.AddWithValue("@montoAbono", ped.montoAbono);
                com.Parameters.AddWithValue("@tiempoDemora", ped.tiempoDemora);
                com.Parameters.AddWithValue("@descuento", ped.descuento);
                com.Parameters.AddWithValue("@nombreClienteMostrador", ped.nombreClienteMostrador);

                com.Transaction = tran;
                com.ExecuteNonQuery();

                SqlCommand com1 = new SqlCommand("Select ped.idPedido from Pedido ped where ped.idPedido = @@identity", con.conection);
                com1.Transaction = tran;
                long idPedido = Convert.ToInt64(com1.ExecuteScalar().ToString());
                                
                // insertar detalle de pedido
                foreach (DetallePromocion detP in dp)
                {
                    detP.idPedido = idPedido;
                    SqlCommand com_dp = new SqlCommand("insert into DetallePedido (idDetallePedido, idPedido, idProducto, nombreProducto, cantidadProductoDetallePedido, precioProducto, observacionDetallePedido) values (@idDetallePedido, @idPedido, @idProducto, @nombreProducto, @cantidadProductoDetallePedido, @precioProducto, @observacionDetallePedido)", con.conection);
                    com_dp.Parameters.AddWithValue("@idPedido", detP.idPedido);
                    com_dp.Parameters.AddWithValue("@idProducto", detP.idProducto);
                    com_dp.Parameters.AddWithValue("@cantidadProductoDetallePedido", detP.cantidadProducto);
                    com_dp.Parameters.AddWithValue("@observacionDetallePedido", detP.observacionProducto);
                    com_dp.Parameters.AddWithValue("@idDetallePedido", detP.idDetallePromocion);
                    com_dp.Parameters.AddWithValue("@nombreProducto", detP.nombreProducto);
                    com_dp.Parameters.AddWithValue("@precioProducto", detP.precioElegido);
                    com_dp.Transaction = tran;
                    com_dp.ExecuteNonQuery();
                }

                tran.Commit();
                respuesta = "ok";
            }
            catch (Exception ex)
            {
                respuesta += ex.Message.ToString();
                tran.Rollback();
            }

            con.conection.Close();
            return respuesta;
        }

        /// <summary>
        /// Metodo sobrecargado que obtiene todos los pedidos realizados en un intervalo de tiempo
        /// </summary>
        /// <param name="fechaDesde">Fecha desde </param>
        /// <param name="fechaHasta">Fecha hasta</param>
        /// <param name="order">OrderEnum Orden en que se desea recuperar los datos</param>
        /// <returns>DataTable</returns>
        public DataTable getAllPedidos(DateTime fechaDesde, DateTime fechaHasta,OrderEnum order)
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand com = new SqlCommand("Select ped.idPedido, ped.fechaPedido, ped.horaPedido, ped.domicilioEntregaPedido, ped.montoTotalPedido, ped.nombreClienteMostrador from pedido ped where fechaPedido between @fechaDesde and @fechaHasta order by ped.horaPedido " + order, con.conection);
                com.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                com.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            con.conection.Close();
            return dt;
        }

        /// <summary>
        /// Se utiliza la sobrecarga del metodo para indicarle el orden en que se desean buscar los datos
        /// </summary>
        /// <param name="fechaDesde">Fecha desde </param>
        /// <param name="fechaHasta">Fecha hasta</param>
        /// <returns>DataTable</returns>
        public DataTable getAllPedidos(DateTime fechaDesde, DateTime fechaHasta)
        {
            // retornar los datos encontrados en la DB
            return getAllPedidos(fechaDesde, fechaHasta, OrderEnum.ASC);
        }

        /// <summary>
        /// Metodo que busca un pedido segun el Id pasado por parametro, puede devolver null en caso de que el id
        /// no se encuentre en la DB
        /// </summary>
        /// <param name="pIdPedido">ID pedido a buscar</param>
        /// <returns>Pedido encontrado, puede devolver null</returns>
        public Pedido getOnePedidoById(long pIdPedido)
        {

            Pedido oPedido = null;

            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            // abrir la conexion con la DB
            con.conection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand com = new SqlCommand(@"Select ped.idPedido, 
                                                         ped.fechaPedido,  
                                                         ped.horaPedido,  
                                                         ped.domicilioEntregaPedido,  
                                                         ped.montoTotalPedido,
                                                         ped.montoAbono,
                                                         ped.descuento,
                                                         ped.idCliente,
                                                         ped.tiempoDemora,
                                                         ped.observacionPedido,
                                                         ped.nombreClienteMostrador
                                                         from pedido ped where ped.idPedido=@idPedido", con.conection);

                com.Parameters.AddWithValue("@idPedido", pIdPedido);

                SqlDataReader oDr = com.ExecuteReader();

                // validar que se haya encontrado el pedido solicitado
                if (oDr.Read())
                {
                    oPedido = new Pedido();
                    oPedido.idPedido = Convert.ToInt32(oDr["idPedido"].ToString());
                    oPedido.idCliente = Convert.ToInt32(oDr["idCliente"].ToString());
                    oPedido.fechaPedido = oDr["fechaPedido"].ToString();
                    oPedido.horaPedido = oDr["horaPedido"].ToString();
                    oPedido.domicilioEntregaPedido = oDr["domicilioEntregaPedido"].ToString();
                    oPedido.montoTotalPedido = Convert.ToDecimal(oDr["montoTotalPedido"].ToString());
                    oPedido.montoAbono = Convert.ToDecimal(oDr["montoAbono"].ToString());
                    oPedido.descuento = Convert.ToInt32(oDr["descuento"].ToString());
                    oPedido.observacionPedido = oDr["observacionPedido"].ToString();
                    oPedido.tiempoDemora = Convert.ToInt32(oDr["tiempoDemora"].ToString());
                    oPedido.nombreClienteMostrador = oDr["nombreClienteMostrador"].ToString();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            con.conection.Close();

            // retornar el pedido encontrado
            return oPedido;
        }

        public DataTable getAllDetallesPedido(long idPedido)
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand com = new SqlCommand("select dp.nombreProducto, dp.cantidadProductoDetallePedido, dp.precioProducto, dp.observacionDetallePedido from detallePedido dp where dp.idPedido = @idPedido", con.conection);
                com.Parameters.AddWithValue("@idPedido", idPedido);
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            con.conection.Close();
            return dt;
        }

        /// <summary>
        /// Obtiene todos los datos del detalle de pedido, segun el Id de pedido que se pase por parametro
        /// </summary>
        /// <param name="idPedido">ID de pedido </param>
        /// <returns>DataTable</returns>
        public DataTable getAllDetallesPedidoFull(long idPedido)
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand com = new SqlCommand(@"select 
                                                    dp.idDetallePedido,
                                                    dp.idPedido,
                                                    dp.idProducto,
                                                    dp.nombreProducto, 
                                                    dp.cantidadProductoDetallePedido, 
                                                    dp.precioProducto, 
                                                    dp.observacionDetallePedido 
                                                    from detallePedido dp 
                                                    where dp.idPedido = @idPedido", con.conection);

                com.Parameters.AddWithValue("@idPedido", idPedido);
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            con.conection.Close();
            return dt;
        }

        public bool insertarPrecioDelivery(Decimal precio)
        {
            bool respuesta = false;
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            SqlTransaction tran = con.conection.BeginTransaction();
            try
            {
                SqlCommand com = new SqlCommand("insert into Delivery (precioDelivery) values (@precioDelivery)", con.conection);
                com.Parameters.AddWithValue("@precioDelivery", precio);
                com.Transaction = tran;
                com.ExecuteNonQuery();
                tran.Commit();
                respuesta = true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                tran.Rollback();
            }

            con.conection.Close();
            return respuesta;
        }

        public bool actualizarPrecioDelivery(Decimal precio)
        {
            bool respuesta = false;
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            SqlTransaction tran = con.conection.BeginTransaction();
            try
            {
                SqlCommand com = new SqlCommand("Update Delivery set precioDelivery = @precioDelivery", con.conection);
                com.Parameters.AddWithValue("@precioDelivery", precio);
                com.Transaction = tran;
                com.ExecuteNonQuery();
                tran.Commit();
                respuesta = true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                tran.Rollback();
            }

            con.conection.Close();
            return respuesta;
        }

        public Decimal getPrecioDelivery()
        {
            Decimal precio = -1;
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            SqlCommand com = new SqlCommand("Select precioDelivery from Delivery", con.conection);
            try
            {
                precio = Convert.ToDecimal(com.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            con.conection.Close();
            return precio;
        }

        /// <summary>
        /// Elimina el pedido pasado por parametro
        /// </summary>
        /// <param name="idPedido"> ID del pedido a eliminar</param>
        /// <param name="eliminarDetalles">Flag que indica si se debe eliminar los detalles de pedidos tambien</param>
        /// <returns> Flag que indica si se pudo realizar la operacion solicitada</returns>
        public bool eliminarPedido(long idPedido,bool eliminarDetalles)
        {
            bool respuesta = false;

            // validar si se deben eliminar los detalles del pedido en cuestion tambien
            if (eliminarDetalles)
            {
                /// eliminar los detalles primero
                /// validar que se hayan podido eliminar, si no se pudo eliminar, retornar false
                if (!this.eliminarDetallesDePedidoPorIPedido(idPedido))
                    return false;
            }

            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            SqlTransaction tran = con.conection.BeginTransaction();
            try
            {
                //Eliminar el Pedido, los detalles de pedido se eliminan en cascada, definidos en BD
                SqlCommand com = new SqlCommand("Delete Pedido where idPedido = @idPedido", con.conection);
                com.Parameters.AddWithValue("@idPedido", idPedido);
                com.Transaction = tran;
                com.ExecuteNonQuery();
                tran.Commit();
                respuesta = true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                tran.Rollback();
            }

            con.conection.Close();
            return respuesta;
        }

        /// <summary>
        /// Elimina todos los detalles de pedidos de un pedido determinado
        /// </summary>
        /// <param name="idPedido"> Id del pedido al que pertenecen los detalles</param>
        /// <returns>Flag que indica si se pudo realizar la eliminacion</returns>
        public bool eliminarDetallesDePedidoPorIPedido(long idPedido)
        {
            bool respuesta = false;
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            SqlTransaction tran = con.conection.BeginTransaction();
            try
            {
                //Eliminar el Pedido, los detalles de pedido se eliminan en cascada, definidos en BD
                SqlCommand com = new SqlCommand("Delete DetallePedido where idPedido = @idPedido", con.conection);
                com.Parameters.AddWithValue("@idPedido", idPedido);
                com.Transaction = tran;
                com.ExecuteNonQuery();
                tran.Commit();
                respuesta = true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                tran.Rollback();
            }

            con.conection.Close();
            return respuesta;
        }

        public DataTable getAllCantidadesVendidas(DateTime fechaDesde, DateTime fechaHasta)
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand com = new SqlCommand("select dp.nombreProducto, SUM(dp.cantidadProductoDetallePedido) as 'CantidadProducto'from pedido ped, detallePedido dp where ped.idPedido = dp.idPedido and fechaPedido between @fechaDesde and @fechaHasta group by dp.nombreProducto", con.conection);
                com.Parameters.AddWithValue("@fechaDesde", fechaDesde.ToShortDateString());
                com.Parameters.AddWithValue("@fechaHasta", fechaHasta.ToShortDateString());
                da.SelectCommand = com;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            con.conection.Close();
            return dt;
        }

        /* TODO
         * 1- listar pedidos del dia: traer idPedido, telefono del cliente
         * 2- 
         */
        public String getEstadoAllPedidos()
        {
            return "";
        }

        public bool actualizarEstadoPedido(long idPedido)
        {
            return false;
        }
    }
}
