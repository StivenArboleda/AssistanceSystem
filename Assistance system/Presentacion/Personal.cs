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

        int idcargo = 0;
        //variables para el paginador
        int desde = 1;
        int hasta = 10;
        int contador;
        private int itemsPagina = 10;
        int totalPaginas;
        string Estado;
        int IdPersonal;

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
            LocalizarDG();
            clear();
        }

        private void LocalizarDG()
        {
            dataListadoCargos.Location = new Point(txtCargo.Location.X, txtCargo.Location.Y + 40);
            dataListadoCargos.Size = new Size(391, 150);
            dataListadoCargos.Visible = true;
            lblSueldo.Visible = false;
            PanelBtnGuardarPersonal.Visible = false;
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
            if (!string.IsNullOrEmpty(TxtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    if (!string.IsNullOrEmpty(comboBoxPais.Text))
                    {
                        if (idcargo>0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                            {
                                Insertar_personal();
                            }
                        }
                    }
                }
            }
        }

        private void Insertar_personal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombre = TxtNombres.Text;
            parametros.Identificacion = txtId.Text;
            parametros.Pais = comboBoxPais.Text;
            parametros.Id_cargo = idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);
            if (funcion.InsertarPersonal(parametros) == true)
            {
                ReiniciarPaginado();
                MostrarPersonal();
                PanelRegistros.Visible = false;
            }
        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.mostrarPersonal(ref dt, desde, hasta);
            dataListadoPersonal.DataSource = dt;
            diseñarDataGVPersonal();
        }
        private void diseñarDataGVPersonal()
        {
            Bases.DiseñoDataGrid(ref dataListadoPersonal);
            Bases.diseñoDataGridEliminar(ref dataListadoPersonal);
            PanelPaginado.Visible = true;
            dataListadoPersonal.Columns[2].Visible = false;
            dataListadoPersonal.Columns[7].Visible = false;

            dataListadoPersonal.Font = new Font("Microsoft Sans Serif", 24);

            //TITULOS DE ENCABEZADO
            dataListadoPersonal.Columns[3].HeaderText = "Nombre y Apellido";
            dataListadoPersonal.Columns[4].HeaderText = "Identificación";
            dataListadoPersonal.Columns[5].HeaderText = "Sueldo hora";
            dataListadoPersonal.Columns[6].HeaderText = "Cargo";
            dataListadoPersonal.Columns[8].HeaderText = "Estado";
            dataListadoPersonal.Columns[9].HeaderText = "Código";
            dataListadoPersonal.Columns[10].HeaderText = "País";

            //CENTRAR COLUMNAS
            dataListadoPersonal.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataListadoPersonal.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            dataListadoCargos.Columns[1].Visible = false;
            dataListadoCargos.Columns[3].Visible = false;
            dataListadoCargos.Visible = true;
            lblSueldo.Visible = false;

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

        private void dataListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataListadoCargos.Columns["EditarC"].Index)
            {
                DatosEditar();
            }
            if(e.ColumnIndex == dataListadoCargos.Columns["Cargo"].Index)
            {
                DatosCargos();
            }
        }

        private void DatosCargos()
        {
            idcargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargo.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoHora.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            dataListadoCargos.Visible = false;
            PanelBtnGuardarPersonal.Visible = true;
            lblSueldo.Visible = true;
        }

        private void DatosEditar()
        {
            idcargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value); //Empieza en 1 por la columna por defecto que se agregó
            txtCargosCa.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoHoraCa.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarC.Visible = false;
            btnGuardarCambiosC.Visible = true;
            txtCargo.Focus();
            txtCargo.SelectAll();
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
        }

        private void btnVolverCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = false;
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            PanelRegistros.Visible = false;
            PanelPaginado.Visible = true;
        }

        private void btnGuardarCambiosC_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }
        private void EditarCargos()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Id_cargo = idcargo;
            parametros.Cargo = txtCargosCa.Text;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHoraCa.Text);
            if (funcion.editar_Cargo(parametros) == true)
            {
                txtCargo.Clear();
                BuscarCargos();
                PanelCargos.Visible = false;

            }
        }


        private void Personal_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
 
        }
        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            contar();
            if(contador > hasta)
            {
                btnSiguientePag.Enabled = true;
                btnAnteriorPag.Enabled = false;
                btnUltimaPag.Enabled = true;
                btnPrimeraPag.Enabled = true;
            }
            else
            {
                btnSiguientePag.Enabled = false;
                btnAnteriorPag.Enabled = false;
                btnUltimaPag.Enabled = false;
                btnPrimeraPag.Enabled = false;
            }
            paginado();
        }


        private void dataListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataListadoPersonal.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("El estado se cambiará para que sea inaccesible. ¿Desea continuar?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    eliminarPersonal();
                }
            }
            if(e.ColumnIndex == dataListadoPersonal.Columns["Editar"].Index) {
                obtenerDatos();
            }
        }
        private void eliminarPersonal()
        {
            IdPersonal = Convert.ToInt32( dataListadoPersonal.SelectedCells[2].Value);
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = IdPersonal;

            if(funcion.eliminarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }
        private void obtenerDatos()
        {
            IdPersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            Estado = dataListadoPersonal.SelectedCells[8].Value.ToString();
            if(Estado == "ELIMINADO")
            {
                restaurar_personal();
            }
            else
            {
                LocalizarDG();
                TxtNombres.Text = dataListadoPersonal.SelectedCells[3].Value.ToString();
                txtId.Text = dataListadoPersonal.SelectedCells[4].Value.ToString();
                comboBoxPais.Text = dataListadoPersonal.SelectedCells[10].Value.ToString();
                txtCargo.Text = dataListadoPersonal.SelectedCells[6].Value.ToString();
                idcargo = Convert.ToInt32(dataListadoPersonal.SelectedCells[7].Value);
                txtSueldoHora.Text = dataListadoPersonal.SelectedCells[5].Value.ToString();

                PanelPaginado.Visible = false;
                PanelRegistros.Visible = true;
                PanelRegistros.Dock = DockStyle.Fill;
                dataListadoCargos.Visible = false;
                lblSueldo.Visible = true;
                PanelBtnGuardarPersonal.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                PanelCargos.Visible = false;
            }
        }
        private void restaurar_personal()
        {
            DialogResult result = MessageBox.Show("Este personal está eliminado. ¿Desea restaurarlo?", "Restaurar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                habilitarPersonal();
            }
            
        }
        private void habilitarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = IdPersonal;
            if (funcion.restaurarPersonal(parametros) == true)
            {
                MostrarPersonal();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            diseñarDataGVPersonal();
            timer1.Stop();
        }


        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }
        private void EditarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();

            parametros.Id_personal = IdPersonal;
            parametros.Nombre = TxtNombres.Text;
            parametros.Identificacion = txtId.Text;
            parametros.Pais = comboBoxPais.Text;
            parametros.Id_cargo = idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);
            if (funcion.editarPersonal(parametros) == true)
            {
                MostrarPersonal();
                PanelRegistros.Visible = false;
            }

        }


        private void btnSiguientePag_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            contar();
            if(contador > hasta)
            {
                btnSiguientePag.Enabled = true;
                btnAnteriorPag.Enabled = false;
            }
            else
            {
                btnSiguientePag.Enabled = false;
                btnAnteriorPag.Enabled = true;
            }
            paginado();
        }
        private void contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.contarPersonal(ref contador);
        }

        private void paginado()
        {
            try
            {
                lblPag.Text = (hasta / itemsPagina).ToString();
                lblTotalPag.Text = Math.Ceiling(Convert.ToSingle(contador) / itemsPagina).ToString();
                totalPaginas = Convert.ToInt32(lblTotalPag.Text);
            }
            catch (Exception)
            {
            }
        }

        private void btnAnteriorPag_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            MostrarPersonal();
            contar();
            if(contador > hasta)
            {
                btnSiguientePag.Enabled = true;
                btnAnteriorPag.Enabled = true;
            }
            else
            {
                btnSiguientePag.Enabled = false;
                btnAnteriorPag.Enabled = true;
            }
            if(desde == 1)
            {
                ReiniciarPaginado();
            }
            paginado();
        }

        private void btnUltimaPag_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * itemsPagina;
            desde = hasta - (itemsPagina - 1);
            btnUltimaPag.Enabled = false;
            MostrarPersonal();
            contar();
            if(contador > hasta)
            {
                btnSiguientePag.Enabled = true;
                btnAnteriorPag.Enabled = true;
            }
            else
            {
                btnSiguientePag.Enabled = false;
                btnAnteriorPag.Enabled = true;

            }
            paginado();
        }

        private void btnPrimeraPag_Click(object sender, EventArgs e)
        {
            btnPrimeraPag.Enabled = false;
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }
        private void BuscarPersonal()
        {
            Dpersonal funcion = new Dpersonal();
            DataTable dt = new DataTable();
            funcion.buscarPersonal(ref dt, desde, hasta, txtBuscador.Text);
            dataListadoPersonal.DataSource = dt;
            diseñarDataGVPersonal();
        }

        private void button6_Click(object sender, EventArgs e) //mostrar todos
        {
            ReiniciarPaginado();
            MostrarPersonal();
            txtBuscador.Clear();
        }


    }
}
