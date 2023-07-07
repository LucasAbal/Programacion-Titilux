using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuciòn
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void menuRegistro_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            menuAplicacion.Enabled = false;
            menuChofer.Enabled = false;
        }

        private void menuAlmacen_Click(object sender, EventArgs e)
        {
            Almacen frmAlmacen = new Almacen();
            frmAlmacen.Show();
        }

        private void menuChofer_Click(object sender, EventArgs e)
        {
            Choferes frmChoferes = new Choferes();
            frmChoferes.Show();
        }
    }
}
