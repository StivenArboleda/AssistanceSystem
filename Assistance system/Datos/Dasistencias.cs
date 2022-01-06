using Assistance_system.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assistance_system.Datos
{
    public class Dasistencias
    {

        public void buscarAsistenciasId(ref DataTable dt, int idPersonal)
        {
            try
            {
                ConexionMaestra.open();
                SqlDataAdapter da = new SqlDataAdapter("buscarAsistenciaId", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Idpersonal", idPersonal);
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

        public bool InsertarAsistencias(Lasistencias parametros)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Insertar_ASISTENCIAS", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Fecha_entrada", parametros.Fecha_entrada);
                cmd.Parameters.AddWithValue("@Fecha_salida", parametros.Fecha_salida);
                cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@Hora", parametros.Hora);
                cmd.Parameters.AddWithValue("@Observacion", parametros.Observacion);

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                ConexionMaestra.close();
            }
        }

        public bool ConfirmarSalida(Lasistencias parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("ConfirmarSalida", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Fecha_salida", parametros.Fecha_salida);
                cmd.Parameters.AddWithValue("@Hora", parametros.Hora);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                ConexionMaestra.close();
            }
        }

    }
}
