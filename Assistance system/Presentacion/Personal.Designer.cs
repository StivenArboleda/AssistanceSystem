
namespace Assistance_system.Presentacion
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.dataListadoPersonal = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.lblTotalPag = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPag = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnPrimeraPag = new System.Windows.Forms.Button();
            this.btnSiguientePag = new System.Windows.Forms.Button();
            this.btnAnteriorPag = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataListadoCargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelCargos = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarC = new System.Windows.Forms.Button();
            this.btnGuardarCambiosC = new System.Windows.Forms.Button();
            this.btnVolverCargo = new System.Windows.Forms.Button();
            this.txtSueldoHoraCa = new System.Windows.Forms.TextBox();
            this.txtCargosCa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVolverPersonal = new System.Windows.Forms.Button();
            this.PanelBtnGuardarPersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnGuardarCambiosPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPersonal)).BeginInit();
            this.PanelPaginado.SuspendLayout();
            this.PanelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCargos)).BeginInit();
            this.PanelCargos.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.PanelBtnGuardarPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(102)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.btnMostrarTodos);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.Location = new System.Drawing.Point(509, 6);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(153, 57);
            this.btnMostrarTodos.TabIndex = 12;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(102)))), ((int)(((byte)(114)))));
            this.btnAgregar.BackgroundImage = global::Assistance_system.Properties.Resources.boton_agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(1365, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 75);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assistance_system.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(331, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(19, 23);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(294, 30);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // dataListadoPersonal
            // 
            this.dataListadoPersonal.AllowUserToAddRows = false;
            this.dataListadoPersonal.AllowUserToDeleteRows = false;
            this.dataListadoPersonal.AllowUserToResizeRows = false;
            this.dataListadoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Editar});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListadoPersonal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataListadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListadoPersonal.Location = new System.Drawing.Point(0, 75);
            this.dataListadoPersonal.Name = "dataListadoPersonal";
            this.dataListadoPersonal.ReadOnly = true;
            this.dataListadoPersonal.RowHeadersWidth = 51;
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(142)))), ((int)(((byte)(144)))));
            this.dataListadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataListadoPersonal.RowTemplate.Height = 40;
            this.dataListadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoPersonal.Size = new System.Drawing.Size(1445, 644);
            this.dataListadoPersonal.TabIndex = 1;
            this.dataListadoPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoPersonal_CellClick);
            this.dataListadoPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoPersonal_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::Assistance_system.Properties.Resources.eliminar;
            this.Eliminar.MinimumWidth = 50;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Editar.FillWeight = 50F;
            this.Editar.HeaderText = "";
            this.Editar.Image = global::Assistance_system.Properties.Resources.editar;
            this.Editar.MinimumWidth = 50;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // PanelPaginado
            // 
            this.PanelPaginado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(102)))), ((int)(((byte)(114)))));
            this.PanelPaginado.Controls.Add(this.lblTotalPag);
            this.PanelPaginado.Controls.Add(this.label8);
            this.PanelPaginado.Controls.Add(this.lblPag);
            this.PanelPaginado.Controls.Add(this.label5);
            this.PanelPaginado.Controls.Add(this.btnUltimaPag);
            this.PanelPaginado.Controls.Add(this.btnPrimeraPag);
            this.PanelPaginado.Controls.Add(this.btnSiguientePag);
            this.PanelPaginado.Controls.Add(this.btnAnteriorPag);
            this.PanelPaginado.Controls.Add(this.flowLayoutPanel1);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 719);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(1445, 86);
            this.PanelPaginado.TabIndex = 2;
            this.PanelPaginado.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTotalPag
            // 
            this.lblTotalPag.AutoSize = true;
            this.lblTotalPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPag.Location = new System.Drawing.Point(1131, 26);
            this.lblTotalPag.Name = "lblTotalPag";
            this.lblTotalPag.Size = new System.Drawing.Size(27, 29);
            this.lblTotalPag.TabIndex = 12;
            this.lblTotalPag.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1064, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "de";
            // 
            // lblPag
            // 
            this.lblPag.AutoSize = true;
            this.lblPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPag.Location = new System.Drawing.Point(1013, 26);
            this.lblPag.Name = "lblPag";
            this.lblPag.Size = new System.Drawing.Size(27, 29);
            this.lblPag.TabIndex = 10;
            this.lblPag.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(894, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Página";
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.BackgroundImage = global::Assistance_system.Properties.Resources.UltimaPag;
            this.btnUltimaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUltimaPag.FlatAppearance.BorderSize = 0;
            this.btnUltimaPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimaPag.Location = new System.Drawing.Point(812, 17);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(75, 54);
            this.btnUltimaPag.TabIndex = 4;
            this.btnUltimaPag.UseVisualStyleBackColor = true;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.BackgroundImage = global::Assistance_system.Properties.Resources.PrimeraPag;
            this.btnPrimeraPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrimeraPag.FlatAppearance.BorderSize = 0;
            this.btnPrimeraPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraPag.Location = new System.Drawing.Point(569, 17);
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Size = new System.Drawing.Size(75, 54);
            this.btnPrimeraPag.TabIndex = 3;
            this.btnPrimeraPag.UseVisualStyleBackColor = true;
            this.btnPrimeraPag.Click += new System.EventHandler(this.btnPrimeraPag_Click);
            // 
            // btnSiguientePag
            // 
            this.btnSiguientePag.BackgroundImage = global::Assistance_system.Properties.Resources.SiguienteNormal;
            this.btnSiguientePag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguientePag.FlatAppearance.BorderSize = 0;
            this.btnSiguientePag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguientePag.Location = new System.Drawing.Point(731, 17);
            this.btnSiguientePag.Name = "btnSiguientePag";
            this.btnSiguientePag.Size = new System.Drawing.Size(75, 54);
            this.btnSiguientePag.TabIndex = 2;
            this.btnSiguientePag.UseVisualStyleBackColor = true;
            this.btnSiguientePag.Click += new System.EventHandler(this.btnSiguientePag_Click);
            // 
            // btnAnteriorPag
            // 
            this.btnAnteriorPag.BackgroundImage = global::Assistance_system.Properties.Resources.AnteriorNormal;
            this.btnAnteriorPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnteriorPag.FlatAppearance.BorderSize = 0;
            this.btnAnteriorPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnteriorPag.Location = new System.Drawing.Point(650, 17);
            this.btnAnteriorPag.Name = "btnAnteriorPag";
            this.btnAnteriorPag.Size = new System.Drawing.Size(71, 54);
            this.btnAnteriorPag.TabIndex = 1;
            this.btnAnteriorPag.UseVisualStyleBackColor = true;
            this.btnAnteriorPag.Click += new System.EventHandler(this.btnAnteriorPag_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(147, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.Controls.Add(this.panel2);
            this.PanelRegistros.Controls.Add(this.dataListadoCargos);
            this.PanelRegistros.Controls.Add(this.PanelCargos);
            this.PanelRegistros.Controls.Add(this.btnVolverPersonal);
            this.PanelRegistros.Controls.Add(this.PanelBtnGuardarPersonal);
            this.PanelRegistros.Controls.Add(this.btnAgregarCargo);
            this.PanelRegistros.Controls.Add(this.comboBoxPais);
            this.PanelRegistros.Controls.Add(this.txtSueldoHora);
            this.PanelRegistros.Controls.Add(this.txtCargo);
            this.PanelRegistros.Controls.Add(this.txtId);
            this.PanelRegistros.Controls.Add(this.TxtNombres);
            this.PanelRegistros.Controls.Add(this.lblSueldo);
            this.PanelRegistros.Controls.Add(this.label4);
            this.PanelRegistros.Controls.Add(this.label3);
            this.PanelRegistros.Controls.Add(this.label2);
            this.PanelRegistros.Controls.Add(this.label1);
            this.PanelRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRegistros.Location = new System.Drawing.Point(19, 81);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(1423, 632);
            this.PanelRegistros.TabIndex = 4;
            this.PanelRegistros.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 10);
            this.panel2.TabIndex = 16;
            // 
            // dataListadoCargos
            // 
            this.dataListadoCargos.AllowUserToAddRows = false;
            this.dataListadoCargos.AllowUserToDeleteRows = false;
            this.dataListadoCargos.AllowUserToResizeRows = false;
            this.dataListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoCargos.ColumnHeadersVisible = false;
            this.dataListadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            this.dataListadoCargos.Location = new System.Drawing.Point(641, 469);
            this.dataListadoCargos.Name = "dataListadoCargos";
            this.dataListadoCargos.ReadOnly = true;
            this.dataListadoCargos.RowHeadersWidth = 51;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(142)))), ((int)(((byte)(144)))));
            this.dataListadoCargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataListadoCargos.RowTemplate.Height = 35;
            this.dataListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoCargos.Size = new System.Drawing.Size(391, 150);
            this.dataListadoCargos.TabIndex = 15;
            this.dataListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoCargos_CellClick);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "";
            this.EditarC.Image = global::Assistance_system.Properties.Resources.boton_editar;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.MinimumWidth = 6;
            this.EditarC.Name = "EditarC";
            this.EditarC.ReadOnly = true;
            this.EditarC.Width = 125;
            // 
            // PanelCargos
            // 
            this.PanelCargos.Controls.Add(this.flowLayoutPanel3);
            this.PanelCargos.Controls.Add(this.txtSueldoHoraCa);
            this.PanelCargos.Controls.Add(this.txtCargosCa);
            this.PanelCargos.Controls.Add(this.label10);
            this.PanelCargos.Controls.Add(this.label11);
            this.PanelCargos.Location = new System.Drawing.Point(909, 204);
            this.PanelCargos.Name = "PanelCargos";
            this.PanelCargos.Size = new System.Drawing.Size(499, 269);
            this.PanelCargos.TabIndex = 14;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnGuardarC);
            this.flowLayoutPanel3.Controls.Add(this.btnGuardarCambiosC);
            this.flowLayoutPanel3.Controls.Add(this.btnVolverCargo);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(17, 177);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(465, 82);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.FlatAppearance.BorderSize = 0;
            this.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarC.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(143, 69);
            this.btnGuardarC.TabIndex = 0;
            this.btnGuardarC.Text = "Guardar";
            this.btnGuardarC.UseVisualStyleBackColor = true;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnGuardarCambiosC
            // 
            this.btnGuardarCambiosC.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosC.Location = new System.Drawing.Point(152, 3);
            this.btnGuardarCambiosC.Name = "btnGuardarCambiosC";
            this.btnGuardarCambiosC.Size = new System.Drawing.Size(147, 69);
            this.btnGuardarCambiosC.TabIndex = 1;
            this.btnGuardarCambiosC.Text = "Guardar *";
            this.btnGuardarCambiosC.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosC.Click += new System.EventHandler(this.btnGuardarCambiosC_Click);
            // 
            // btnVolverCargo
            // 
            this.btnVolverCargo.BackgroundImage = global::Assistance_system.Properties.Resources.back;
            this.btnVolverCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverCargo.FlatAppearance.BorderSize = 0;
            this.btnVolverCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCargo.Location = new System.Drawing.Point(305, 3);
            this.btnVolverCargo.Name = "btnVolverCargo";
            this.btnVolverCargo.Size = new System.Drawing.Size(100, 75);
            this.btnVolverCargo.TabIndex = 14;
            this.btnVolverCargo.UseVisualStyleBackColor = true;
            this.btnVolverCargo.Click += new System.EventHandler(this.btnVolverCargo_Click);
            // 
            // txtSueldoHoraCa
            // 
            this.txtSueldoHoraCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoHoraCa.Location = new System.Drawing.Point(234, 102);
            this.txtSueldoHoraCa.Name = "txtSueldoHoraCa";
            this.txtSueldoHoraCa.Size = new System.Drawing.Size(242, 34);
            this.txtSueldoHoraCa.TabIndex = 16;
            this.txtSueldoHoraCa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoHoraCa_KeyPress);
            // 
            // txtCargosCa
            // 
            this.txtCargosCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargosCa.Location = new System.Drawing.Point(169, 48);
            this.txtCargosCa.Name = "txtCargosCa";
            this.txtCargosCa.Size = new System.Drawing.Size(307, 30);
            this.txtCargosCa.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sueldo por hora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cargo:";
            // 
            // btnVolverPersonal
            // 
            this.btnVolverPersonal.BackgroundImage = global::Assistance_system.Properties.Resources.back;
            this.btnVolverPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolverPersonal.FlatAppearance.BorderSize = 0;
            this.btnVolverPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPersonal.Location = new System.Drawing.Point(751, 187);
            this.btnVolverPersonal.Name = "btnVolverPersonal";
            this.btnVolverPersonal.Size = new System.Drawing.Size(100, 75);
            this.btnVolverPersonal.TabIndex = 13;
            this.btnVolverPersonal.UseVisualStyleBackColor = true;
            this.btnVolverPersonal.Click += new System.EventHandler(this.btnVolverPersonal_Click);
            // 
            // PanelBtnGuardarPersonal
            // 
            this.PanelBtnGuardarPersonal.Controls.Add(this.btnGuardarPersonal);
            this.PanelBtnGuardarPersonal.Controls.Add(this.btnGuardarCambiosPersonal);
            this.PanelBtnGuardarPersonal.Location = new System.Drawing.Point(213, 514);
            this.PanelBtnGuardarPersonal.Name = "PanelBtnGuardarPersonal";
            this.PanelBtnGuardarPersonal.Size = new System.Drawing.Size(342, 64);
            this.PanelBtnGuardarPersonal.TabIndex = 12;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(141, 57);
            this.btnGuardarPersonal.TabIndex = 0;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnGuardarCambiosPersonal
            // 
            this.btnGuardarCambiosPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambiosPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambiosPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosPersonal.Location = new System.Drawing.Point(150, 3);
            this.btnGuardarCambiosPersonal.Name = "btnGuardarCambiosPersonal";
            this.btnGuardarCambiosPersonal.Size = new System.Drawing.Size(120, 57);
            this.btnGuardarCambiosPersonal.TabIndex = 1;
            this.btnGuardarCambiosPersonal.Text = "Guardar *";
            this.btnGuardarCambiosPersonal.UseVisualStyleBackColor = true;
            this.btnGuardarCambiosPersonal.Click += new System.EventHandler(this.btnGuardarCambiosPersonal_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCargo.Location = new System.Drawing.Point(641, 360);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(173, 82);
            this.btnAgregarCargo.TabIndex = 11;
            this.btnAgregarCargo.Text = "+ Agregar cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            "Peru",
            "Venezuela",
            "México",
            "Costa Rica",
            "Guatemala",
            "Honduras",
            "Nicaragua",
            "Panamá",
            "Cuba",
            "Puerto Rico",
            "República Dominicana",
            "Argentina",
            "Bolivia",
            "Chile",
            "Colombia",
            "Ecuador",
            "Uruguay",
            "España"});
            this.comboBoxPais.Location = new System.Drawing.Point(273, 335);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(331, 37);
            this.comboBoxPais.TabIndex = 10;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSueldoHora.Location = new System.Drawing.Point(324, 474);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(301, 34);
            this.txtSueldoHora.TabIndex = 9;
            this.txtSueldoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoHora_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(213, 408);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(391, 34);
            this.txtCargo.TabIndex = 8;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(273, 267);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(331, 34);
            this.txtId.TabIndex = 6;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(344, 187);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(331, 34);
            this.TxtNombres.TabIndex = 3;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSueldo.Location = new System.Drawing.Point(85, 474);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(208, 29);
            this.lblSueldo.TabIndex = 5;
            this.lblSueldo.Text = "Sueldo por hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(85, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(85, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "País: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(85, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y apellido: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Assistance_system.Properties.Resources.boton_editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Assistance_system.Properties.Resources.boton_editar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Assistance_system.Properties.Resources.boton_editar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.dataListadoPersonal);
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1445, 805);
            this.Load += new System.EventHandler(this.Personal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPersonal)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelPaginado.PerformLayout();
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoCargos)).EndInit();
            this.PanelCargos.ResumeLayout(false);
            this.PanelCargos.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PanelBtnGuardarPersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataListadoPersonal;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAnteriorPag;
        private System.Windows.Forms.Button btnSiguientePag;
        private System.Windows.Forms.Button btnUltimaPag;
        private System.Windows.Forms.Button btnPrimeraPag;
        private System.Windows.Forms.Label lblTotalPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel PanelRegistros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataListadoCargos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.Panel PanelCargos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnGuardarC;
        private System.Windows.Forms.Button btnGuardarCambiosC;
        private System.Windows.Forms.Button btnVolverCargo;
        private System.Windows.Forms.TextBox txtSueldoHoraCa;
        private System.Windows.Forms.TextBox txtCargosCa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVolverPersonal;
        private System.Windows.Forms.FlowLayoutPanel PanelBtnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnGuardarCambiosPersonal;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.Timer timer1;
    }
}
