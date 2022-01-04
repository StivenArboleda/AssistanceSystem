using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assistance_system.Logica;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assistance_system.Datos
{
    public class Dcargos
    {

        public bool Insertar_Cargo(Lcargos parametros)
        {
            try
            {
                ConexionMaestra.open();
                SqlCommand cmd = new SqlCommand("Insertar_Cargo", ConexionMaestra.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
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
		public bool editar_Cargo(Lcargos parametros)
		{
			try
			{
				ConexionMaestra.open();
				SqlCommand cmd = new SqlCommand("editar_Cargo", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@id", parametros.Id_cargo);
				cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
				cmd.Parameters.AddWithValue("@Sueldo", parametros.SueldoPorHora);
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
		public void buscarCargo(ref DataTable dt, string buscador)
		{
			try
			{
				ConexionMaestra.open();
				SqlDataAdapter da = new SqlDataAdapter("buscarCargo", ConexionMaestra.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
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
