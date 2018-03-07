namespace CapaPresentacion
{
    partial class Compra_Reserva_Vuelos
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
            this.dtgPreReservacionesVuelos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreReservacionesVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgPreReservacionesVuelos
            // 
            this.dtgPreReservacionesVuelos.AllowUserToAddRows = false;
            this.dtgPreReservacionesVuelos.AllowUserToDeleteRows = false;
            this.dtgPreReservacionesVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPreReservacionesVuelos.Location = new System.Drawing.Point(12, 29);
            this.dtgPreReservacionesVuelos.Name = "dtgPreReservacionesVuelos";
            this.dtgPreReservacionesVuelos.ReadOnly = true;
            this.dtgPreReservacionesVuelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPreReservacionesVuelos.Size = new System.Drawing.Size(696, 347);
            this.dtgPreReservacionesVuelos.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar Reserva";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ejercer Reserva";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Compra_Reserva_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 489);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgPreReservacionesVuelos);
            this.Controls.Add(this.button1);
            this.Name = "Compra_Reserva_Vuelos";
            this.Text = "Compra_Reserva_Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreReservacionesVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgPreReservacionesVuelos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}