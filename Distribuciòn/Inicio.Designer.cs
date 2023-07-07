namespace Distribuciòn
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransito = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAplicacion,
            this.menuIngresar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAplicacion
            // 
            this.menuAplicacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlmacen,
            this.menuTransito});
            this.menuAplicacion.Name = "menuAplicacion";
            this.menuAplicacion.Size = new System.Drawing.Size(75, 20);
            this.menuAplicacion.Text = "Aplicacion";
            // 
            // menuAlmacen
            // 
            this.menuAlmacen.Name = "menuAlmacen";
            this.menuAlmacen.Size = new System.Drawing.Size(180, 22);
            this.menuAlmacen.Text = "Almacenamiento";
            this.menuAlmacen.Click += new System.EventHandler(this.menuAlmacen_Click);
            // 
            // menuIngresar
            // 
            this.menuIngresar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuChofer,
            this.menuSalir});
            this.menuIngresar.Name = "menuIngresar";
            this.menuIngresar.Size = new System.Drawing.Size(61, 20);
            this.menuIngresar.Text = "Ingresar";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(180, 22);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuRegistro_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(180, 22);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // menuTransito
            // 
            this.menuTransito.Name = "menuTransito";
            this.menuTransito.Size = new System.Drawing.Size(180, 22);
            this.menuTransito.Text = "Transito";
            // 
            // menuChofer
            // 
            this.menuChofer.Name = "menuChofer";
            this.menuChofer.Size = new System.Drawing.Size(180, 22);
            this.menuChofer.Text = "Chofer";
            this.menuChofer.Click += new System.EventHandler(this.menuChofer_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Distribuciòn";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        public System.Windows.Forms.ToolStripMenuItem menuIngresar;
        public System.Windows.Forms.ToolStripMenuItem menuAplicacion;
        private System.Windows.Forms.ToolStripMenuItem menuTransito;
        public System.Windows.Forms.ToolStripMenuItem menuChofer;
    }
}

