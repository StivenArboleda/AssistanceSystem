using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Assistance_system.Logica;
using Assistance_system.Datos;

namespace Assistance_system.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = false;
            PanelPaginado.Visible = false;
            PanelRegistros.Visible = true;
            PanelRegistros.Dock = DockStyle.Fill;
            btnGuardarCambiosPersonal.Visible = false;
            clear();
        }

        private void clear()
        {
            TxtNombres.Clear();
            txtId.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();
            BuscarCargos();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {

        }

        private void Insertar_personal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombre = TxtNombres.Text;
            parametros.Identificacion = txtId.Text;
            parametros.Pais = comboBoxPais.Text;
            //parametros.
        }

        private void insertarCargos()
        {
            if (!string.IsNullOrEmpty(txtCargosCa.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoHoraCa.Text))
                {
                    Lcargos parametros = new Lcargos();
                    Dcargos funcion = new Dcargos();
                    parametros.Cargo = txtCargosCa.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHoraCa.Text);
                    if (funcion.Insertar_Cargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        BuscarCargos();
                        PanelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agregue el sueldo", "Falta el sueldo por hora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agregue el cargo", "Falta el cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.buscarCargo(ref dt, txtCargo.Text);
            dataListadoCargos.DataSource = dt;

            Bases.DiseñoDataGrid(ref dataListadoCargos);

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
            btnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtCargosCa.Clear();
            txtSueldoHoraCa.Clear();

        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            insertarCargos();
        }

        private void txtSueldoHoraCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoHoraCa, e);
        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoHora, e);
        }
    }
}
