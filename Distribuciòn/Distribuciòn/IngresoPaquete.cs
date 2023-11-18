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
    public partial class IngresoPaquete : Form
    {
        public IngresoPaquete()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int peso = (int)numPeso.Value;
            string tamano = txtTamaño.Text;

            string cadenaConexion = "miodbc"; 

            Paquete gestor = new Paquete(cadenaConexion);
            gestor.AgregarPaquete(peso, tamano);

            MessageBox.Show("Paquete agregado correctamente");
            numPeso.Value = 0;
            txtTamaño.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            numPeso.Value = 0;
            txtTamaño.Text = "";
        }
    }
}
