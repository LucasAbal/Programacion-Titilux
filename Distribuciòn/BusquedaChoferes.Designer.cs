namespace Distribuciòn
{
    partial class BusquedaChoferes
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
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.lblCi = new System.Windows.Forms.Label();
            this.lblChoferesBuscados = new System.Windows.Forms.Label();
            this.lisChoferesBuscados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtCi);
            this.gbBuscar.Controls.Add(this.lblCi);
            this.gbBuscar.Location = new System.Drawing.Point(12, 51);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(367, 61);
            this.gbBuscar.TabIndex = 3;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Búscar Chofer";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(276, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(53, 30);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(110, 20);
            this.txtCi.TabIndex = 1;
            // 
            // lblCi
            // 
            this.lblCi.AutoSize = true;
            this.lblCi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCi.Location = new System.Drawing.Point(20, 28);
            this.lblCi.Name = "lblCi";
            this.lblCi.Size = new System.Drawing.Size(27, 20);
            this.lblCi.TabIndex = 0;
            this.lblCi.Text = "Ci:";
            // 
            // lblChoferesBuscados
            // 
            this.lblChoferesBuscados.AutoSize = true;
            this.lblChoferesBuscados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoferesBuscados.Location = new System.Drawing.Point(12, 115);
            this.lblChoferesBuscados.Name = "lblChoferesBuscados";
            this.lblChoferesBuscados.Size = new System.Drawing.Size(149, 20);
            this.lblChoferesBuscados.TabIndex = 5;
            this.lblChoferesBuscados.Text = "Choferes Buscados";
            // 
            // lisChoferesBuscados
            // 
            this.lisChoferesBuscados.FormattingEnabled = true;
            this.lisChoferesBuscados.Location = new System.Drawing.Point(16, 139);
            this.lisChoferesBuscados.Name = "lisChoferesBuscados";
            this.lisChoferesBuscados.Size = new System.Drawing.Size(363, 407);
            this.lisChoferesBuscados.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Busqueda de Choferes";
            // 
            // BusquedaChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(391, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lisChoferesBuscados);
            this.Controls.Add(this.lblChoferesBuscados);
            this.Controls.Add(this.gbBuscar);
            this.Name = "BusquedaChoferes";
            this.Text = "Busqueda de Choferes";
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Label lblCi;
        private System.Windows.Forms.Label lblChoferesBuscados;
        private System.Windows.Forms.ListBox lisChoferesBuscados;
        private System.Windows.Forms.Label label1;
    }
}