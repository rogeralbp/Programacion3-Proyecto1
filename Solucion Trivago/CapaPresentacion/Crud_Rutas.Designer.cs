namespace CapaPresentacion
{
    partial class Crud_Rutas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboPaisDestino = new System.Windows.Forms.ComboBox();
            this.comboPaisOrigen = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textNuevoDuracion = new System.Windows.Forms.TextBox();
            this.textNuevoDestino = new System.Windows.Forms.TextBox();
            this.textNuevoOrigen = new System.Windows.Forms.TextBox();
            this.textDuracion = new System.Windows.Forms.TextBox();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboboxIDModificar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarRuta = new System.Windows.Forms.Button();
            this.txtDestinoActual = new System.Windows.Forms.TextBox();
            this.txtDuracionActual = new System.Windows.Forms.TextBox();
            this.txtOrigenActual = new System.Windows.Forms.TextBox();
            this.comboIDRutas = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TablaRutas = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboPaisDestino);
            this.tabPage1.Controls.Add(this.comboPaisOrigen);
            this.tabPage1.Controls.Add(this.txtDuracion);
            this.tabPage1.Controls.Add(this.txtIdentificador);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Ruta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Registar Ruta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboPaisDestino
            // 
            this.comboPaisDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaisDestino.FormattingEnabled = true;
            this.comboPaisDestino.Location = new System.Drawing.Point(261, 144);
            this.comboPaisDestino.Name = "comboPaisDestino";
            this.comboPaisDestino.Size = new System.Drawing.Size(378, 24);
            this.comboPaisDestino.TabIndex = 7;
            // 
            // comboPaisOrigen
            // 
            this.comboPaisOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaisOrigen.FormattingEnabled = true;
            this.comboPaisOrigen.Location = new System.Drawing.Point(261, 74);
            this.comboPaisOrigen.Name = "comboPaisOrigen";
            this.comboPaisOrigen.Size = new System.Drawing.Size(378, 24);
            this.comboPaisOrigen.TabIndex = 6;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(261, 228);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(378, 22);
            this.txtDuracion.TabIndex = 5;
            this.txtDuracion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(261, 11);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(378, 22);
            this.txtIdentificador.TabIndex = 4;
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duracion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.textNuevoDuracion);
            this.tabPage2.Controls.Add(this.textNuevoDestino);
            this.tabPage2.Controls.Add(this.textNuevoOrigen);
            this.tabPage2.Controls.Add(this.textDuracion);
            this.tabPage2.Controls.Add(this.textDestino);
            this.tabPage2.Controls.Add(this.textOrigen);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboboxIDModificar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Rutas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(631, 38);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 35);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textNuevoDuracion
            // 
            this.textNuevoDuracion.Location = new System.Drawing.Point(239, 357);
            this.textNuevoDuracion.Name = "textNuevoDuracion";
            this.textNuevoDuracion.Size = new System.Drawing.Size(378, 22);
            this.textNuevoDuracion.TabIndex = 24;
            // 
            // textNuevoDestino
            // 
            this.textNuevoDestino.Location = new System.Drawing.Point(239, 295);
            this.textNuevoDestino.Name = "textNuevoDestino";
            this.textNuevoDestino.Size = new System.Drawing.Size(378, 22);
            this.textNuevoDestino.TabIndex = 23;
            this.textNuevoDestino.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textNuevoOrigen
            // 
            this.textNuevoOrigen.Location = new System.Drawing.Point(239, 238);
            this.textNuevoOrigen.Name = "textNuevoOrigen";
            this.textNuevoOrigen.Size = new System.Drawing.Size(378, 22);
            this.textNuevoOrigen.TabIndex = 22;
            // 
            // textDuracion
            // 
            this.textDuracion.Enabled = false;
            this.textDuracion.Location = new System.Drawing.Point(239, 185);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(378, 22);
            this.textDuracion.TabIndex = 21;
            // 
            // textDestino
            // 
            this.textDestino.Enabled = false;
            this.textDestino.Location = new System.Drawing.Point(239, 133);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(378, 22);
            this.textDestino.TabIndex = 20;
            // 
            // textOrigen
            // 
            this.textOrigen.Enabled = false;
            this.textOrigen.Location = new System.Drawing.Point(239, 69);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(378, 22);
            this.textOrigen.TabIndex = 19;
            this.textOrigen.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nueva Duracion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nuevo Pais Destino:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nuevo Pais Origen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Duracion Actual:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pais Destino Actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pais Origen Actual:";
            // 
            // comboboxIDModificar
            // 
            this.comboboxIDModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxIDModificar.FormattingEnabled = true;
            this.comboboxIDModificar.Location = new System.Drawing.Point(239, 11);
            this.comboboxIDModificar.Name = "comboboxIDModificar";
            this.comboboxIDModificar.Size = new System.Drawing.Size(378, 24);
            this.comboboxIDModificar.TabIndex = 12;
            this.comboboxIDModificar.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Identificador Ruta:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminarRuta);
            this.tabPage3.Controls.Add(this.txtDestinoActual);
            this.tabPage3.Controls.Add(this.txtDuracionActual);
            this.tabPage3.Controls.Add(this.txtOrigenActual);
            this.tabPage3.Controls.Add(this.comboIDRutas);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(785, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Rutas";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnEliminarRuta
            // 
            this.btnEliminarRuta.Enabled = false;
            this.btnEliminarRuta.Location = new System.Drawing.Point(289, 307);
            this.btnEliminarRuta.Name = "btnEliminarRuta";
            this.btnEliminarRuta.Size = new System.Drawing.Size(163, 47);
            this.btnEliminarRuta.TabIndex = 23;
            this.btnEliminarRuta.Text = "Eliminar Ruta";
            this.btnEliminarRuta.UseVisualStyleBackColor = true;
            this.btnEliminarRuta.Click += new System.EventHandler(this.btnEliminarRuta_Click);
            // 
            // txtDestinoActual
            // 
            this.txtDestinoActual.Enabled = false;
            this.txtDestinoActual.Location = new System.Drawing.Point(234, 134);
            this.txtDestinoActual.Name = "txtDestinoActual";
            this.txtDestinoActual.Size = new System.Drawing.Size(378, 22);
            this.txtDestinoActual.TabIndex = 22;
            // 
            // txtDuracionActual
            // 
            this.txtDuracionActual.Enabled = false;
            this.txtDuracionActual.Location = new System.Drawing.Point(234, 202);
            this.txtDuracionActual.Name = "txtDuracionActual";
            this.txtDuracionActual.Size = new System.Drawing.Size(378, 22);
            this.txtDuracionActual.TabIndex = 21;
            // 
            // txtOrigenActual
            // 
            this.txtOrigenActual.Enabled = false;
            this.txtOrigenActual.Location = new System.Drawing.Point(234, 77);
            this.txtOrigenActual.Name = "txtOrigenActual";
            this.txtOrigenActual.Size = new System.Drawing.Size(378, 22);
            this.txtOrigenActual.TabIndex = 20;
            // 
            // comboIDRutas
            // 
            this.comboIDRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIDRutas.FormattingEnabled = true;
            this.comboIDRutas.Location = new System.Drawing.Point(234, 10);
            this.comboIDRutas.Name = "comboIDRutas";
            this.comboIDRutas.Size = new System.Drawing.Size(378, 24);
            this.comboIDRutas.TabIndex = 17;
            this.comboIDRutas.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Duracion Actual:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Pais Destino Actual:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Pais Origen Actual:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Identificador Ruta:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TablaRutas);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(785, 464);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar Rutas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TablaRutas
            // 
            this.TablaRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRutas.Enabled = false;
            this.TablaRutas.Location = new System.Drawing.Point(17, 143);
            this.TablaRutas.Name = "TablaRutas";
            this.TablaRutas.Size = new System.Drawing.Size(764, 302);
            this.TablaRutas.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(574, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 41);
            this.button7.TabIndex = 0;
            this.button7.Text = "Regresar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Crud_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "Crud_Rutas";
            this.Text = "Crud_Rutas";
            this.Load += new System.EventHandler(this.Crud_Rutas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboPaisDestino;
        private System.Windows.Forms.ComboBox comboPaisOrigen;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboboxIDModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.TextBox textNuevoDuracion;
        private System.Windows.Forms.TextBox textNuevoDestino;
        private System.Windows.Forms.TextBox textNuevoOrigen;
        private System.Windows.Forms.TextBox textDuracion;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminarRuta;
        private System.Windows.Forms.TextBox txtDestinoActual;
        private System.Windows.Forms.TextBox txtDuracionActual;
        private System.Windows.Forms.TextBox txtOrigenActual;
        private System.Windows.Forms.ComboBox comboIDRutas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView TablaRutas;
        private System.Windows.Forms.Button button7;
    }
}