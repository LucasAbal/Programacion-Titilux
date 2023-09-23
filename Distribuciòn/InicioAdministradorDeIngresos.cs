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
    public partial class InicioAdministradorDeIngresos : Form
    {
        public static InicioAdministradorDeIngresos frmInicioAdmin;
        public InicioAdministradorDeIngresos()
        {
            InitializeComponent();
            frmInicioAdmin = this; // Inicializa la instancia
        }

        private void btnBuscarChoferes_Click(object sender, EventArgs e)
        {
            frmInicioAdmin.Visible = (false);
            BusquedaChoferes frmBusquedaChoferes = new BusquedaChoferes();
            frmBusquedaChoferes.Show();
            frmBusquedaChoferes.FormClosed += (s, arg) => frmInicioAdmin.Visible = (true);
        }

        private void btnIngresarChoferes_Click(object sender, EventArgs e)
        {
            frmInicioAdmin.Visible = (false);
            IngresarChoferes frmIngresarChoferes = new IngresarChoferes();
            frmIngresarChoferes.Show();
            frmIngresarChoferes.FormClosed += (s, arg) => frmInicioAdmin.Visible = (true);
        }

        private void btnIngresarPaquetes_Click(object sender, EventArgs e)
        {
            frmInicioAdmin.Visible = (false);
            IngresoPaquete frmIngresoPaquete = new IngresoPaquete();
            frmIngresoPaquete.Show();
            frmIngresoPaquete.FormClosed += (s, arg) => frmInicioAdmin.Visible = (true);
        }
    }
}
