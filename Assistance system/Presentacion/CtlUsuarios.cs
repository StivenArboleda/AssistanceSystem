using Assistance_system.Datos;
using Assistance_system.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        int idUsuario;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelIconos.Visible = true;
            panelIconos.Dock = DockStyle.Fill;
            panelIconos.BringToFront();
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
            dataListadoModulos.DataSource = dt;
            Bases.DiseñoDataGrid(ref dataListadoModulos);
            dataListadoModulos.Columns[1].Visible = false;
        }
  
        private void dataListadoModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)

        {
            if (!string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContrasenia.Text))
                    {
                        if(lblAnuncioIcono.Visible == false)
                        {
                            insertUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Elija o cargue un icono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el usuario");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre");
            }
        }

        private void insertUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = txtNombreUsuario.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContrasenia.Text;
            MemoryStream ms = new MemoryStream();
            icono.Image.Save(ms, icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.InsertarUsuarios(parametros))
            {
                obtenerIdUsuario();
                InsertarPermisos();
            }
        }
        private void obtenerIdUsuario()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref idUsuario, txtUsuario.Text);
        }

        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in dataListadoModulos.Rows)
            {
                int idModulos = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    Lpermisos parametros = new Lpermisos();
                    Dpermisos funcion = new Dpermisos();
                    parametros.IdModulo = idModulos;
                    parametros.IdUsuario = idUsuario;
                    funcion.Insertar_Permisos(parametros);

                }
            }
            MostrarUsuarios();
            panelRegistros.Visible = false;
        }
        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuarios funcion = new Dusuarios();
            funcion.mostrar_Usuarios(ref dt);
            dataListadoPersonal.DataSource = dt;
            DiseñarDtvUsuarios();
        }
        private void DiseñarDtvUsuarios()
        {
            Bases.DiseñoDataGrid(ref dataListadoPersonal);
            Bases.diseñoDataGridEliminar(ref dataListadoPersonal);
            dataListadoPersonal.Columns[2].Visible = false;
            dataListadoPersonal.Columns[5].Visible = false;
            dataListadoPersonal.Columns[6].Visible = false;
            dataListadoPersonal.Columns[3].HeaderText = "Nombre Apellido";
            dataListadoPersonal.Columns[4].HeaderText = "Usuario";

            //CENTRAR COLUMNAS
            dataListadoPersonal.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // PROCESO DE ICONOS

        private void ocultarPanelIcono()
        {
            panelIconos.Visible = false;
            lblAnuncioIcono.Visible = false;
            icono.Visible = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox3.Image;
            ocultarPanelIcono();
        }
   

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox4.Image;
            ocultarPanelIcono();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox5.Image;
            ocultarPanelIcono();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox6.Image;
            ocultarPanelIcono();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox7.Image;
            ocultarPanelIcono();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox8.Image;
            ocultarPanelIcono();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox9.Image;
            ocultarPanelIcono();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox10.Image;
            ocultarPanelIcono();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox12.Image;
            ocultarPanelIcono();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            icono.Image = pictureBox11.Image;
            ocultarPanelIcono();
        }
        //AGREGAR ICONO PC
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargar imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                icono.BackgroundImage = null;
                icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIcono();
            }
        }


        private void icono_Click(object sender, EventArgs e)
        {
            panelIconos.Visible = true;
            panelIconos.Dock = DockStyle.Fill;
            panelIconos.BringToFront();
        }

        private void CtlUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultarPanelIcono();
        }
    }
}
