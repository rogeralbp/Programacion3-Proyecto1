namespace CapaPresentacion
{
    partial class Crud_Tarifas_Vuelo
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
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxRuta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboNueaRuta = new System.Windows.Forms.ComboBox();
            this.txtPrecioNuevo = new System.Windows.Forms.TextBox();
            this.txtModificarRuta = new System.Windows.Forms.TextBox();
            this.txtModificarPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboIDVuelos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPrecioEliminar = new System.Windows.Forms.TextBox();
            this.txtRutaEliminar = new System.Windows.Forms.TextBox();
            this.comboboxIndenticadorEliminar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarTarifa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TablaVuelos = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtIdentificador);
            this.tabPage1.Controls.Add(this.txtPrecio);
            this.tabPage1.Controls.Add(this.comboBoxRuta);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Tarifa";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(265, 32);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(410, 22);
            this.txtIdentificador.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(265, 157);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(410, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // comboBoxRuta
            // 
            this.comboBoxRuta.FormattingEnabled = true;
            this.comboBoxRuta.Location = new System.Drawing.Point(265, 96);
            this.comboBoxRuta.Name = "comboBoxRuta";
            this.comboBoxRuta.Size = new System.Drawing.Size(410, 24);
            this.comboBoxRuta.TabIndex = 6;
            this.comboBoxRuta.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Tag = ".";
            this.label1.Text = "Identificador:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registar Tarifa Vuelo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboNueaRuta);
            this.tabPage2.Controls.Add(this.txtPrecioNuevo);
            this.tabPage2.Controls.Add(this.txtModificarRuta);
            this.tabPage2.Controls.Add(this.txtModificarPrecio);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboIDVuelos);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnGuardarCambios);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Tarifa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboNueaRuta
            // 
            this.comboNueaRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNueaRuta.FormattingEnabled = true;
            this.comboNueaRuta.Location = new System.Drawing.Point(209, 237);
            this.comboNueaRuta.Name = "comboNueaRuta";
            this.comboNueaRuta.Size = new System.Drawing.Size(281, 24);
            this.comboNueaRuta.TabIndex = 14;
            // 
            // txtPrecioNuevo
            // 
            this.txtPrecioNuevo.Location = new System.Drawing.Point(209, 314);
            this.txtPrecioNuevo.Name = "txtPrecioNuevo";
            this.txtPrecioNuevo.Size = new System.Drawing.Size(281, 22);
            this.txtPrecioNuevo.TabIndex = 13;
            // 
            // txtModificarRuta
            // 
            this.txtModificarRuta.Enabled = false;
            this.txtModificarRuta.Location = new System.Drawing.Point(209, 89);
            this.txtModificarRuta.Name = "txtModificarRuta";
            this.txtModificarRuta.Size = new System.Drawing.Size(281, 22);
            this.txtModificarRuta.TabIndex = 11;
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Enabled = false;
            this.txtModificarPrecio.Location = new System.Drawing.Point(209, 164);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Size = new System.Drawing.Size(281, 22);
            this.txtModificarPrecio.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Precio Nuevo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ruta Nueva:";
            // 
            // comboIDVuelos
            // 
            this.comboIDVuelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIDVuelos.FormattingEnabled = true;
            this.comboIDVuelos.Location = new System.Drawing.Point(209, 26);
            this.comboIDVuelos.Name = "comboIDVuelos";
            this.comboIDVuelos.Size = new System.Drawing.Size(281, 24);
            this.comboIDVuelos.TabIndex = 7;
            this.comboIDVuelos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Precio Actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ruta Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Tag = ".";
            this.label4.Text = "Identificador:";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(554, 34);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(209, 33);
            this.btnGuardarCambios.TabIndex = 3;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPrecioEliminar);
            this.tabPage3.Controls.Add(this.txtRutaEliminar);
            this.tabPage3.Controls.Add(this.comboboxIndenticadorEliminar);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnEliminarTarifa);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(799, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Tarifa";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtPrecioEliminar
            // 
            this.txtPrecioEliminar.Enabled = false;
            this.txtPrecioEliminar.Location = new System.Drawing.Point(284, 174);
            this.txtPrecioEliminar.Name = "txtPrecioEliminar";
            this.txtPrecioEliminar.Size = new System.Drawing.Size(372, 22);
            this.txtPrecioEliminar.TabIndex = 13;
            // 
            // txtRutaEliminar
            // 
            this.txtRutaEliminar.Enabled = false;
            this.txtRutaEliminar.Location = new System.Drawing.Point(284, 96);
            this.txtRutaEliminar.Name = "txtRutaEliminar";
            this.txtRutaEliminar.Size = new System.Drawing.Size(372, 22);
            this.txtRutaEliminar.TabIndex = 12;
            // 
            // comboboxIndenticadorEliminar
            // 
            this.comboboxIndenticadorEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxIndenticadorEliminar.FormattingEnabled = true;
            this.comboboxIndenticadorEliminar.Location = new System.Drawing.Point(284, 18);
            this.comboboxIndenticadorEliminar.Name = "comboboxIndenticadorEliminar";
            this.comboboxIndenticadorEliminar.Size = new System.Drawing.Size(372, 24);
            this.comboboxIndenticadorEliminar.TabIndex = 8;
            this.comboboxIndenticadorEliminar.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ruta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 5;
            this.label5.Tag = ".";
            this.label5.Text = "Identificador:";
            // 
            // btnEliminarTarifa
            // 
            this.btnEliminarTarifa.Enabled = false;
            this.btnEliminarTarifa.Location = new System.Drawing.Point(321, 313);
            this.btnEliminarTarifa.Name = "btnEliminarTarifa";
            this.btnEliminarTarifa.Size = new System.Drawing.Size(110, 38);
            this.btnEliminarTarifa.TabIndex = 4;
            this.btnEliminarTarifa.Text = "Eliminar";
            this.btnEliminarTarifa.UseVisualStyleBackColor = true;
            this.btnEliminarTarifa.Click += new System.EventHandler(this.btnEliminarTarifa_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TablaVuelos);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(799, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar Tarifas Vuelos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TablaVuelos
            // 
            this.TablaVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVuelos.Location = new System.Drawing.Point(8, 127);
            this.TablaVuelos.Name = "TablaVuelos";
            this.TablaVuelos.Size = new System.Drawing.Size(785, 313);
            this.TablaVuelos.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(639, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(115, 43);
            this.button7.TabIndex = 0;
            this.button7.Text = "Regresar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Crud_Tarifas_Vuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Crud_Tarifas_Vuelo";
            this.Text = "Crud_Tarifas_Vuelo";
            this.Load += new System.EventHandler(this.Cargar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox comboBoxRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboIDVuelos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarTarifa;
        private System.Windows.Forms.TextBox txtPrecioNuevo;
        private System.Windows.Forms.TextBox txtModificarRuta;
        private System.Windows.Forms.TextBox txtModificarPrecio;
        private System.Windows.Forms.TextBox txtPrecioEliminar;
        private System.Windows.Forms.TextBox txtRutaEliminar;
        private System.Windows.Forms.ComboBox comboboxIndenticadorEliminar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView TablaVuelos;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboNueaRuta;
    }
}