namespace Distribuciòn
{
    partial class LotesALlevar
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
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTotalPaquetes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(36, 45);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 0;
            this.lblLote.Text = "Lote:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(147, 45);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(58, 13);
            this.lblUbicacion.TabIndex = 1;
            this.lblUbicacion.Text = "Ubicacion:";
            // 
            // lblTotalPaquetes
            // 
            this.lblTotalPaquetes.AutoSize = true;
            this.lblTotalPaquetes.Location = new System.Drawing.Point(357, 45);
            this.lblTotalPaquetes.Name = "lblTotalPaquetes";
            this.lblTotalPaquetes.Size = new System.Drawing.Size(82, 13);
            this.lblTotalPaquetes.TabIndex = 2;
            this.lblTotalPaquetes.Text = "Total Paquetes:";
            // 
            // LotesALlevar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalPaquetes);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblLote);
            this.Name = "LotesALlevar";
            this.Text = "Lotes a Llevar ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblTotalPaquetes;
    }
}