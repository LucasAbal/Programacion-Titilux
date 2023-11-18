namespace Distribución
{
    partial class GestionAlmacen
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
            this.btnAgregarLote = new System.Windows.Forms.Button();
            this.lblLote = new System.Windows.Forms.Label();
            this.gboAlmacen1 = new System.Windows.Forms.GroupBox();
            this.lisLote = new System.Windows.Forms.ListBox();
            this.gboAlmacen1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Location = new System.Drawing.Point(73, 19);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarLote.TabIndex = 0;
            this.btnAgregarLote.Text = "+";
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            this.btnAgregarLote.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Location = new System.Drawing.Point(15, 24);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(52, 13);
            this.lblLote.TabIndex = 1;
            this.lblLote.Text = "Crear lote";
            // 
            // gboAlmacen1
            // 
            this.gboAlmacen1.Controls.Add(this.lisLote);
            this.gboAlmacen1.Controls.Add(this.lblLote);
            this.gboAlmacen1.Controls.Add(this.btnAgregarLote);
            this.gboAlmacen1.Location = new System.Drawing.Point(12, 12);
            this.gboAlmacen1.Name = "gboAlmacen1";
            this.gboAlmacen1.Size = new System.Drawing.Size(343, 586);
            this.gboAlmacen1.TabIndex = 2;
            this.gboAlmacen1.TabStop = false;
            this.gboAlmacen1.Text = "Almacen 1";
            // 
            // lisLote
            // 
            this.lisLote.FormattingEnabled = true;
            this.lisLote.Location = new System.Drawing.Point(18, 58);
            this.lisLote.Name = "lisLote";
            this.lisLote.Size = new System.Drawing.Size(310, 511);
            this.lisLote.TabIndex = 2;
            this.lisLote.DoubleClick += new System.EventHandler(this.lisLote_DoubleClick_1);
            // 
            // GestionAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 610);
            this.Controls.Add(this.gboAlmacen1);
            this.Name = "GestionAlmacen";
            this.Text = "Almacen";
            this.gboAlmacen1.ResumeLayout(false);
            this.gboAlmacen1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.GroupBox gboAlmacen1;
        private System.Windows.Forms.ListBox lisLote;
    }
}