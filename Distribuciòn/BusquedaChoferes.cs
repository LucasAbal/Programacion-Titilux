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
    public partial class BusquedaChoferes : Form
    {
        public BusquedaChoferes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Chofer claseChofer = new Chofer();
            DialogResult respuesta;
            Int32 Ci;
            if (!Int32.TryParse(txtCi.Text, out Ci))
            {
                MessageBox.Show("la ci debe estar en formato numerico");
            }
            else
            {
                claseChofer.ci = Ci;
                claseChofer.conexion = Program.cn;
                
                switch (claseChofer.Buscar())
                {
                    case 0: //encontro
                        foreach (string tel in claseChofer.telefonos)
                        {
                            // Verificar si la CI ya existe en la lista
                            bool ciExistente = lisChoferesBuscados.Items.Cast<string>()
                                                  .Any(item => item.Contains("CI: " + claseChofer.ci));

                            if (!ciExistente)
                            {
                                MessageBox.Show("CI: " + claseChofer.ci + "\nNombre: " + claseChofer.nombre + "\nTelefono: " + tel, "Informacion del chofer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Agregar el texto del lote a la lista de choferes
                                string informacion = "CI: " + claseChofer.ci + " Nombre: " + claseChofer.nombre + " Telefono: " + tel;
                                // Agregar el texto del lote al ListBox
                                lisChoferesBuscados.Items.Add(informacion);
                            }
                            else
                            {
                                MessageBox.Show("La CI: " + claseChofer.ci + " ya ha sido buscada.", "Cédula Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        break;
                    case 1://conexion cerrada
                        MessageBox.Show("Debe loguearse nuevamente");
                        break;
                    case 2:
                        MessageBox.Show("Error al buscar datos en la tabla clientes");
                        break;
                    case 3://no se encontro
                        respuesta = MessageBox.Show("No se encontro al cilente. ¿Desea efectuar el alta?", "Alta de Clientes", MessageBoxButtons.YesNo);
                        if (respuesta == DialogResult.Yes)
                        {
                            
                        }
                        break;
                    case 4://error al buscar telefono
                        MessageBox.Show("Error al busar el telefono");
                        break;
                }//switch
            }
            claseChofer = null;
        }
    }
}
