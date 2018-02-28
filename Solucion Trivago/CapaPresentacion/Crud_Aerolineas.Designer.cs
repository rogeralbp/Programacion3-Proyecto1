namespace CapaPresentacion
{
    partial class Crud_Aerolineas
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
            this.txtNNuevo = new System.Windows.Forms.TextBox();
            this.txtIDNuevo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtNuevoNombreModificar = new System.Windows.Forms.TextBox();
            this.txtNombreActual = new System.Windows.Forms.TextBox();
            this.txtIDActual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxIDSA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarAerolinea = new System.Windows.Forms.Button();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDEliminar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboIDSElmiminar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 489);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNNuevo);
            this.tabPage1.Controls.Add(this.txtIDNuevo);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Aerolínea";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNNuevo
            // 
            this.txtNNuevo.Location = new System.Drawing.Point(182, 106);
            this.txtNNuevo.Name = "txtNNuevo";
            this.txtNNuevo.Size = new System.Drawing.Size(402, 20);
            this.txtNNuevo.TabIndex = 5;
            // 
            // txtIDNuevo
            // 
            this.txtIDNuevo.Location = new System.Drawing.Point(182, 33);
            this.txtIDNuevo.Name = "txtIDNuevo";
            this.txtIDNuevo.Size = new System.Drawing.Size(402, 20);
            this.txtIDNuevo.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Registrar Aerolinea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarCambios);
            this.tabPage2.Controls.Add(this.txtNuevoNombreModificar);
            this.tabPage2.Controls.Add(this.txtNombreActual);
            this.tabPage2.Controls.Add(this.txtIDActual);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxIDSA);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Aerolínea";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Location = new System.Drawing.Point(241, 339);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(213, 35);
            this.btnGuardarCambios.TabIndex = 12;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // txtNuevoNombreModificar
            // 
            this.txtNuevoNombreModificar.Enabled = false;
            this.txtNuevoNombreModificar.Location = new System.Drawing.Point(205, 233);
            this.txtNuevoNombreModificar.Name = "txtNuevoNombreModificar";
            this.txtNuevoNombreModificar.Size = new System.Drawing.Size(428, 26);
            this.txtNuevoNombreModificar.TabIndex = 11;
            // 
            // txtNombreActual
            // 
            this.txtNombreActual.Enabled = false;
            this.txtNombreActual.Location = new System.Drawing.Point(205, 159);
            this.txtNombreActual.Name = "txtNombreActual";
            this.txtNombreActual.Size = new System.Drawing.Size(428, 26);
            this.txtNombreActual.TabIndex = 10;
            // 
            // txtIDActual
            // 
            this.txtIDActual.Enabled = false;
            this.txtIDActual.Location = new System.Drawing.Point(205, 99);
            this.txtIDActual.Name = "txtIDActual";
            this.txtIDActual.Size = new System.Drawing.Size(428, 26);
            this.txtIDActual.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Identificador Actual:";
            // 
            // comboBoxIDSA
            // 
            this.comboBoxIDSA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDSA.FormattingEnabled = true;
            this.comboBoxIDSA.Location = new System.Drawing.Point(205, 29);
            this.comboBoxIDSA.Name = "comboBoxIDSA";
            this.comboBoxIDSA.Size = new System.Drawing.Size(428, 28);
            this.comboBoxIDSA.TabIndex = 7;
            this.comboBoxIDSA.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nuevo Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre Actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificador:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(552, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminarAerolinea);
            this.tabPage3.Controls.Add(this.txtNombreEliminar);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtIDEliminar);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.comboIDSElmiminar);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(704, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Aerolínea";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAerolinea
            // 
            this.btnEliminarAerolinea.Enabled = false;
            this.btnEliminarAerolinea.Location = new System.Drawing.Point(240, 257);
            this.btnEliminarAerolinea.Name = "btnEliminarAerolinea";
            this.btnEliminarAerolinea.Size = new System.Drawing.Size(256, 38);
            this.btnEliminarAerolinea.TabIndex = 13;
            this.btnEliminarAerolinea.Text = "Eliminar Aerolinea";
            this.btnEliminarAerolinea.UseVisualStyleBackColor = true;
            this.btnEliminarAerolinea.Click += new System.EventHandler(this.btnEliminarAerolinea_Click);
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Enabled = false;
            this.txtNombreEliminar.Location = new System.Drawing.Point(221, 187);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(392, 22);
            this.txtNombreEliminar.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre Actual:";
            // 
            // txtIDEliminar
            // 
            this.txtIDEliminar.Enabled = false;
            this.txtIDEliminar.Location = new System.Drawing.Point(221, 117);
            this.txtIDEliminar.Name = "txtIDEliminar";
            this.txtIDEliminar.Size = new System.Drawing.Size(392, 22);
            this.txtIDEliminar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Identificador Actual:";
            // 
            // comboIDSElmiminar
            // 
            this.comboIDSElmiminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIDSElmiminar.FormattingEnabled = true;
            this.comboIDSElmiminar.Location = new System.Drawing.Point(221, 37);
            this.comboIDSElmiminar.Name = "comboIDSElmiminar";
            this.comboIDSElmiminar.Size = new System.Drawing.Size(392, 24);
            this.comboIDSElmiminar.TabIndex = 8;
            this.comboIDSElmiminar.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Identificador:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(704, 460);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Consultar Aerolineas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(566, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 38);
            this.button7.TabIndex = 1;
            this.button7.Text = "Regresar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // Crud_Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "Crud_Aerolineas";
            this.Text = "Crud_Aerolineas";
            this.Load += new System.EventHandler(this.Crud_Aerolineas_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNNuevo;
        private System.Windows.Forms.TextBox txtIDNuevo;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtNuevoNombreModificar;
        private System.Windows.Forms.TextBox txtNombreActual;
        private System.Windows.Forms.TextBox txtIDActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxIDSA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarAerolinea;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboIDSElmiminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}