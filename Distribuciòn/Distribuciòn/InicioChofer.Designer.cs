namespace Distribuciòn
{
    partial class InicioChofer
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
            this.btnLotesLlevar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLotesLlevar
            // 
            this.btnLotesLlevar.Location = new System.Drawing.Point(35, 28);
            this.btnLotesLlevar.Name = "btnLotesLlevar";
            this.btnLotesLlevar.Size = new System.Drawing.Size(161, 130);
            this.btnLotesLlevar.TabIndex = 0;
            this.btnLotesLlevar.Text = "Lotes a llevar";
            this.btnLotesLlevar.UseVisualStyleBackColor = true;
            this.btnLotesLlevar.Click += new System.EventHandler(this.btnLotesLlevar_Click);
            // 
            // InicioChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLotesLlevar);
            this.Name = "InicioChofer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLotesLlevar;
    }
}