namespace CapaPresentacion
{
    partial class Seccion_Vuelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPaisOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxPaisDestino = new System.Windows.Forms.ComboBox();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.panelAgregarHotel = new System.Windows.Forms.Panel();
            this.btnGuardarSeleccionHotel = new System.Windows.Forms.Button();
            this.spinnerCantidadHabitacionesHotel = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxHotelesPasDestino = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAgregarAutomovil = new System.Windows.Forms.Panel();
            this.btnGuardarSeleccionAutomovil = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPrecioVehiculo = new System.Windows.Forms.TextBox();
            this.textBoxTipoVehiculo = new System.Windows.Forms.TextBox();
            this.textBoxModeloVehiculo = new System.Windows.Forms.TextBox();
            this.textBoxMarcaVehiculo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxVehiculos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spinnerCantidadPasajerosAdultos = new System.Windows.Forms.NumericUpDown();
            this.btnCofirmarReservacion1 = new System.Windows.Forms.Button();
            this.optTodosServicios = new System.Windows.Forms.RadioButton();
            this.optHotel = new System.Windows.Forms.RadioButton();
            this.optAutomovil = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.spinnerCantidadPasajerosNiños = new System.Windows.Forms.NumericUpDown();
            this.labelCantidadDias = new System.Windows.Forms.Label();
            this.btnGuardarReservacionPais = new System.Windows.Forms.Button();
            this.dtgVistaPreliminarVHA = new System.Windows.Forms.DataGridView();
            this.optPrecioMayorHotel = new System.Windows.Forms.RadioButton();
            this.btnVerListaPreeliminarHotelesVuelos = new System.Windows.Forms.Button();
            this.optPrecioMenorHotel = new System.Windows.Forms.RadioButton();
            this.optTiempoCorto = new System.Windows.Forms.RadioButton();
            this.optMenosEscalas = new System.Windows.Forms.RadioButton();
            this.btnGuardarCantidadPasajeros = new System.Windows.Forms.Button();
            this.panelAgregarHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCantidadHabitacionesHotel)).BeginInit();
            this.panelAgregarAutomovil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCantidadPasajerosAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCantidadPasajerosNiños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaPreliminarVHA)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Finalizacion:";
            // 
            // comboBoxPaisOrigen
            // 
            this.comboBoxPaisOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaisOrigen.FormattingEnabled = true;
            this.comboBoxPaisOrigen.Location = new System.Drawing.Point(155, 23);
            this.comboBoxPaisOrigen.Name = "comboBoxPaisOrigen";
            this.comboBoxPaisOrigen.Size = new System.Drawing.Size(227, 21);
            this.comboBoxPaisOrigen.TabIndex = 5;
            // 
            // comboBoxPaisDestino
            // 
            this.comboBoxPaisDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaisDestino.FormattingEnabled = true;
            this.comboBoxPaisDestino.Location = new System.Drawing.Point(485, 23);
            this.comboBoxPaisDestino.Name = "comboBoxPaisDestino";
            this.comboBoxPaisDestino.Size = new System.Drawing.Size(239, 21);
            this.comboBoxPaisDestino.TabIndex = 6;
            this.comboBoxPaisDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaisDestino_SelectedIndexChanged);
            // 
            // fechaInicio
            // 
            this.fechaInicio.CustomFormat = "dd/MM/yyyy";
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicio.Location = new System.Drawing.Point(121, 85);
            this.fechaInicio.MinDate = new System.DateTime(2018, 3, 5, 0, 0, 0, 0);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(78, 20);
            this.fechaInicio.TabIndex = 7;
            this.fechaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.CustomFormat = "dd/MM/yyyy";
            this.fechaFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFinalizacion.Location = new System.Drawing.Point(760, 80);
            this.fechaFinalizacion.MinDate = new System.DateTime(2018, 3, 5, 0, 0, 0, 0);
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.Size = new System.Drawing.Size(88, 20);
            this.fechaFinalizacion.TabIndex = 8;
            this.fechaFinalizacion.ValueChanged += new System.EventHandler(this.fechaFinalizacion_ValueChanged);
            this.fechaFinalizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker2_KeyPress);
            // 
            // panelAgregarHotel
            // 
            this.panelAgregarHotel.Controls.Add(this.btnGuardarSeleccionHotel);
            this.panelAgregarHotel.Controls.Add(this.spinnerCantidadHabitacionesHotel);
            this.panelAgregarHotel.Controls.Add(this.label9);
            this.panelAgregarHotel.Controls.Add(this.comboBoxHotelesPasDestino);
            this.panelAgregarHotel.Controls.Add(this.label6);
            this.panelAgregarHotel.Location = new System.Drawing.Point(3, 194);
            this.panelAgregarHotel.Name = "panelAgregarHotel";
            this.panelAgregarHotel.Size = new System.Drawing.Size(389, 98);
            this.panelAgregarHotel.TabIndex = 11;
            this.panelAgregarHotel.Visible = false;
            // 
            // btnGuardarSeleccionHotel
            // 
            this.btnGuardarSeleccionHotel.Location = new System.Drawing.Point(240, 47);
            this.btnGuardarSeleccionHotel.Name = "btnGuardarSeleccionHotel";
            this.btnGuardarSeleccionHotel.Size = new System.Drawing.Size(107, 23);
            this.btnGuardarSeleccionHotel.TabIndex = 9;
            this.btnGuardarSeleccionHotel.Text = "Guardar Seleccion";
            this.btnGuardarSeleccionHotel.UseVisualStyleBackColor = true;
            // 
            // spinnerCantidadHabitacionesHotel
            // 
            this.spinnerCantidadHabitacionesHotel.Location = new System.Drawing.Point(164, 47);
            this.spinnerCantidadHabitacionesHotel.Name = "spinnerCantidadHabitacionesHotel";
            this.spinnerCantidadHabitacionesHotel.Size = new System.Drawing.Size(47, 20);
            this.spinnerCantidadHabitacionesHotel.TabIndex = 8;
            this.spinnerCantidadHabitacionesHotel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinnerCantidadHabitacionesHotel_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cantidad de Habitaciones:";
            // 
            // comboBoxHotelesPasDestino
            // 
            this.comboBoxHotelesPasDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotelesPasDestino.FormattingEnabled = true;
            this.comboBoxHotelesPasDestino.Location = new System.Drawing.Point(118, 9);
            this.comboBoxHotelesPasDestino.Name = "comboBoxHotelesPasDestino";
            this.comboBoxHotelesPasDestino.Size = new System.Drawing.Size(261, 21);
            this.comboBoxHotelesPasDestino.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione el Hotel:";
            // 
            // panelAgregarAutomovil
            // 
            this.panelAgregarAutomovil.Controls.Add(this.btnGuardarSeleccionAutomovil);
            this.panelAgregarAutomovil.Controls.Add(this.label14);
            this.panelAgregarAutomovil.Controls.Add(this.textBoxPrecioVehiculo);
            this.panelAgregarAutomovil.Controls.Add(this.textBoxTipoVehiculo);
            this.panelAgregarAutomovil.Controls.Add(this.textBoxModeloVehiculo);
            this.panelAgregarAutomovil.Controls.Add(this.textBoxMarcaVehiculo);
            this.panelAgregarAutomovil.Controls.Add(this.label13);
            this.panelAgregarAutomovil.Controls.Add(this.label12);
            this.panelAgregarAutomovil.Controls.Add(this.label11);
            this.panelAgregarAutomovil.Controls.Add(this.label10);
            this.panelAgregarAutomovil.Controls.Add(this.comboBoxVehiculos);
            this.panelAgregarAutomovil.Controls.Add(this.label7);
            this.panelAgregarAutomovil.Location = new System.Drawing.Point(3, 298);
            this.panelAgregarAutomovil.Name = "panelAgregarAutomovil";
            this.panelAgregarAutomovil.Size = new System.Drawing.Size(389, 236);
            this.panelAgregarAutomovil.TabIndex = 12;
            this.panelAgregarAutomovil.Visible = false;
            // 
            // btnGuardarSeleccionAutomovil
            // 
            this.btnGuardarSeleccionAutomovil.Location = new System.Drawing.Point(164, 203);
            this.btnGuardarSeleccionAutomovil.Name = "btnGuardarSeleccionAutomovil";
            this.btnGuardarSeleccionAutomovil.Size = new System.Drawing.Size(113, 23);
            this.btnGuardarSeleccionAutomovil.TabIndex = 17;
            this.btnGuardarSeleccionAutomovil.Text = "Guardar Seleccion";
            this.btnGuardarSeleccionAutomovil.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(194, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Detalles Vehiculo";
            // 
            // textBoxPrecioVehiculo
            // 
            this.textBoxPrecioVehiculo.Enabled = false;
            this.textBoxPrecioVehiculo.Location = new System.Drawing.Point(135, 177);
            this.textBoxPrecioVehiculo.Name = "textBoxPrecioVehiculo";
            this.textBoxPrecioVehiculo.Size = new System.Drawing.Size(205, 20);
            this.textBoxPrecioVehiculo.TabIndex = 15;
            // 
            // textBoxTipoVehiculo
            // 
            this.textBoxTipoVehiculo.Enabled = false;
            this.textBoxTipoVehiculo.Location = new System.Drawing.Point(135, 137);
            this.textBoxTipoVehiculo.Name = "textBoxTipoVehiculo";
            this.textBoxTipoVehiculo.Size = new System.Drawing.Size(205, 20);
            this.textBoxTipoVehiculo.TabIndex = 14;
            // 
            // textBoxModeloVehiculo
            // 
            this.textBoxModeloVehiculo.Enabled = false;
            this.textBoxModeloVehiculo.Location = new System.Drawing.Point(135, 100);
            this.textBoxModeloVehiculo.Name = "textBoxModeloVehiculo";
            this.textBoxModeloVehiculo.Size = new System.Drawing.Size(205, 20);
            this.textBoxModeloVehiculo.TabIndex = 13;
            // 
            // textBoxMarcaVehiculo
            // 
            this.textBoxMarcaVehiculo.Enabled = false;
            this.textBoxMarcaVehiculo.Location = new System.Drawing.Point(135, 58);
            this.textBoxMarcaVehiculo.Name = "textBoxMarcaVehiculo";
            this.textBoxMarcaVehiculo.Size = new System.Drawing.Size(205, 20);
            this.textBoxMarcaVehiculo.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tipo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Modelo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Marca:";
            // 
            // comboBoxVehiculos
            // 
            this.comboBoxVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehiculos.FormattingEnabled = true;
            this.comboBoxVehiculos.Location = new System.Drawing.Point(135, 9);
            this.comboBoxVehiculos.Name = "comboBoxVehiculos";
            this.comboBoxVehiculos.Size = new System.Drawing.Size(248, 21);
            this.comboBoxVehiculos.TabIndex = 7;
            this.comboBoxVehiculos.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehiculos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seleccione el Vehiculo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pasajeros Adultos:";
            // 
            // spinnerCantidadPasajerosAdultos
            // 
            this.spinnerCantidadPasajerosAdultos.Location = new System.Drawing.Point(567, 80);
            this.spinnerCantidadPasajerosAdultos.Name = "spinnerCantidadPasajerosAdultos";
            this.spinnerCantidadPasajerosAdultos.Size = new System.Drawing.Size(51, 20);
            this.spinnerCantidadPasajerosAdultos.TabIndex = 14;
            this.spinnerCantidadPasajerosAdultos.ValueChanged += new System.EventHandler(this.spinnerCantidadPasajerosAdultos_ValueChanged);
            this.spinnerCantidadPasajerosAdultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinnerCantidadPasajeros_KeyPress);
            // 
            // btnCofirmarReservacion1
            // 
            this.btnCofirmarReservacion1.Location = new System.Drawing.Point(657, 501);
            this.btnCofirmarReservacion1.Name = "btnCofirmarReservacion1";
            this.btnCofirmarReservacion1.Size = new System.Drawing.Size(139, 23);
            this.btnCofirmarReservacion1.TabIndex = 15;
            this.btnCofirmarReservacion1.Text = "Confirmar Reservacion";
            this.btnCofirmarReservacion1.UseVisualStyleBackColor = true;
            this.btnCofirmarReservacion1.Click += new System.EventHandler(this.btnCofirmarReservacion1_Click);
            // 
            // optTodosServicios
            // 
            this.optTodosServicios.AutoSize = true;
            this.optTodosServicios.Location = new System.Drawing.Point(274, 150);
            this.optTodosServicios.Name = "optTodosServicios";
            this.optTodosServicios.Size = new System.Drawing.Size(121, 17);
            this.optTodosServicios.TabIndex = 16;
            this.optTodosServicios.TabStop = true;
            this.optTodosServicios.Text = "Todos Los Servicios";
            this.optTodosServicios.UseVisualStyleBackColor = true;
            this.optTodosServicios.CheckedChanged += new System.EventHandler(this.optTodosServicios_CheckedChanged);
            // 
            // optHotel
            // 
            this.optHotel.AutoSize = true;
            this.optHotel.Location = new System.Drawing.Point(23, 150);
            this.optHotel.Name = "optHotel";
            this.optHotel.Size = new System.Drawing.Size(92, 17);
            this.optHotel.TabIndex = 17;
            this.optHotel.TabStop = true;
            this.optHotel.Text = "Adjuntar Hotel";
            this.optHotel.UseVisualStyleBackColor = true;
            this.optHotel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // optAutomovil
            // 
            this.optAutomovil.AutoSize = true;
            this.optAutomovil.Location = new System.Drawing.Point(138, 150);
            this.optAutomovil.Name = "optAutomovil";
            this.optAutomovil.Size = new System.Drawing.Size(113, 17);
            this.optAutomovil.TabIndex = 18;
            this.optAutomovil.TabStop = true;
            this.optAutomovil.Text = "Adjuntar Automovil";
            this.optAutomovil.UseVisualStyleBackColor = true;
            this.optAutomovil.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pasajeros Niños:";
            // 
            // spinnerCantidadPasajerosNiños
            // 
            this.spinnerCantidadPasajerosNiños.Location = new System.Drawing.Point(344, 85);
            this.spinnerCantidadPasajerosNiños.Name = "spinnerCantidadPasajerosNiños";
            this.spinnerCantidadPasajerosNiños.Size = new System.Drawing.Size(51, 20);
            this.spinnerCantidadPasajerosNiños.TabIndex = 20;
            this.spinnerCantidadPasajerosNiños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spinnerCantidadPasajerosNiños_KeyPress);
            // 
            // labelCantidadDias
            // 
            this.labelCantidadDias.AutoSize = true;
            this.labelCantidadDias.Location = new System.Drawing.Point(409, 62);
            this.labelCantidadDias.Name = "labelCantidadDias";
            this.labelCantidadDias.Size = new System.Drawing.Size(91, 13);
            this.labelCantidadDias.TabIndex = 21;
            this.labelCantidadDias.Text = "Cantidad de Dias ";
            // 
            // btnGuardarReservacionPais
            // 
            this.btnGuardarReservacionPais.Location = new System.Drawing.Point(499, 501);
            this.btnGuardarReservacionPais.Name = "btnGuardarReservacionPais";
            this.btnGuardarReservacionPais.Size = new System.Drawing.Size(130, 23);
            this.btnGuardarReservacionPais.TabIndex = 54;
            this.btnGuardarReservacionPais.Text = "Guardar Reservacion";
            this.btnGuardarReservacionPais.UseVisualStyleBackColor = true;
            // 
            // dtgVistaPreliminarVHA
            // 
            this.dtgVistaPreliminarVHA.AllowUserToAddRows = false;
            this.dtgVistaPreliminarVHA.AllowUserToDeleteRows = false;
            this.dtgVistaPreliminarVHA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVistaPreliminarVHA.Location = new System.Drawing.Point(398, 194);
            this.dtgVistaPreliminarVHA.Name = "dtgVistaPreliminarVHA";
            this.dtgVistaPreliminarVHA.ReadOnly = true;
            this.dtgVistaPreliminarVHA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVistaPreliminarVHA.Size = new System.Drawing.Size(541, 301);
            this.dtgVistaPreliminarVHA.TabIndex = 55;
            // 
            // optPrecioMayorHotel
            // 
            this.optPrecioMayorHotel.AutoSize = true;
            this.optPrecioMayorHotel.Location = new System.Drawing.Point(419, 150);
            this.optPrecioMayorHotel.Name = "optPrecioMayorHotel";
            this.optPrecioMayorHotel.Size = new System.Drawing.Size(87, 17);
            this.optPrecioMayorHotel.TabIndex = 56;
            this.optPrecioMayorHotel.TabStop = true;
            this.optPrecioMayorHotel.Text = "Precio Mayor";
            this.optPrecioMayorHotel.UseVisualStyleBackColor = true;
            this.optPrecioMayorHotel.CheckedChanged += new System.EventHandler(this.optPrecioMayorHotel_CheckedChanged);
            // 
            // btnVerListaPreeliminarHotelesVuelos
            // 
            this.btnVerListaPreeliminarHotelesVuelos.Location = new System.Drawing.Point(760, 21);
            this.btnVerListaPreeliminarHotelesVuelos.Name = "btnVerListaPreeliminarHotelesVuelos";
            this.btnVerListaPreeliminarHotelesVuelos.Size = new System.Drawing.Size(138, 23);
            this.btnVerListaPreeliminarHotelesVuelos.TabIndex = 57;
            this.btnVerListaPreeliminarHotelesVuelos.Text = "Vista Preliminar Vuelo";
            this.btnVerListaPreeliminarHotelesVuelos.UseVisualStyleBackColor = true;
            this.btnVerListaPreeliminarHotelesVuelos.Click += new System.EventHandler(this.btnVerListaPreeliminarHotelesVuelos_Click);
            // 
            // optPrecioMenorHotel
            // 
            this.optPrecioMenorHotel.AutoSize = true;
            this.optPrecioMenorHotel.Location = new System.Drawing.Point(541, 150);
            this.optPrecioMenorHotel.Name = "optPrecioMenorHotel";
            this.optPrecioMenorHotel.Size = new System.Drawing.Size(88, 17);
            this.optPrecioMenorHotel.TabIndex = 58;
            this.optPrecioMenorHotel.TabStop = true;
            this.optPrecioMenorHotel.Text = "Precio Menor";
            this.optPrecioMenorHotel.UseVisualStyleBackColor = true;
            this.optPrecioMenorHotel.CheckedChanged += new System.EventHandler(this.optPrecioMenorHotel_CheckedChanged);
            // 
            // optTiempoCorto
            // 
            this.optTiempoCorto.AutoSize = true;
            this.optTiempoCorto.Location = new System.Drawing.Point(671, 150);
            this.optTiempoCorto.Name = "optTiempoCorto";
            this.optTiempoCorto.Size = new System.Drawing.Size(109, 17);
            this.optTiempoCorto.TabIndex = 59;
            this.optTiempoCorto.TabStop = true;
            this.optTiempoCorto.Text = "Tiempo mas corto";
            this.optTiempoCorto.UseVisualStyleBackColor = true;
            // 
            // optMenosEscalas
            // 
            this.optMenosEscalas.AutoSize = true;
            this.optMenosEscalas.Location = new System.Drawing.Point(822, 150);
            this.optMenosEscalas.Name = "optMenosEscalas";
            this.optMenosEscalas.Size = new System.Drawing.Size(97, 17);
            this.optMenosEscalas.TabIndex = 60;
            this.optMenosEscalas.TabStop = true;
            this.optMenosEscalas.Text = "Menos Escalas";
            this.optMenosEscalas.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCantidadPasajeros
            // 
            this.btnGuardarCantidadPasajeros.Location = new System.Drawing.Point(362, 111);
            this.btnGuardarCantidadPasajeros.Name = "btnGuardarCantidadPasajeros";
            this.btnGuardarCantidadPasajeros.Size = new System.Drawing.Size(184, 23);
            this.btnGuardarCantidadPasajeros.TabIndex = 61;
            this.btnGuardarCantidadPasajeros.Text = "Guardar Cantidad Pasajeros";
            this.btnGuardarCantidadPasajeros.UseVisualStyleBackColor = true;
            this.btnGuardarCantidadPasajeros.Visible = false;
            this.btnGuardarCantidadPasajeros.Click += new System.EventHandler(this.btnGuardarCantidadPasajeros_Click);
            // 
            // Seccion_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 584);
            this.Controls.Add(this.btnGuardarCantidadPasajeros);
            this.Controls.Add(this.optMenosEscalas);
            this.Controls.Add(this.optTiempoCorto);
            this.Controls.Add(this.optPrecioMenorHotel);
            this.Controls.Add(this.btnVerListaPreeliminarHotelesVuelos);
            this.Controls.Add(this.optPrecioMayorHotel);
            this.Controls.Add(this.dtgVistaPreliminarVHA);
            this.Controls.Add(this.btnGuardarReservacionPais);
            this.Controls.Add(this.labelCantidadDias);
            this.Controls.Add(this.spinnerCantidadPasajerosNiños);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelAgregarHotel);
            this.Controls.Add(this.optAutomovil);
            this.Controls.Add(this.panelAgregarAutomovil);
            this.Controls.Add(this.optHotel);
            this.Controls.Add(this.optTodosServicios);
            this.Controls.Add(this.btnCofirmarReservacion1);
            this.Controls.Add(this.spinnerCantidadPasajerosAdultos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaFinalizacion);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.comboBoxPaisDestino);
            this.Controls.Add(this.comboBoxPaisOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Seccion_Vuelos";
            this.Text = "Seccion_Vuelos";
            this.Load += new System.EventHandler(this.Seccion_Vuelos_Load);
            this.panelAgregarHotel.ResumeLayout(false);
            this.panelAgregarHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCantidadHabitacionesHotel)).EndInit();
            this.panelAgregarAutomovil.ResumeLayout(false);
            this.panelAgregarAutomovil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCantidadPasajerosAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerCantidadPasajerosNiños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaPreliminarVHA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPaisOrigen;
        private System.Windows.Forms.ComboBox comboBoxPaisDestino;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFinalizacion;
        private System.Windows.Forms.Panel panelAgregarHotel;
        private System.Windows.Forms.Panel panelAgregarAutomovil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spinnerCantidadPasajerosAdultos;
        private System.Windows.Forms.Button btnCofirmarReservacion1;
        private System.Windows.Forms.ComboBox comboBoxHotelesPasDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton optTodosServicios;
        private System.Windows.Forms.RadioButton optHotel;
        private System.Windows.Forms.RadioButton optAutomovil;
        private System.Windows.Forms.ComboBox comboBoxVehiculos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown spinnerCantidadPasajerosNiños;
        private System.Windows.Forms.NumericUpDown spinnerCantidadHabitacionesHotel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPrecioVehiculo;
        private System.Windows.Forms.TextBox textBoxTipoVehiculo;
        private System.Windows.Forms.TextBox textBoxModeloVehiculo;
        private System.Windows.Forms.TextBox textBoxMarcaVehiculo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardarSeleccionAutomovil;
        private System.Windows.Forms.Button btnGuardarSeleccionHotel;
        private System.Windows.Forms.Label labelCantidadDias;
        private System.Windows.Forms.Button btnGuardarReservacionPais;
        private System.Windows.Forms.DataGridView dtgVistaPreliminarVHA;
        private System.Windows.Forms.RadioButton optPrecioMayorHotel;
        private System.Windows.Forms.Button btnVerListaPreeliminarHotelesVuelos;
        private System.Windows.Forms.RadioButton optPrecioMenorHotel;
        private System.Windows.Forms.RadioButton optTiempoCorto;
        private System.Windows.Forms.RadioButton optMenosEscalas;
        private System.Windows.Forms.Button btnGuardarCantidadPasajeros;
    }
}