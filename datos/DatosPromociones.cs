using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosPromociones
    {
        public bool insertarPromocion(string nombrePromocion)
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
                SqlCommand com = new SqlCommand("ALTER table Producto add @promocion varchar(10)", con.conection);
                com.Parameters.AddWithValue("@promocion", nombrePromocion);
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

        public bool borrarPromocion(string nombrePromocion)
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
                SqlCommand com = new SqlCommand("ALTER table Producto remove @promocion", con.conection);
                com.Parameters.AddWithValue("@promocion", nombrePromocion);
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
    }
}
