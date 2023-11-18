namespace Distribuciòn
{
    partial class InicioAdministradorDeIngresos
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
            this.btnIngresarChoferes = new System.Windows.Forms.Button();
            this.btnBuscarChoferes = new System.Windows.Forms.Button();
            this.btnIngresarPaquetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarChoferes
            // 
            this.btnIngresarChoferes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarChoferes.Location = new System.Drawing.Point(43, 53);
            this.btnIngresarChoferes.Name = "btnIngresarChoferes";
            this.btnIngresarChoferes.Size = new System.Drawing.Size(147, 103);
            this.btnIngresarChoferes.TabIndex = 0;
            this.btnIngresarChoferes.Text = "Ingresar Choferes";
            this.btnIngresarChoferes.UseVisualStyleBackColor = true;
            this.btnIngresarChoferes.Click += new System.EventHandler(this.btnIngresarChoferes_Click);
            // 
            // btnBuscarChoferes
            // 
            this.btnBuscarChoferes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarChoferes.Location = new System.Drawing.Point(307, 53);
            this.btnBuscarChoferes.Name = "btnBuscarChoferes";
            this.btnBuscarChoferes.Size = new System.Drawing.Size(147, 103);
            this.btnBuscarChoferes.TabIndex = 1;
            this.btnBuscarChoferes.Text = "Buscar Choferes";
            this.btnBuscarChoferes.UseVisualStyleBackColor = true;
            this.btnBuscarChoferes.Click += new System.EventHandler(this.btnBuscarChoferes_Click);
            // 
            // btnIngresarPaquetes
            // 
            this.btnIngresarPaquetes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPaquetes.Location = new System.Drawing.Point(43, 278);
            this.btnIngresarPaquetes.Name = "btnIngresarPaquetes";
            this.btnIngresarPaquetes.Size = new System.Drawing.Size(147, 103);
            this.btnIngresarPaquetes.TabIndex = 2;
            this.btnIngresarPaquetes.Text = "Ingresar Paquetes";
            this.btnIngresarPaquetes.UseVisualStyleBackColor = true;
            this.btnIngresarPaquetes.Click += new System.EventHandler(this.btnIngresarPaquetes_Click);
            // 
            // InicioAdministradorDeIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarPaquetes);
            this.Controls.Add(this.btnBuscarChoferes);
            this.Controls.Add(this.btnIngresarChoferes);
            this.Name = "InicioAdministradorDeIngresos";
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarChoferes;
        private System.Windows.Forms.Button btnBuscarChoferes;
        private System.Windows.Forms.Button btnIngresarPaquetes;
    }
}