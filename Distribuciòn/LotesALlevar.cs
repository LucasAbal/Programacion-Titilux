using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Distribuciòn;
using ADODB;

namespace Distribuciòn
{
    public partial class LotesALlevar : Form
    {
        private int loteID;
        private object totalPaquetes;
        private object ubicacion;

        public LotesALlevar(int loteID)
        {
            InitializeComponent();
            this.loteID = loteID; // Asignar el valor de loteID proporcionado al campo de la clase
            CargarInformacionLote();
            // Asignar los valores a las etiquetas
            lblLote.Text = $"Lote: {loteID}";
            lblTotalPaquetes.Text = $"Total de Paquetes: {totalPaquetes}";
            lblUbicacion.Text = $"Ubicación: {ubicacion}";
        }

        public LotesALlevar()
        {
        }

        private void CargarInformacionLote()
        {
            string cadenaConexion = "miodbc";

            // Crear una instancia de la clase Lote o utilizar la que ya tienes
            Lote gestorLotes = new Lote(cadenaConexion);

            // Obtener la información del lote en función del ID
            List<string> informacionLote = gestorLotes.ObtenerInformacionLote(loteID);

            if (informacionLote.Count >= 2)
            {
                // El resultado debe contener al menos dos elementos: Capacidad y Ubicación
                string capacidad = informacionLote[0];
                string ubicacion = informacionLote[1];

                // Mostrar la información en las etiquetas
                lblLote.Text = $"Lote: {loteID}";
                lblUbicacion.Text = $"Ubicación: {ubicacion}";

                // Obtener el total de paquetes relacionados con el lote
                int totalPaquetes = gestorLotes.ObtenerTotalPaquetesEnLote(loteID);
                lblTotalPaquetes.Text = $"Total de Paquetes: {totalPaquetes}";
            }
            else
            {
                // Manejo de error si no se pudo obtener la información del lote
                MessageBox.Show("Error al obtener la información del lote.");
                this.Close(); // Cerrar el formulario en caso de error
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario al hacer clic en el botón Cerrar
        }
    }
}

