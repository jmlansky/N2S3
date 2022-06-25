using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class DatosProducto
    {
        public DataTable getAllProductos()
        {
            Conexion con = new  Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter ("select prod.* from Producto prod", con.conection);
            da.Fill(dt);
            con.conection.Close();
            return dt;
        }

        public DataTable getAllNombresProductos()
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select prod.idProducto, prod.nombreProducto from Producto prod", con.conection);
            da.Fill(dt);
            con.conection.Close();
            return dt;
        }

        public Producto getProducto(int idProducto)
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();

            Producto prod = new Producto();
            SqlCommand com = new SqlCommand ("select prod.* from Producto prod where prod.idProducto = @idProducto", con.conection);
            com.Parameters.AddWithValue("@idProducto", idProducto);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                prod.idProducto = Convert.ToInt16(dr["idProducto"].ToString());
                prod.nombreProducto = dr["nombreProducto"].ToString();
                prod.observacionProducto = dr["observacionProducto"].ToString();
                prod.precioX1 = Convert.ToDecimal(dr["idProducto"].ToString());
                prod.precioX2 = Convert.ToDecimal(dr["idProducto"].ToString());
                prod.precioX3 = Convert.ToDecimal(dr["idProducto"].ToString());
            }
            dr.Close();
            con.conection.Close();
            return prod;
        }

        public bool insertarProducto(Producto prod)
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
                SqlCommand com = new SqlCommand("insert into Producto (nombreProducto, observacionProducto, precioX1, precioX2, precioX3) values (@nombreProducto, @observacionProducto, @precioX1, @precioX2, @precioX3)", con.conection);
                com.Parameters.AddWithValue("@nombreProducto", prod.nombreProducto);
                com.Parameters.AddWithValue("@observacionProducto", prod.observacionProducto);
                com.Parameters.AddWithValue("@precioX1", prod.precioX1);
                com.Parameters.AddWithValue("@precioX2", prod.precioX2);
                com.Parameters.AddWithValue("@precioX3", prod.precioX3);
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

        public bool borrarProducto(int idProducto)
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
                SqlCommand com = new SqlCommand("Delete Producto where idProducto = @idProducto", con.conection);
                com.Parameters.AddWithValue("@idProducto", idProducto);
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

        public bool actualizarProducto(Producto prod)
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
                SqlCommand com = new SqlCommand("Update Producto set nombreProducto = @nombreProducto, observacionProducto = @observacionProducto, precioX1 = @precioX1, precioX2 = @precioX2, precioX3 = @precioX3 where idProducto = @idProducto", con.conection);
                com.Parameters.AddWithValue("@nombreProducto", prod.nombreProducto);
                com.Parameters.AddWithValue("@observacionProducto", prod.observacionProducto);
                com.Parameters.AddWithValue("@precioX1", prod.precioX1);
                com.Parameters.AddWithValue("@precioX2", prod.precioX2);
                com.Parameters.AddWithValue("@precioX3", prod.precioX3);
                com.Parameters.AddWithValue("@idProducto", prod.idProducto);
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
