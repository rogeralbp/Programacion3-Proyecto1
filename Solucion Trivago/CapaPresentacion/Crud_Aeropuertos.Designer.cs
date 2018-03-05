namespace CapaPresentacion
{
    partial class Crud_Aeropuertos
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
            this.tblAerpuertos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboLugares = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoAeropuertos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblAerpuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAerpuertos
            // 
            this.tblAerpuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAerpuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Identificadores,
            this.nombres,
            this.ComboLugares,
            this.Codigo});
            this.tblAerpuertos.Location = new System.Drawing.Point(5, 197);
            this.tblAerpuertos.Name = "tblAerpuertos";
            this.tblAerpuertos.Size = new System.Drawing.Size(748, 283);
            this.tblAerpuertos.TabIndex = 0;
            this.tblAerpuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAerpuertos_CellContentClick);
            this.tblAerpuertos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblAerpuertos_CellEndEdit);
            this.tblAerpuertos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tblAerpuertos_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Identificadores
            // 
            this.Identificadores.HeaderText = "Identificador";
            this.Identificadores.Name = "Identificadores";
            this.Identificadores.ReadOnly = true;
            // 
            // nombres
            // 
            this.nombres.HeaderText = "Nombre";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            // 
            // ComboLugares
            // 
            this.ComboLugares.AutoComplete = false;
            this.ComboLugares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ComboLugares.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ComboLugares.HeaderText = "Lugares";
            this.ComboLugares.Name = "ComboLugares";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Aeropuerto";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo Aeropuerto:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(563, 16);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(563, 62);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(563, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(563, 149);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(157, 18);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(339, 20);
            this.txtIdentificador.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtCodigoAeropuertos
            // 
            this.txtCodigoAeropuertos.Location = new System.Drawing.Point(157, 110);
            this.txtCodigoAeropuertos.Name = "txtCodigoAeropuertos";
            this.txtCodigoAeropuertos.Size = new System.Drawing.Size(339, 20);
            this.txtCodigoAeropuertos.TabIndex = 12;
            // 
            // Crud_Aeropuertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 492);
            this.Controls.Add(this.txtCodigoAeropuertos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblAerpuertos);
            this.Name = "Crud_Aeropuertos";
            this.Text = "Crud_Aeropuertos";
            this.Load += new System.EventHandler(this.Aeropuerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAerpuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblAerpuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoAeropuertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewComboBoxColumn ComboLugares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
    }
}