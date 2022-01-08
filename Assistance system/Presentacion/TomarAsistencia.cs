using Assistance_system.Datos;
using Assistance_system.Logica;
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
    public partial class TomarAsistencia : Form
    {
        public TomarAsistencia()
        {
            InitializeComponent();
        }

        string identificacion;
        int IdPersonal;
        int Contador;
        DateTime fechaReg;

        private void TomarAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblhora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalIdent();
            if(identificacion == txtIdentificacion.Text)
            {
                buscarAsistenciasId();
                if(Contador == 0)
                {
                    DialogResult resultado = MessageBox.Show("¿Desea agregar una observación?", "Agregar observación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(resultado == DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point((panelCentral.Location.X), (panelCentral.Location.Y));
                        panelObservacion.Size = new Size(panelCentral.Width, panelCentral.Height);
                        panelObservacion.BringToFront();
                        txtObservacion.Clear();
                        txtObservacion.Focus();
                    }
                    else
                    {
                        insertarAsistencias();
                    }
                }
                else
                {
                    confirmarSalida();
                }
            }
        }

        private void confirmarSalida()
        {
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Hora = Bases.DateDiff(Bases.DateInterval.Hour, fechaReg, DateTime.Now);
            if (funcion.ConfirmarSalida(parametros) == true)
            {
                txtaviso.Text = "SALIDA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }
        }

        private void insertarAsistencias()
        {

            if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                txtObservacion.Text = "--";
            }
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();

            parametros.Id_personal = IdPersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Hora = 0;
            parametros.Observacion = txtObservacion.Text;

            if (funcion.InsertarAsistencias(parametros) == true)
            {
                txtaviso.Text = "ENTRADA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                panelObservacion.Visible = false;
            }

        }
        private void buscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.buscarAsistenciasId(ref dt, IdPersonal);
            Contador = dt.Rows.Count;

            if (Contador > 0)
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
            }
        }
        private void BuscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.buscarPersonalIdentidad(ref dt, txtIdentificacion.Text);
            if(dt.Rows.Count > 0)
            {
                identificacion = dt.Rows[0]["Identificacion"].ToString();
                IdPersonal = Convert.ToInt32( dt.Rows[0]["Id_personal"]);
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            insertarAsistencias();
        }
    }
}
