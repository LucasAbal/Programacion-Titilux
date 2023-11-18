namespace Distribuciòn
{
    partial class plantillaLote
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
            this.lblLote = new System.Windows.Forms.Label();
            this.lisPaquete = new System.Windows.Forms.ListBox();
            this.lisLote = new System.Windows.Forms.ListBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblListaPaquetes = new System.Windows.Forms.Label();
            this.lblListLote = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(12, 9);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(45, 18);
            this.lblLote.TabIndex = 0;
            this.lblLote.Text = "Lote :";
            // 
            // lisPaquete
            // 
            this.lisPaquete.FormattingEnabled = true;
            this.lisPaquete.Location = new System.Drawing.Point(15, 103);
            this.lisPaquete.Name = "lisPaquete";
            this.lisPaquete.Size = new System.Drawing.Size(258, 316);
            this.lisPaquete.TabIndex = 1;
            this.lisPaquete.DoubleClick += new System.EventHandler(this.lisPaquete_DoubleClick);
            // 
            // lisLote
            // 
            this.lisLote.FormattingEnabled = true;
            this.lisLote.Location = new System.Drawing.Point(478, 103);
            this.lisLote.Name = "lisLote";
            this.lisLote.Size = new System.Drawing.Size(258, 316);
            this.lisLote.TabIndex = 2;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(169, 9);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(82, 18);
            this.lblCapacidad.TabIndex = 3;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(409, 9);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(78, 18);
            this.lblUbicacion.TabIndex = 4;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // lblListaPaquetes
            // 
            this.lblListaPaquetes.AutoSize = true;
            this.lblListaPaquetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPaquetes.Location = new System.Drawing.Point(22, 74);
            this.lblListaPaquetes.Name = "lblListaPaquetes";
            this.lblListaPaquetes.Size = new System.Drawing.Size(242, 18);
            this.lblListaPaquetes.TabIndex = 5;
            this.lblListaPaquetes.Text = "Paquetes ingresados en el sistema ";
            // 
            // lblListLote
            // 
            this.lblListLote.AutoSize = true;
            this.lblListLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListLote.Location = new System.Drawing.Point(565, 74);
            this.lblListLote.Name = "lblListLote";
            this.lblListLote.Size = new System.Drawing.Size(115, 18);
            this.lblListLote.TabIndex = 6;
            this.lblListLote.Text = "Espacio en Lote";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(198, 457);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 39);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(446, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 39);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // plantillaLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 527);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblListLote);
            this.Controls.Add(this.lblListaPaquetes);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lisLote);
            this.Controls.Add(this.lisPaquete);
            this.Controls.Add(this.lblLote);
            this.Name = "plantillaLote";
            this.Text = "Lote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.ListBox lisPaquete;
        private System.Windows.Forms.ListBox lisLote;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblListaPaquetes;
        private System.Windows.Forms.Label lblListLote;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
    }
}