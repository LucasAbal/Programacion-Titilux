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
    public partial class IngresarChoferes : Form
    {
        public IngresarChoferes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Chofer claseChofer = new Chofer();
            Int32 Ci;
            Int32 Telefono;
            if (!Int32.TryParse(txtCi.Text, out Ci))
            {
                MessageBox.Show("La cédula debe estar en formato numérico");
            }
            else
            {
                Int32.TryParse(txtTelefono.Text, out Telefono);
                // Crear una conexión ADODB utilizando la conexión existente
                ADODB.Connection conn = new ADODB.Connection();

                try
                {
                    // Crear un comando para insertar los datos en la tabla clientes
                    ADODB.Command cmdCliente = new ADODB.Command();
                    cmdCliente.ActiveConnection = conn;
                    cmdCliente.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    cmdCliente.CommandText = "INSERT INTO clientes (Cedula, Nombre) VALUES (?, ?)";

                    // Agregar parámetros a la consulta para la tabla clientes
                    cmdCliente.Parameters.Append(cmdCliente.CreateParameter("Cedula", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 10, Ci));
                    cmdCliente.Parameters.Append(cmdCliente.CreateParameter("Nombre", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 255, txtNombre.Text));

                    // Crear un comando para insertar los datos en la tabla cliente_telefono
                    ADODB.Command cmdTelefono = new ADODB.Command();
                    cmdTelefono.ActiveConnection = conn;
                    cmdTelefono.CommandType = ADODB.CommandTypeEnum.adCmdText;
                    cmdTelefono.CommandText = "INSERT INTO cliente_telefono (Cedula, Telefono) VALUES (?, ?)";

                    // Agregar parámetros a la consulta para la tabla cliente_telefono
                    cmdTelefono.Parameters.Append(cmdTelefono.CreateParameter("Cedula", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 10, Ci));
                    cmdTelefono.Parameters.Append(cmdTelefono.CreateParameter("Telefono", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, 20, Telefono));

                    MessageBox.Show("Datos guardados correctamente");

                    // Cerrar la conexión
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al guardar los datos: " + ex.Message);
                }
            }
            claseChofer = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Chofer claseChofer = new Chofer();
            Int32 ci;
            DialogResult respuesta;
            if (!Int32.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("La CI debe ser en formato numerico");
            }
            else
            {
                claseChofer.conexion = Program.cn;
                claseChofer.ci = ci;
                respuesta = MessageBox.Show("¿Estas seguro?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    switch (claseChofer.Eliminar())
                    {
                        case 0:
                            MessageBox.Show("Debe loguearse nuevamente");
                            break;
                        default:
                            MessageBox.Show("Hubo errores al efectuar la operacion. Reintetne");
                            break;
                    }
                }
            }
            claseChofer = null;
        }

    }
}
