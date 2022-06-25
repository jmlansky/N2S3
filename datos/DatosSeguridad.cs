using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Entidades;

namespace Datos
{
    public class DatosSeguridad
    {
        /// <summary>
        /// Devuelve true si existe una contraseña guardada y es igual a la que determina el programador.
        /// </summary>
        /// <returns></returns>
        public Seguridad confirmarConstraseña()
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();

            Seguridad oSeg = new Seguridad();
            oSeg.estado = false;

            String password = "";
            String fchValidoHasta = "";
            DateTime oVto = DateTime.Today;

            SqlCommand com = new SqlCommand("Select sec.psw, fchValidoHasta from Security sec", con.conection);
            try
            {
                SqlDataReader oDr = com.ExecuteReader();
                if (oDr.Read())
                {
                    password = oDr["psw"].ToString();
                    fchValidoHasta = oDr["fchValidoHasta"].ToString();
                    oVto = Convert.ToDateTime(fchValidoHasta);
                    oSeg.fchVto = oVto.ToShortDateString();
                }
            }
            catch (Exception)
            {}
            
            if (password == "2J7A0V5I8E5R" && (oVto >= DateTime.Today))
                //el password es correcto y la fecha de vencimiento esta ok
                oSeg.estado = true;

            con.conection.Close();
            return oSeg;
        }

        /// <summary>
        /// Devuelve true si existe alguna contraseña guardada.
        /// </summary>
        /// <returns></returns>
        public Boolean confirmarExistenciaConstraseña()
        {
            Conexion con = new Conexion();
            if (con.conection.State == ConnectionState.Open)
            {
                con.conection.Close();
            }

            con.conection.Open();

            Boolean respuesta = false;
            SqlCommand com = new SqlCommand("Select sec.psw from Security sec", con.conection);
            try
            {
                com.ExecuteScalar().ToString();
                //existe una contraseña
                respuesta = true;
            }
            catch (Exception)
            { }

            con.conection.Close();
            return respuesta;
        }

        /// <summary>
        /// Insertar password en la BD
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool insertarPassword(Seguridad pSeg)
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
                SqlCommand com = new SqlCommand("insert into Security (psw, idPassword, fchRegistro, fchValidoDesde, fchValidoHasta ) values (@psw, 1, @fchRegistro, @fchValidoDesde, @fchValidoHasta)", con.conection);
                com.Parameters.AddWithValue("@psw", pSeg.psw);
                com.Parameters.AddWithValue("@fchRegistro", pSeg.fRegistro);
                com.Parameters.AddWithValue("@fchValidoDesde", pSeg.fDesde);
                com.Parameters.AddWithValue("@fchValidoHasta", pSeg.fchVto);
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
        /// Si existe una contraseña, es necesario actualizarla
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool actualizarPassword(Seguridad pSeg)
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
                SqlCommand com = new SqlCommand("Update Security set psw = @psw, fchRegistro = @fchRegistro, fchValidoDesde = @fchValidoDesde, fchValidoHasta = @fchValidoHasta where idPassword = 1", con.conection);
                com.Parameters.AddWithValue("@psw", pSeg.psw);
                com.Parameters.AddWithValue("@fchRegistro", pSeg.fRegistro);
                com.Parameters.AddWithValue("@fchValidoDesde", pSeg.fDesde);
                com.Parameters.AddWithValue("@fchValidoHasta", pSeg.fchVto);
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
