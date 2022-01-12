using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Assistance_system.Datos;
using Assistance_system.Logica;

namespace Assistance_system.Datos
{
    public class Dpermisos
    {
        public bool Insertar_Permisos(Lpermisos parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("insertar_Permisos", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModulo", parametros.IdModulo);
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.close();
            }
        }
        public void mostrar_Permisos(ref DataTable dt, Lpermisos parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Permisos", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idusuario", parametros.IdUsuario);

                da.Fill(dt);

                ConexionMaestra.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public bool Eliminar_Permisos(Lpermisos parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("Eliminar_Permisos", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionMaestra.close();
            }
        }
    }
}