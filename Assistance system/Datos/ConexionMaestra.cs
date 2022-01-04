using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Assistance_system.Datos
{
   public class ConexionMaestra
    {

        public static string conexion = @"Data source=DESKTOP-D148E36\SQLEXPRESS; Initial Catalog=SistemaAsistencia; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void open()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void close()
        {
            if(conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }

    }
}
