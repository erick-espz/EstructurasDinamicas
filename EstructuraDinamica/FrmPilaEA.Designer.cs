namespace EstructuraDinamica
{
    partial class FrmPilaEA
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEdades = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblEdades2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(24, 38);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad:";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(75, 38);
            this.tbEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(131, 22);
            this.tbEdad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(211, 31);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblEdades
            // 
            this.lblEdades.AutoSize = true;
            this.lblEdades.Location = new System.Drawing.Point(24, 76);
            this.lblEdades.Name = "lblEdades";
            this.lblEdades.Size = new System.Drawing.Size(55, 16);
            this.lblEdades.TabIndex = 3;
            this.lblEdades.Text = "Edades";
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(296, 31);
            this.btnSacar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(107, 34);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(505, 26);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(111, 46);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // lblEdades2
            // 
            this.lblEdades2.AutoSize = true;
            this.lblEdades2.Location = new System.Drawing.Point(406, 76);
            this.lblEdades2.Name = "lblEdades2";
            this.lblEdades2.Size = new System.Drawing.Size(62, 16);
            this.lblEdades2.TabIndex = 6;
            this.lblEdades2.Text = "Edades2";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(409, 32);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(83, 35);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // FrmPilaEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 405);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblEdades2);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.lblEdades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.lblEdad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPilaEA";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEdades;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblEdades2;
        private System.Windows.Forms.Button btnMostrar;
    }
}

