using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;


namespace Distribuciòn
{
    public partial class plantillaLote : Form
    {
        private int loteID;

        public plantillaLote(int id)
        {

            InitializeComponent();
            loteID = id;
            
            // Llamar al método para cargar los lotes existentes en la ListBox
            CargarPaquetesExistentes();

            // Llamar al método para cargar la información del lote
            CargarInformacionLote();
        }

        private void CargarPaquetesExistentes()
        {
            string cadenaConexion = "miodbc";

            // Crear una instancia de la clase Paquete
            Paquete gestorPaquetes = new Paquete(cadenaConexion);

            // Obtener los paquetes existentes y agregarlos a la ListBox
            List<string> paquetesExistentes = gestorPaquetes.ObtenerPaquetesExistentes();
            foreach (string paqueteExistente in paquetesExistentes)
            {
                lisPaquete.Items.Add(paqueteExistente);
            }
        }


        private void CargarInformacionLote()
        {
            string cadenaConexion = "miodbc";

            // Crear una instancia de la clase Lote
            Lote gestorLotes = new Lote(cadenaConexion);

            // Obtener la información del lote en función del ID
            List<string> informacionLote = gestorLotes.ObtenerInformacionLote(loteID);

            if (informacionLote.Count >= 2)
            {
                // El resultado debe contener al menos dos elementos: Capacidad y Ubicación
                string capacidad = informacionLote[0];
                string ubicacion = informacionLote[1];

                // Mostrar la información en los Label
                lblLote.Text = $"Lote: {loteID}";
                lblCapacidad.Text = $"Capacidad: {capacidad}";
                lblUbicacion.Text = $"Ubicación: {ubicacion}";
            }
            else
            {
                // Manejo de error si no se pudo obtener la información del lote
                MessageBox.Show("Error al obtener la información del lote.");
            }
        }

        private void lisPaquete_DoubleClick(object sender, EventArgs e)
        {
            if (lisPaquete.SelectedItem != null)
            {
                // Obtener el elemento seleccionado en listPaquete
                string paqueteSeleccionado = lisPaquete.SelectedItem.ToString();

                // Agregar el elemento seleccionado a listLote
                lisLote.Items.Add(paqueteSeleccionado);

                // Eliminar el elemento seleccionado de listPaquete
                lisPaquete.Items.Remove(paqueteSeleccionado);
            }

        }
       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar si hay elementos en lisLote para guardar
            if (lisLote.Items.Count > 0)
            {
                string cadenaConexion = "miodbc";

                // Crear una instancia de la clase Lote
                Lote gestorLotes = new Lote(cadenaConexion);

                // Recorrer los elementos en lisLote y guardar la relación en la tabla lote_paquete
                foreach (var item in lisLote.Items)
                {
                    string paqueteSeleccionado = item.ToString();

                    // Obtener el ID del paquete seleccionado
                    int paqueteID = gestorLotes.ObtenerIDPaquete(paqueteSeleccionado);

                    // Verificar si se pudo obtener el ID del paquete
                    if (paqueteID != -1)
                    {
                        // Guardar la relación en la tabla lote_paquete
                        if (gestorLotes.AgregarRelacionLotePaquete(loteID, paqueteID))
                        {
                            // Éxito al guardar la relación
                            MessageBox.Show($"Se ha guardado la relación del paquete {paqueteSeleccionado} en el lote {loteID}.");
                        }
                        else
                        {
                            // Error al guardar la relación
                            MessageBox.Show($"Error al guardar la relación del paquete {paqueteSeleccionado} en el lote {loteID}.");
                        }
                    }
                }

                // Limpiar lisLote después de guardar las relaciones
                lisLote.Items.Clear();
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Mover todos los elementos de lisLote de vuelta a lisPaquete
            foreach (var item in lisLote.Items)
            {
                lisPaquete.Items.Add(item);
            }

            // Limpiar lisLote después de mover los elementos
            lisLote.Items.Clear();

        }
    }
}
