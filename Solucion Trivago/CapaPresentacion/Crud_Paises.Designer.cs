namespace CapaPresentacion
{
    partial class Crud_Paises
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlPaises = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlPaises.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar País";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar País";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControlPaises
            // 
            this.tabControlPaises.Controls.Add(this.tabPage1);
            this.tabControlPaises.Controls.Add(this.tabPage2);
            this.tabControlPaises.Controls.Add(this.tabPage3);
            this.tabControlPaises.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPaises.Location = new System.Drawing.Point(0, 1);
            this.tabControlPaises.Name = "tabControlPaises";
            this.tabControlPaises.SelectedIndex = 0;
            this.tabControlPaises.Size = new System.Drawing.Size(686, 449);
            this.tabControlPaises.TabIndex = 0;
            this.tabControlPaises.SelectedIndexChanged += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(678, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar País";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // Crud_Paises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 452);
            this.Controls.Add(this.tabControlPaises);
            this.Name = "Crud_Paises";
            this.Text = "Crud_Paises";
            this.tabControlPaises.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControlPaises;
        private System.Windows.Forms.TabPage tabPage3;
    }
}