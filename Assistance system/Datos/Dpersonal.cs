using Assistance_system.Logica;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assistance_system.Datos
{
    class Dpersonal
    {

        public bool InsertarPersonal(Lpersonal parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("InsertarPersonal", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
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

        public bool editarPersonal(Lpersonal parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("editarPersonal", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@Sueldo_por_hora", parametros.SueldoPorHora);
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

        public bool eliminarPersonal(Lpersonal parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("eliminarPersonal", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
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

        public void mostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                ConexionMaestra.open();
                SqlDataAdapter da = new SqlDataAdapter("mostrarPersonal", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.close();
            }
        }

        public void buscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                ConexionMaestra.open();
                SqlDataAdapter da = new SqlDataAdapter("buscarPersonal", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                ConexionMaestra.close();
            }
        }

    }
}
