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
	public class Dusuarios
	{
		public bool InsertarUsuarios(Lusuarios parametros)
		{
			try
			{
				ConexionMaestra.open();
				SqlCommand cmd = new SqlCommand("insertar_usuario", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@nombres", parametros.Nombre);
				cmd.Parameters.AddWithValue("@Login", parametros.Login);
				cmd.Parameters.AddWithValue("@Password", parametros.Password);
				cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
				cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
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
		public void mostrar_Usuarios(ref DataTable dt)
		{
			try
			{
				ConexionMaestra.open();
				SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios", ConexionMaestra.conectar);
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

		public void ObtenerIdUsuario(ref int Idusuario, string Login)
		{
			try
			{
				ConexionMaestra.open();
				SqlCommand cmd = new SqlCommand("ObtenerIdUsuario", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Login", Login);
				Idusuario = Convert.ToInt32(cmd.ExecuteScalar());
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
