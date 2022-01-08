using Assistance_system.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assistance_system.Presentacion
{
    public partial class CtlUsuarios : UserControl
    {
        public CtlUsuarios()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            clearControl();
            habilitarPanles();
            MostrarModulos();
        }

        private void clearControl()
        {
            txtNombreUsuario.Clear();
            txtContrasenia.Clear();
            txtUsuario.Clear();
        }
        private void habilitarPanles()
        {
            panelRegistros.Visible = true;
            lblAnuncioIcono.Visible = true;
            panelIconos.Visible = false;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.BringToFront();
            btnGuardarUsuario.Visible = true;
            btnActualizarUsuario.Visible = false;
        }

        private void MostrarModulos()
        {

            Dmodulo funcion = new Dmodulo();
            DataTable dt = new DataTable();
            funcion.mostrar_Modulos(ref dt);
            dataListadoModulosBack.DataSource = dt;
        }
    }
}
