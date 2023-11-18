namespace Distribuciòn
{
    partial class InicioAlmacen
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
            this.btnGestioAlmacen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestioAlmacen
            // 
            this.btnGestioAlmacen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGestioAlmacen.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestioAlmacen.Image = global::Distribuciòn.Properties.Resources.box;
            this.btnGestioAlmacen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGestioAlmacen.Location = new System.Drawing.Point(21, 31);
            this.btnGestioAlmacen.Name = "btnGestioAlmacen";
            this.btnGestioAlmacen.Size = new System.Drawing.Size(122, 82);
            this.btnGestioAlmacen.TabIndex = 0;
            this.btnGestioAlmacen.Text = "Gestión de Almacén";
            this.btnGestioAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGestioAlmacen.UseVisualStyleBackColor = false;
            this.btnGestioAlmacen.Click += new System.EventHandler(this.btnGestioAlmacen_Click);
            // 
            // InicioAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(723, 406);
            this.Controls.Add(this.btnGestioAlmacen);
            this.Name = "InicioAlmacen";
            this.Text = "Almacén";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestioAlmacen;
    }
}