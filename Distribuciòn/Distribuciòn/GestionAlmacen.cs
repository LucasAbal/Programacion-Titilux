using Distribuciòn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribución
{
    public partial class GestionAlmacen : Form
    {
        public GestionAlmacen()
        {
            InitializeComponent();

            // Llamar al método para cargar los lotes existentes en la ListBox
            CargarLotesExistentes();
        }

        private void CargarLotesExistentes()
        {
            string cadenaConexion = "miodbc";

            Lote gestor = new Lote(cadenaConexion);

            // Obtener los lotes existentes y agregarlos a la ListBox
            List<string> lotesExistentes = gestor.ObtenerLotesExistentes();
            foreach (string loteExistente in lotesExistentes)
            {
                lisLote.Items.Add(loteExistente);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int capacidad = 0;
            string ubicacion = "";

            string cadenaConexion = "miodbc";

            Lote gestor = new Lote(cadenaConexion);

            // Agregar el lote y obtener la ID del lote recién agregado
            int nuevaID = gestor.AgregarLote(capacidad, ubicacion);

            if (nuevaID != -1)
            {
                // Crea una cadena que representa el nuevo elemento de la lista con la ID obtenida
                string nuevoElemento = $"ID: {nuevaID}, Capacidad: {capacidad}/24, Ubicación: {ubicacion}";

                // Agrega el nuevo elemento al principio de la ListBox
                lisLote.Items.Insert(0, nuevoElemento);
            }
            else
            {
                MessageBox.Show("Error al agregar el lote");
            }

            MessageBox.Show("Lote agregado correctamente");
        }

        // Método para extraer la ID desde la cadena "ID: {ID}"
        private int ObtenerIDDesdeString(string selectedItem)
        {
            int startIndex = selectedItem.IndexOf("ID: ") + 4; // Longitud de "ID: " es 4
            int endIndex = selectedItem.IndexOf(",", startIndex);
            string idString = selectedItem.Substring(startIndex, endIndex - startIndex);

            if (int.TryParse(idString, out int id))
            {
                return id;
            }
            else
            {
                // Manejo de error si no se pudo obtener la ID
                return -1;
            }
        }

        private void lisLote_DoubleClick_1(object sender, EventArgs e)
        {
            if (lisLote.SelectedItem != null)
            {
                string selectedItem = lisLote.SelectedItem.ToString();

                // Extraer la ID del elemento seleccionado (asumiendo que la ID está en el formato "ID: {ID}")
                int selectedID = ObtenerIDDesdeString(selectedItem);

                // Crear un formulario de edición y pasar la ID del lote seleccionado
                plantillaLote formEdicion = new plantillaLote(selectedID);
                formEdicion.ShowDialog(); // Abre el formulario en modo modal
            }

        }
    }
}
