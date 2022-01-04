using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assistance_system.Logica
{
    public class Lpersonal
    {

  
        //	[SueldoPorHora] [numeric] (18, 2) NULL,
        //	[Estado]
        //		[varchar]
        //		(max) NULL,
        //	[codigo] [varchar]
        //		(max) NULL,

        public int Id_personal { get; set; }

        public String Nombre { get; set; }

        public String Identificacion { get; set; }

        public String Pais { get; set; }

        public int Id_cargo { get; set; }

        public double SueldoPorHora { get; set; }

        public String Estado { get; set; }

        public String codigo { get; set; }


    }
}
