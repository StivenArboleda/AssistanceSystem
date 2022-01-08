using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assistance_system.Datos
{
    public class Dmodulo
    {
		public void mostrar_Modulos(ref DataTable dt)
		{
			try
			{
				ConexionMaestra.open();
				SqlDataAdapter da = new SqlDataAdapter("Select * from Modulos", ConexionMaestra.conectar);
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
