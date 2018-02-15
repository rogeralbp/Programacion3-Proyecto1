namespace CapaPresentacion
{
    partial class Menu_Principal_Administrador
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
            this.btnCrud_Vehiculos = new System.Windows.Forms.Button();
            this.btnCrud_Aeropuerto = new System.Windows.Forms.Button();
            this.btnCrud_Hoteles = new System.Windows.Forms.Button();
            this.btnCrud_Paises = new System.Windows.Forms.Button();
            this.btnCrudLugares = new System.Windows.Forms.Button();
            this.btnCrudRutas = new System.Windows.Forms.Button();
            this.btnCrud_TarifasH = new System.Windows.Forms.Button();
            this.btnCrudTarifasV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrud_Vehiculos
            // 
            this.btnCrud_Vehiculos.Location = new System.Drawing.Point(214, 92);
            this.btnCrud_Vehiculos.Name = "btnCrud_Vehiculos";
            this.btnCrud_Vehiculos.Size = new System.Drawing.Size(148, 23);
            this.btnCrud_Vehiculos.TabIndex = 0;
            this.btnCrud_Vehiculos.Text = "Crud Vehiculos";
            this.btnCrud_Vehiculos.UseVisualStyleBackColor = true;
            this.btnCrud_Vehiculos.Click += new System.EventHandler(this.btnCrud_Vehiculos_Click);
            // 
            // btnCrud_Aeropuerto
            // 
            this.btnCrud_Aeropuerto.Location = new System.Drawing.Point(214, 144);
            this.btnCrud_Aeropuerto.Name = "btnCrud_Aeropuerto";
            this.btnCrud_Aeropuerto.Size = new System.Drawing.Size(148, 23);
            this.btnCrud_Aeropuerto.TabIndex = 1;
            this.btnCrud_Aeropuerto.Text = "Crud Aeropuerto";
            this.btnCrud_Aeropuerto.UseVisualStyleBackColor = true;
            this.btnCrud_Aeropuerto.Click += new System.EventHandler(this.btnCrud_Aeropuerto_Click);
            // 
            // btnCrud_Hoteles
            // 
            this.btnCrud_Hoteles.Location = new System.Drawing.Point(214, 207);
            this.btnCrud_Hoteles.Name = "btnCrud_Hoteles";
            this.btnCrud_Hoteles.Size = new System.Drawing.Size(148, 23);
            this.btnCrud_Hoteles.TabIndex = 2;
            this.btnCrud_Hoteles.Text = "Crud Hoteles";
            this.btnCrud_Hoteles.UseVisualStyleBackColor = true;
            this.btnCrud_Hoteles.Click += new System.EventHandler(this.btnCrud_Hoteles_Click);
            // 
            // btnCrud_Paises
            // 
            this.btnCrud_Paises.Location = new System.Drawing.Point(214, 260);
            this.btnCrud_Paises.Name = "btnCrud_Paises";
            this.btnCrud_Paises.Size = new System.Drawing.Size(148, 23);
            this.btnCrud_Paises.TabIndex = 3;
            this.btnCrud_Paises.Text = "Crud Países";
            this.btnCrud_Paises.UseVisualStyleBackColor = true;
            this.btnCrud_Paises.Click += new System.EventHandler(this.btnCrud_Paises_Click);
            // 
            // btnCrudLugares
            // 
            this.btnCrudLugares.Location = new System.Drawing.Point(387, 207);
            this.btnCrudLugares.Name = "btnCrudLugares";
            this.btnCrudLugares.Size = new System.Drawing.Size(148, 23);
            this.btnCrudLugares.TabIndex = 4;
            this.btnCrudLugares.Text = "Crud Lugares";
            this.btnCrudLugares.UseVisualStyleBackColor = true;
            this.btnCrudLugares.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCrudRutas
            // 
            this.btnCrudRutas.Location = new System.Drawing.Point(387, 260);
            this.btnCrudRutas.Name = "btnCrudRutas";
            this.btnCrudRutas.Size = new System.Drawing.Size(148, 23);
            this.btnCrudRutas.TabIndex = 6;
            this.btnCrudRutas.Text = "Crud Rutas";
            this.btnCrudRutas.UseVisualStyleBackColor = true;
            this.btnCrudRutas.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCrud_TarifasH
            // 
            this.btnCrud_TarifasH.Location = new System.Drawing.Point(387, 144);
            this.btnCrud_TarifasH.Name = "btnCrud_TarifasH";
            this.btnCrud_TarifasH.Size = new System.Drawing.Size(148, 23);
            this.btnCrud_TarifasH.TabIndex = 7;
            this.btnCrud_TarifasH.Text = "Crud Tarifas de Hotel";
            this.btnCrud_TarifasH.UseVisualStyleBackColor = true;
            this.btnCrud_TarifasH.Click += new System.EventHandler(this.btnCrud_TarifasH_Click);
            // 
            // btnCrudTarifasV
            // 
            this.btnCrudTarifasV.Location = new System.Drawing.Point(387, 92);
            this.btnCrudTarifasV.Name = "btnCrudTarifasV";
            this.btnCrudTarifasV.Size = new System.Drawing.Size(148, 23);
            this.btnCrudTarifasV.TabIndex = 8;
            this.btnCrudTarifasV.Text = "Crud de Tarifas de Vuelo";
            this.btnCrudTarifasV.UseVisualStyleBackColor = true;
            this.btnCrudTarifasV.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Principal_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrudTarifasV);
            this.Controls.Add(this.btnCrud_TarifasH);
            this.Controls.Add(this.btnCrudRutas);
            this.Controls.Add(this.btnCrudLugares);
            this.Controls.Add(this.btnCrud_Paises);
            this.Controls.Add(this.btnCrud_Hoteles);
            this.Controls.Add(this.btnCrud_Aeropuerto);
            this.Controls.Add(this.btnCrud_Vehiculos);
            this.Name = "Menu_Principal_Administrador";
            this.Text = "Menu_Principal_Administrador";
            this.Load += new System.EventHandler(this.Menu_Principal_Administrador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrud_Vehiculos;
        private System.Windows.Forms.Button btnCrud_Aeropuerto;
        private System.Windows.Forms.Button btnCrud_Hoteles;
        private System.Windows.Forms.Button btnCrud_Paises;
        private System.Windows.Forms.Button btnCrudLugares;
        private System.Windows.Forms.Button btnCrudRutas;
        private System.Windows.Forms.Button btnCrud_TarifasH;
        private System.Windows.Forms.Button btnCrudTarifasV;
        private System.Windows.Forms.Button button1;
    }
}