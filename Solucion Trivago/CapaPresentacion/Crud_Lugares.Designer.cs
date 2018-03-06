namespace CapaPresentacion
{
    partial class Crud_Lugares
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
            this.comboPaisRegistrar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtIDLugarNuevo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPaisActualEliminar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreActualEliminar = new System.Windows.Forms.TextBox();
            this.comboIdentificadorLugaresEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminarLugar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboNuevoPais = new System.Windows.Forms.ComboBox();
            this.txtPaisActual = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNombreLugarActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreLugarActual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLugarModificar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboPaisRegistrar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtNombres);
            this.tabPage1.Controls.Add(this.txtIDLugarNuevo);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Lugar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboPaisRegistrar
            // 
            this.comboPaisRegistrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaisRegistrar.FormattingEnabled = true;
            this.comboPaisRegistrar.Location = new System.Drawing.Point(219, 153);
            this.comboPaisRegistrar.Name = "comboPaisRegistrar";
            this.comboPaisRegistrar.Size = new System.Drawing.Size(445, 24);
            this.comboPaisRegistrar.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Pais:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(219, 105);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(445, 22);
            this.txtNombres.TabIndex = 5;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtIDLugarNuevo
            // 
            this.txtIDLugarNuevo.Location = new System.Drawing.Point(219, 33);
            this.txtIDLugarNuevo.Name = "txtIDLugarNuevo";
            this.txtIDLugarNuevo.Size = new System.Drawing.Size(445, 22);
            this.txtIDLugarNuevo.TabIndex = 4;
            this.txtIDLugarNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDLugarNuevo_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrar Lugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPaisActualEliminar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtNombreActualEliminar);
            this.tabPage2.Controls.Add(this.comboIdentificadorLugaresEliminar);
            this.tabPage2.Controls.Add(this.btnEliminarLugar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar Lugar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtPaisActualEliminar
            // 
            this.txtPaisActualEliminar.Enabled = false;
            this.txtPaisActualEliminar.Location = new System.Drawing.Point(258, 94);
            this.txtPaisActualEliminar.Name = "txtPaisActualEliminar";
            this.txtPaisActualEliminar.Size = new System.Drawing.Size(384, 22);
            this.txtPaisActualEliminar.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pais:";
            // 
            // txtNombreActualEliminar
            // 
            this.txtNombreActualEliminar.Enabled = false;
            this.txtNombreActualEliminar.Location = new System.Drawing.Point(258, 148);
            this.txtNombreActualEliminar.Name = "txtNombreActualEliminar";
            this.txtNombreActualEliminar.Size = new System.Drawing.Size(384, 22);
            this.txtNombreActualEliminar.TabIndex = 11;
            // 
            // comboIdentificadorLugaresEliminar
            // 
            this.comboIdentificadorLugaresEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIdentificadorLugaresEliminar.FormattingEnabled = true;
            this.comboIdentificadorLugaresEliminar.Location = new System.Drawing.Point(258, 35);
            this.comboIdentificadorLugaresEliminar.Name = "comboIdentificadorLugaresEliminar";
            this.comboIdentificadorLugaresEliminar.Size = new System.Drawing.Size(384, 24);
            this.comboIdentificadorLugaresEliminar.TabIndex = 10;
            this.comboIdentificadorLugaresEliminar.DropDown += new System.EventHandler(this.comboIdentificador_SelectionChangeCommitted);
            this.comboIdentificadorLugaresEliminar.SelectedIndexChanged += new System.EventHandler(this.comboIdentificador_SelectedIndexChanged);
            this.comboIdentificadorLugaresEliminar.SelectionChangeCommitted += new System.EventHandler(this.comboIdentificador_SelectionChangeCommitted);
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.Location = new System.Drawing.Point(239, 277);
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.Size = new System.Drawing.Size(226, 37);
            this.btnEliminarLugar.TabIndex = 9;
            this.btnEliminarLugar.Text = "Eliminar Lugar";
            this.btnEliminarLugar.UseVisualStyleBackColor = true;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identificador:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(594, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboNuevoPais);
            this.tabPage3.Controls.Add(this.txtPaisActual);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.txtNombreLugarActualizar);
            this.tabPage3.Controls.Add(this.txtNombreLugarActual);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBoxLugarModificar);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(744, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar Lugar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboNuevoPais
            // 
            this.comboNuevoPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNuevoPais.FormattingEnabled = true;
            this.comboNuevoPais.Location = new System.Drawing.Point(269, 204);
            this.comboNuevoPais.Name = "comboNuevoPais";
            this.comboNuevoPais.Size = new System.Drawing.Size(375, 24);
            this.comboNuevoPais.TabIndex = 17;
            // 
            // txtPaisActual
            // 
            this.txtPaisActual.Enabled = false;
            this.txtPaisActual.Location = new System.Drawing.Point(269, 148);
            this.txtPaisActual.Name = "txtPaisActual";
            this.txtPaisActual.Size = new System.Drawing.Size(375, 22);
            this.txtPaisActual.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "NuevoPais:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Pais Actual:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Guardar Cambios";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtNombreLugarActualizar
            // 
            this.txtNombreLugarActualizar.Location = new System.Drawing.Point(269, 262);
            this.txtNombreLugarActualizar.Name = "txtNombreLugarActualizar";
            this.txtNombreLugarActualizar.Size = new System.Drawing.Size(375, 22);
            this.txtNombreLugarActualizar.TabIndex = 12;
            this.txtNombreLugarActualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreLugarActualizar_KeyPress);
            // 
            // txtNombreLugarActual
            // 
            this.txtNombreLugarActual.Enabled = false;
            this.txtNombreLugarActual.Location = new System.Drawing.Point(269, 98);
            this.txtNombreLugarActual.Name = "txtNombreLugarActual";
            this.txtNombreLugarActual.Size = new System.Drawing.Size(375, 22);
            this.txtNombreLugarActual.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre Actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nuevo Nombre:";
            // 
            // comboBoxLugarModificar
            // 
            this.comboBoxLugarModificar.AllowDrop = true;
            this.comboBoxLugarModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLugarModificar.FormattingEnabled = true;
            this.comboBoxLugarModificar.Location = new System.Drawing.Point(269, 41);
            this.comboBoxLugarModificar.Name = "comboBoxLugarModificar";
            this.comboBoxLugarModificar.Size = new System.Drawing.Size(375, 24);
            this.comboBoxLugarModificar.TabIndex = 8;
            this.comboBoxLugarModificar.SelectedIndexChanged += new System.EventHandler(this.comboBoxLugar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccionar Lugar:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(744, 444);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar Lugares";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.Crud_Lugares_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(32, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(582, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 37);
            this.button7.TabIndex = 0;
            this.button7.Text = "Regresar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Crud_Lugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "Crud_Lugares";
            this.Text = "Crud_Lugares";
            this.Load += new System.EventHandler(this.Crud_Lugares_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtIDLugarNuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminarLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreLugarActualizar;
        private System.Windows.Forms.TextBox txtNombreLugarActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLugarModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboIdentificadorLugaresEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreActualEliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboPaisRegistrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaisActualEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboNuevoPais;
        private System.Windows.Forms.TextBox txtPaisActual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}