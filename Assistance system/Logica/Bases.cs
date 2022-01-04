using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assistance_system.Logica
{
    public class Bases
    {

        public static void DiseñoDataGrid(ref DataGridView listado)
        {
            listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listado.BackgroundColor = Color.Red;

        }
        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            if((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]; //cambia las comas por puntos

            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(e.KeyChar=='.' && (~CajaTexto.Text.IndexOf(".")) != 0) //solo permite un punto
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; //bloquea cualquier tecla diferentes
            }
            return null;
        }
    }
}
