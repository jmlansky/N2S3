using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosCliente
    {
        public bool insertarCliente(Cliente cli)
        {
            bool respuesta = false;
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
                con.conection.Close();

            con.conection.Open();
            SqlTransaction tran = con.conection.BeginTransaction();
            try
            {
                SqlCommand com = new SqlCommand("insert into Cliente (nombreCliente, domicilioCliente, telefonoCliente) values (@nombreCliente, @domicilioCliente, @telefonoCliente)", con.conection);
                com.Parameters.AddWithValue("@nombreCliente", cli.nombreCliente);
                com.Parameters.AddWithValue("@domicilioCliente", cli.domicilioCliente);
                com.Parameters.AddWithValue("@telefonoCliente", cli.telefonoCliente);
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

        public Cliente getCliente(String telefonoCliente)
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();

            Cliente cli = new Cliente();
            SqlCommand com = new SqlCommand("select cli.* from Cliente cli where cli.telefonoCliente = @telefonoCliente", con.conection);
            com.Parameters.AddWithValue("@telefonoCliente", telefonoCliente);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                cli.nombreCliente = dr["nombreCliente"].ToString();
                cli.domicilioCliente = dr["domicilioCliente"].ToString();
                cli.telefonoCliente = dr["telefonoCliente"].ToString();
            }
            dr.Close();
            con.conection.Close();
            return cli;
        }

        public DataTable getAllClientes()
        {
            DataTable oDt = new DataTable();

            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }
            con.conection.Open();

            SqlDataAdapter oDa = new SqlDataAdapter("select idCliente, nombreCliente, domicilioCliente, telefonoCliente from Cliente order by nombreCliente asc", con.conection);
            oDa.Fill(oDt);

            con.conection.Close();
            return oDt;
        }

        public DataTable getClienteTabla(string pTelCliente)
        {
            DataTable oDt = new DataTable();

            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }
            con.conection.Open();

            SqlDataAdapter oDa = new SqlDataAdapter();
            SqlCommand oCom = new SqlCommand("select idCliente, nombreCliente, domicilioCliente, telefonoCliente from Cliente where telefonoCliente like @tel + '%'", con.conection);
            oCom.Parameters.AddWithValue("@tel", pTelCliente);
            oDa.SelectCommand = oCom;
            oDa.Fill(oDt);

            con.conection.Close();
            return oDt;
        }

        /// <summary>
        /// Devuelve el id del cliente que se le envia el telefono.
        /// Según el código, esto siempre trae un valor ya que se ejecuta cuando el cliente ya existe o se lo grabo previamente antes
        /// de grabar un pedido.
        /// </summary>
        /// <param name="telefonoCliente"></param>
        /// <returns></returns>
        public long getIdCliente(string telefonoCliente)
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
                con.conection.Close();

            con.conection.Open();

            SqlCommand com = new SqlCommand("select cli.idCliente from Cliente cli where cli.telefonoCliente = @telefonoCliente", con.conection);
            com.Parameters.AddWithValue("@telefonoCliente", telefonoCliente);
            var result = com.ExecuteScalar();
            con.conection.Close();

            return result != null && Convert.ToInt64(result) > 0 ? Convert.ToInt64(result) : 0;
        }

        /// <summary>
        /// Metodo que busca un cliente en la Db a traves del ID del mismo, puede devolver null, se debe validar desde donde
        /// se lo llame
        /// </summary>
        /// <param name="pIdCliente">int Id del cliente a buscar</param>
        /// <returns>Cliente encontrado, puede devolver null</returns>
        public Cliente getClienteById(long pIdCliente)
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            // abrir conexion
            con.conection.Open();

            // cliente por defecto en null
            Cliente oCliente = null;

            // setear el comando a ejecutar
            SqlCommand com = new SqlCommand(@"select cli.idCliente,  
                                                cli.nombreCliente, 
                                                cli.domicilioCliente, 
                                                cli.telefonoCliente
                                                from Cliente cli 
                                                where cli.idCliente = @idCliente", con.conection);

            com.Parameters.AddWithValue("@idCliente", pIdCliente);

            // ejecutar el reader
            SqlDataReader oDr = com.ExecuteReader();

            // validar que exista el cliente
            if (oDr.Read())
            {
                // crear el cliente
                oCliente = new Cliente();
                oCliente.idCliente = Convert.ToInt32(oDr["idCliente"].ToString());
                oCliente.nombreCliente = oDr["nombreCliente"].ToString();
                oCliente.domicilioCliente = oDr["domicilioCliente"].ToString();
                oCliente.telefonoCliente = oDr["telefonoCliente"].ToString();

            }

            // cerrar conexion
            con.conection.Close();

            // retornar cliente
            return oCliente;
        }

        public void updateCliente(Cliente pCli)
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open) { con.conection.Close(); }

            con.conection.Open();
            SqlTransaction oTran = con.conection.BeginTransaction();
            try
            {
                SqlCommand oCom = new SqlCommand("update Cliente set nombreCliente = @nombreCliente, domicilioCliente = @domicilioCliente where telefonoCliente = @telefonoCliente", con.conection);
                oCom.Parameters.AddWithValue("@nombreCliente", pCli.nombreCliente);
                oCom.Parameters.AddWithValue("@telefonoCliente", pCli.telefonoCliente);
                oCom.Parameters.AddWithValue("@domicilioCliente", pCli.domicilioCliente);

                oCom.Transaction = oTran;
                oCom.ExecuteNonQuery();

                oTran.Commit();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                oTran.Rollback();
            }

            con.conection.Close();
        }
    }
}
