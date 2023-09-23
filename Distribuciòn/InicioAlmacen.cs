using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribución;

namespace Distribuciòn
{
    public partial class InicioAlmacen : Form
    {
        public static InicioAlmacen frmInicioAlmacen;
        public InicioAlmacen()
        {
            InitializeComponent();
            frmInicioAlmacen = this; // Inicializa la instancia
        }

        private void btnGestioAlmacen_Click(object sender, EventArgs e)
        {
            frmInicioAlmacen.Visible = (false);
            GestionAlmacen frmGestionAlmacen = new GestionAlmacen();
            frmGestionAlmacen.Show();
            frmGestionAlmacen.FormClosed += (s, arg) => frmInicioAlmacen.Visible = (true);
        }
    }
}
