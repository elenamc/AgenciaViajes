namespace AgenciaViajes
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtSatisfacion = new System.Windows.Forms.TextBox();
            this.lbSatifacion = new System.Windows.Forms.Label();
            this.lbDiscapacidad = new System.Windows.Forms.Label();
            this.dateTimePickerV = new System.Windows.Forms.DateTimePicker();
            this.lbFechaVuelta = new System.Windows.Forms.Label();
            this.dateTimePickerS = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lbFechaIda = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.lbIdViaje = new System.Windows.Forms.Label();
            this.txtNumviaje = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtControlUsuario = new System.Windows.Forms.TextBox();
            this.lbAdm = new System.Windows.Forms.Label();
            this.comboBoxContolBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtContolSatisfacion = new System.Windows.Forms.TextBox();
            this.txtContolSexo = new System.Windows.Forms.TextBox();
            this.txtControlFecha = new System.Windows.Forms.TextBox();
            this.txtControlDiscapacidad = new System.Windows.Forms.TextBox();
            this.txtControl_destino = new System.Windows.Forms.TextBox();
            this.txtControl_idViaje = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbControlDestino = new System.Windows.Forms.Label();
            this.lbContolDis = new System.Windows.Forms.Label();
            this.lbControlSex = new System.Windows.Forms.Label();
            this.lbControlNS = new System.Windows.Forms.Label();
            this.lbFechaControl = new System.Windows.Forms.Label();
            this.lb_idViajeControl = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLoginSalir = new System.Windows.Forms.Button();
            this.btnLoginIngresa = new System.Windows.Forms.Button();
            this.txtLoginCñ = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.lbLoginCñ = new System.Windows.Forms.Label();
            this.lbLogin_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.rBHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.cmBDiscapacidad = new System.Windows.Forms.ComboBox();
            this.errorProviderViajeros = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderViajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmBDiscapacidad);
            this.groupBox1.Controls.Add(this.groupBoxSexo);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtSatisfacion);
            this.groupBox1.Controls.Add(this.lbSatifacion);
            this.groupBox1.Controls.Add(this.lbDiscapacidad);
            this.groupBox1.Controls.Add(this.dateTimePickerV);
            this.groupBox1.Controls.Add(this.lbFechaVuelta);
            this.groupBox1.Controls.Add(this.dateTimePickerS);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.lbFechaIda);
            this.groupBox1.Controls.Add(this.lbDescripcion);
            this.groupBox1.Controls.Add(this.lbDestino);
            this.groupBox1.Controls.Add(this.lbIdViaje);
            this.groupBox1.Controls.Add(this.txtNumviaje);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(461, 509);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Experiencias del Usuario";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 312);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(436, 190);
            this.dataGridView2.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Teal;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.Location = new System.Drawing.Point(346, 239);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 40);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar\r\nDatos";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtSatisfacion
            // 
            this.txtSatisfacion.Location = new System.Drawing.Point(346, 177);
            this.txtSatisfacion.Name = "txtSatisfacion";
            this.txtSatisfacion.Size = new System.Drawing.Size(100, 21);
            this.txtSatisfacion.TabIndex = 5;
            // 
            // lbSatifacion
            // 
            this.lbSatifacion.AutoSize = true;
            this.lbSatifacion.Location = new System.Drawing.Point(268, 153);
            this.lbSatifacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSatifacion.Name = "lbSatifacion";
            this.lbSatifacion.Size = new System.Drawing.Size(134, 15);
            this.lbSatifacion.TabIndex = 2;
            this.lbSatifacion.Text = "Nivel de Satisfación";
            // 
            // lbDiscapacidad
            // 
            this.lbDiscapacidad.AutoSize = true;
            this.lbDiscapacidad.Location = new System.Drawing.Point(7, 200);
            this.lbDiscapacidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiscapacidad.Name = "lbDiscapacidad";
            this.lbDiscapacidad.Size = new System.Drawing.Size(94, 15);
            this.lbDiscapacidad.TabIndex = 2;
            this.lbDiscapacidad.Text = "Discapacidad";
            // 
            // dateTimePickerV
            // 
            this.dateTimePickerV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerV.Location = new System.Drawing.Point(105, 264);
            this.dateTimePickerV.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerV.Name = "dateTimePickerV";
            this.dateTimePickerV.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerV.TabIndex = 2;
            // 
            // lbFechaVuelta
            // 
            this.lbFechaVuelta.AutoSize = true;
            this.lbFechaVuelta.Location = new System.Drawing.Point(10, 264);
            this.lbFechaVuelta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaVuelta.Name = "lbFechaVuelta";
            this.lbFechaVuelta.Size = new System.Drawing.Size(90, 15);
            this.lbFechaVuelta.TabIndex = 2;
            this.lbFechaVuelta.Text = "Fecha Vuelta";
            // 
            // dateTimePickerS
            // 
            this.dateTimePickerS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerS.Location = new System.Drawing.Point(105, 227);
            this.dateTimePickerS.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerS.Name = "dateTimePickerS";
            this.dateTimePickerS.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerS.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(271, 68);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(175, 66);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(140, 110);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(116, 24);
            this.txtDestino.TabIndex = 2;
            // 
            // lbFechaIda
            // 
            this.lbFechaIda.AutoSize = true;
            this.lbFechaIda.Location = new System.Drawing.Point(10, 233);
            this.lbFechaIda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaIda.Name = "lbFechaIda";
            this.lbFechaIda.Size = new System.Drawing.Size(91, 15);
            this.lbFechaIda.TabIndex = 2;
            this.lbFechaIda.Text = "Fecha Salida";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(280, 34);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(83, 15);
            this.lbDescripcion.TabIndex = 2;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(10, 110);
            this.lbDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(56, 15);
            this.lbDestino.TabIndex = 3;
            this.lbDestino.Text = "Destino";
            // 
            // lbIdViaje
            // 
            this.lbIdViaje.AutoSize = true;
            this.lbIdViaje.Location = new System.Drawing.Point(10, 34);
            this.lbIdViaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdViaje.Name = "lbIdViaje";
            this.lbIdViaje.Size = new System.Drawing.Size(58, 15);
            this.lbIdViaje.TabIndex = 2;
            this.lbIdViaje.Text = "Nº Viaje";
            // 
            // txtNumviaje
            // 
            this.txtNumviaje.Location = new System.Drawing.Point(180, 31);
            this.txtNumviaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumviaje.Name = "txtNumviaje";
            this.txtNumviaje.Size = new System.Drawing.Size(76, 21);
            this.txtNumviaje.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtControlUsuario);
            this.groupBox2.Controls.Add(this.lbAdm);
            this.groupBox2.Controls.Add(this.comboBoxContolBuscar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lbControlSex);
            this.groupBox2.Controls.Add(this.txtContolSexo);
            this.groupBox2.Controls.Add(this.btnModificacion);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.txtContolSatisfacion);
            this.groupBox2.Controls.Add(this.txtControlFecha);
            this.groupBox2.Controls.Add(this.txtControlDiscapacidad);
            this.groupBox2.Controls.Add(this.txtControl_destino);
            this.groupBox2.Controls.Add(this.txtControl_idViaje);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.lbControlDestino);
            this.groupBox2.Controls.Add(this.lbContolDis);
            this.groupBox2.Controls.Add(this.lbControlNS);
            this.groupBox2.Controls.Add(this.lbFechaControl);
            this.groupBox2.Controls.Add(this.lb_idViajeControl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(493, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(724, 278);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Experiencias";
            // 
            // txtControlUsuario
            // 
            this.txtControlUsuario.Location = new System.Drawing.Point(89, 191);
            this.txtControlUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtControlUsuario.Name = "txtControlUsuario";
            this.txtControlUsuario.Size = new System.Drawing.Size(90, 21);
            this.txtControlUsuario.TabIndex = 19;
            // 
            // lbAdm
            // 
            this.lbAdm.AutoSize = true;
            this.lbAdm.Location = new System.Drawing.Point(14, 197);
            this.lbAdm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdm.Name = "lbAdm";
            this.lbAdm.Size = new System.Drawing.Size(47, 15);
            this.lbAdm.TabIndex = 18;
            this.lbAdm.Text = "Admin";
            // 
            // comboBoxContolBuscar
            // 
            this.comboBoxContolBuscar.FormattingEnabled = true;
            this.comboBoxContolBuscar.Location = new System.Drawing.Point(287, 191);
            this.comboBoxContolBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxContolBuscar.Name = "comboBoxContolBuscar";
            this.comboBoxContolBuscar.Size = new System.Drawing.Size(95, 23);
            this.comboBoxContolBuscar.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Teal;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(306, 232);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 33);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.BackColor = System.Drawing.Color.Teal;
            this.btnModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificacion.Location = new System.Drawing.Point(177, 232);
            this.btnModificacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(116, 33);
            this.btnModificacion.TabIndex = 15;
            this.btnModificacion.Text = "Modificación";
            this.btnModificacion.UseVisualStyleBackColor = false;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(89, 232);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 33);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(17, 232);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 33);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtContolSatisfacion
            // 
            this.txtContolSatisfacion.Location = new System.Drawing.Point(151, 107);
            this.txtContolSatisfacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtContolSatisfacion.Name = "txtContolSatisfacion";
            this.txtContolSatisfacion.Size = new System.Drawing.Size(96, 21);
            this.txtContolSatisfacion.TabIndex = 12;
            // 
            // txtContolSexo
            // 
            this.txtContolSexo.Location = new System.Drawing.Point(74, 74);
            this.txtContolSexo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContolSexo.Name = "txtContolSexo";
            this.txtContolSexo.Size = new System.Drawing.Size(80, 21);
            this.txtContolSexo.TabIndex = 11;
            // 
            // txtControlFecha
            // 
            this.txtControlFecha.Location = new System.Drawing.Point(247, 37);
            this.txtControlFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtControlFecha.Name = "txtControlFecha";
            this.txtControlFecha.Size = new System.Drawing.Size(135, 21);
            this.txtControlFecha.TabIndex = 10;
            // 
            // txtControlDiscapacidad
            // 
            this.txtControlDiscapacidad.Location = new System.Drawing.Point(150, 141);
            this.txtControlDiscapacidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtControlDiscapacidad.Name = "txtControlDiscapacidad";
            this.txtControlDiscapacidad.Size = new System.Drawing.Size(97, 21);
            this.txtControlDiscapacidad.TabIndex = 9;
            // 
            // txtControl_destino
            // 
            this.txtControl_destino.Location = new System.Drawing.Point(247, 71);
            this.txtControl_destino.Margin = new System.Windows.Forms.Padding(2);
            this.txtControl_destino.Multiline = true;
            this.txtControl_destino.Name = "txtControl_destino";
            this.txtControl_destino.Size = new System.Drawing.Size(135, 24);
            this.txtControl_destino.TabIndex = 8;
            // 
            // txtControl_idViaje
            // 
            this.txtControl_idViaje.Location = new System.Drawing.Point(74, 37);
            this.txtControl_idViaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtControl_idViaje.Name = "txtControl_idViaje";
            this.txtControl_idViaje.Size = new System.Drawing.Size(80, 21);
            this.txtControl_idViaje.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 234);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lbControlDestino
            // 
            this.lbControlDestino.AutoSize = true;
            this.lbControlDestino.Location = new System.Drawing.Point(180, 80);
            this.lbControlDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbControlDestino.Name = "lbControlDestino";
            this.lbControlDestino.Size = new System.Drawing.Size(56, 15);
            this.lbControlDestino.TabIndex = 5;
            this.lbControlDestino.Text = "Destino";
            // 
            // lbContolDis
            // 
            this.lbContolDis.AutoSize = true;
            this.lbContolDis.Location = new System.Drawing.Point(5, 141);
            this.lbContolDis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContolDis.Name = "lbContolDis";
            this.lbContolDis.Size = new System.Drawing.Size(94, 15);
            this.lbContolDis.TabIndex = 4;
            this.lbContolDis.Text = "Discapacidad";
            // 
            // lbControlSex
            // 
            this.lbControlSex.AutoSize = true;
            this.lbControlSex.Location = new System.Drawing.Point(13, 77);
            this.lbControlSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbControlSex.Name = "lbControlSex";
            this.lbControlSex.Size = new System.Drawing.Size(39, 15);
            this.lbControlSex.TabIndex = 3;
            this.lbControlSex.Text = "Sexo";
            // 
            // lbControlNS
            // 
            this.lbControlNS.AutoSize = true;
            this.lbControlNS.Location = new System.Drawing.Point(5, 113);
            this.lbControlNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbControlNS.Name = "lbControlNS";
            this.lbControlNS.Size = new System.Drawing.Size(134, 15);
            this.lbControlNS.TabIndex = 2;
            this.lbControlNS.Text = "Nivel de Satisfación";
            // 
            // lbFechaControl
            // 
            this.lbFechaControl.AutoSize = true;
            this.lbFechaControl.Location = new System.Drawing.Point(180, 40);
            this.lbFechaControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaControl.Name = "lbFechaControl";
            this.lbFechaControl.Size = new System.Drawing.Size(46, 15);
            this.lbFechaControl.TabIndex = 1;
            this.lbFechaControl.Text = "Fecha";
            // 
            // lb_idViajeControl
            // 
            this.lb_idViajeControl.AutoSize = true;
            this.lb_idViajeControl.Location = new System.Drawing.Point(4, 37);
            this.lb_idViajeControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_idViajeControl.Name = "lb_idViajeControl";
            this.lb_idViajeControl.Size = new System.Drawing.Size(55, 15);
            this.lb_idViajeControl.TabIndex = 0;
            this.lb_idViajeControl.Text = "Id Viaje";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.btnLoginSalir);
            this.groupBoxLogin.Controls.Add(this.btnLoginIngresa);
            this.groupBoxLogin.Controls.Add(this.txtLoginCñ);
            this.groupBoxLogin.Controls.Add(this.txtLoginUsuario);
            this.groupBoxLogin.Controls.Add(this.lbLoginCñ);
            this.groupBoxLogin.Controls.Add(this.lbLogin_usuario);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.ForeColor = System.Drawing.Color.Crimson;
            this.groupBoxLogin.Location = new System.Drawing.Point(493, 306);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLogin.Size = new System.Drawing.Size(263, 213);
            this.groupBoxLogin.TabIndex = 3;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login Usuario";
            // 
            // btnLoginSalir
            // 
            this.btnLoginSalir.BackColor = System.Drawing.Color.Teal;
            this.btnLoginSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoginSalir.Location = new System.Drawing.Point(144, 167);
            this.btnLoginSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginSalir.Name = "btnLoginSalir";
            this.btnLoginSalir.Size = new System.Drawing.Size(93, 39);
            this.btnLoginSalir.TabIndex = 22;
            this.btnLoginSalir.Text = "Salir";
            this.btnLoginSalir.UseVisualStyleBackColor = false;
            // 
            // btnLoginIngresa
            // 
            this.btnLoginIngresa.BackColor = System.Drawing.Color.Teal;
            this.btnLoginIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginIngresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoginIngresa.Location = new System.Drawing.Point(16, 129);
            this.btnLoginIngresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoginIngresa.Name = "btnLoginIngresa";
            this.btnLoginIngresa.Size = new System.Drawing.Size(93, 37);
            this.btnLoginIngresa.TabIndex = 21;
            this.btnLoginIngresa.Text = "Acceso";
            this.btnLoginIngresa.UseVisualStyleBackColor = false;
            // 
            // txtLoginCñ
            // 
            this.txtLoginCñ.Location = new System.Drawing.Point(113, 81);
            this.txtLoginCñ.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginCñ.Name = "txtLoginCñ";
            this.txtLoginCñ.Size = new System.Drawing.Size(107, 21);
            this.txtLoginCñ.TabIndex = 20;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(113, 40);
            this.txtLoginUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(107, 21);
            this.txtLoginUsuario.TabIndex = 2;
            // 
            // lbLoginCñ
            // 
            this.lbLoginCñ.AutoSize = true;
            this.lbLoginCñ.Location = new System.Drawing.Point(3, 81);
            this.lbLoginCñ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoginCñ.Name = "lbLoginCñ";
            this.lbLoginCñ.Size = new System.Drawing.Size(80, 15);
            this.lbLoginCñ.TabIndex = 1;
            this.lbLoginCñ.Text = "Contraseña";
            // 
            // lbLogin_usuario
            // 
            this.lbLogin_usuario.AutoSize = true;
            this.lbLogin_usuario.Location = new System.Drawing.Point(4, 43);
            this.lbLogin_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin_usuario.Name = "lbLogin_usuario";
            this.lbLogin_usuario.Size = new System.Drawing.Size(57, 15);
            this.lbLogin_usuario.TabIndex = 0;
            this.lbLogin_usuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgenciaViajes.Properties.Resources.inviajes_1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(780, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 195);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.rbMujer);
            this.groupBoxSexo.Controls.Add(this.rBHombre);
            this.groupBoxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSexo.ForeColor = System.Drawing.Color.Crimson;
            this.groupBoxSexo.Location = new System.Drawing.Point(13, 142);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(193, 45);
            this.groupBoxSexo.TabIndex = 8;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // rBHombre
            // 
            this.rBHombre.AutoSize = true;
            this.rBHombre.Checked = true;
            this.rBHombre.Location = new System.Drawing.Point(7, 16);
            this.rBHombre.Name = "rBHombre";
            this.rBHombre.Size = new System.Drawing.Size(81, 20);
            this.rBHombre.TabIndex = 0;
            this.rBHombre.TabStop = true;
            this.rBHombre.Text = "Hombre";
            this.rBHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(111, 16);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(64, 20);
            this.rbMujer.TabIndex = 1;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // cmBDiscapacidad
            // 
            this.cmBDiscapacidad.FormattingEnabled = true;
            this.cmBDiscapacidad.Items.AddRange(new object[] {
            "Ninguna",
            "Física",
            "Sensorial",
            "Visceral ",
            "Intelectual",
            "Psíquica",
            "Múltiple",
            ""});
            this.cmBDiscapacidad.Location = new System.Drawing.Point(105, 193);
            this.cmBDiscapacidad.Name = "cmBDiscapacidad";
            this.cmBDiscapacidad.Size = new System.Drawing.Size(121, 23);
            this.cmBDiscapacidad.TabIndex = 9;
            // 
            // errorProviderViajeros
            // 
            this.errorProviderViajeros.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1230, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Experiencias Viajes ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderViajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIdViaje;
        private System.Windows.Forms.TextBox txtNumviaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbFechaVuelta;
        private System.Windows.Forms.DateTimePicker dateTimePickerS;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lbFechaIda;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.Label lbDiscapacidad;
        private System.Windows.Forms.DateTimePicker dateTimePickerV;
        private System.Windows.Forms.Label lbSatifacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbContolDis;
        private System.Windows.Forms.Label lbControlSex;
        private System.Windows.Forms.Label lbControlNS;
        private System.Windows.Forms.Label lbFechaControl;
        private System.Windows.Forms.Label lb_idViajeControl;
        private System.Windows.Forms.Label lbControlDestino;
        private System.Windows.Forms.TextBox txtControlDiscapacidad;
        private System.Windows.Forms.TextBox txtControl_destino;
        private System.Windows.Forms.TextBox txtControl_idViaje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbAdm;
        private System.Windows.Forms.ComboBox comboBoxContolBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtContolSatisfacion;
        private System.Windows.Forms.TextBox txtContolSexo;
        private System.Windows.Forms.TextBox txtControlFecha;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label lbLoginCñ;
        private System.Windows.Forms.Label lbLogin_usuario;
        private System.Windows.Forms.TextBox txtControlUsuario;
        private System.Windows.Forms.Button btnLoginSalir;
        private System.Windows.Forms.Button btnLoginIngresa;
        private System.Windows.Forms.TextBox txtLoginCñ;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtSatisfacion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rBHombre;
        private System.Windows.Forms.ComboBox cmBDiscapacidad;
        private System.Windows.Forms.ErrorProvider errorProviderViajeros;
    }
}

