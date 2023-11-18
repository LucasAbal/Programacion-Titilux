using System;
using ADODB;
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
    public partial class Choferes : Form
    {
        public Choferes()
        {
            InitializeComponent();
        }
        byte Buscar()
        {
            return (0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Choferes_Load(object sender, EventArgs e)
        {

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
                        gbBuscar.Enabled = false;
                        gbDatos.Enabled = true;
                        btnEliminar.Enabled = true;
                        txtNombre.Text = claseChofer.nombre;
                        cboTelefono.Items.Clear();
                        foreach (string tel in claseChofer.telefonos)
                        {
                            cboTelefono.Items.Add(tel);
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
                            gbDatos.Visible = true;
                            gbBuscar.Enabled = false;
                            btnEliminar.Enabled = false;
                            txtNombre.Clear();
                            cboTelefono.Items.Clear();
                        }
                        break;
                    case 4://error al buscar telefono
                        MessageBox.Show("Error al busar el telefono");
                        break;
                }//switch
            }
            claseChofer = null;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTelefono.Items.IndexOf(cboTelefono.Text) < 0)
            {
                cboTelefono.Items.Add(cboTelefono.Text);
            }
            else
            {
                MessageBox.Show("El telèfono ya existe en la lista");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (cboTelefono.Items.IndexOf(cboTelefono.Text) < 0)
            {
                MessageBox.Show("El telèfono ya existe en la lista");
            }
            else
            {
                cboTelefono.Items.Remove(cboTelefono.Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Chofer claseChofer = new Chofer();
            Int32 Ci;
            if (!Int32.TryParse(txtCi.Text, out Ci))
            {
                MessageBox.Show("la ci debe estar en formato numerico");
            }
            else
            {

                
            claseChofer.conexion = Program.cn;
            claseChofer.ci = Ci;
            claseChofer.nombre = txtNombre.Text;
            foreach (string tel in cboTelefono.Items)
            {
                claseChofer.telefonos.Add(tel);
            }
            switch (claseChofer.Guardar(btnEliminar.Enabled))
            {
                case 0:
                    gbBuscar.Enabled = true;
                    gbDatos.Visible = false;
                    break;
                case 1:
                    MessageBox.Show("Debe logearse nuevamente");
                    break;
                case 2:
                    MessageBox.Show("Hubo errores al efectuar la operaciòn. Reintente o contactese con el administrador");
                    break;
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
                            gbBuscar.Enabled = true;
                            gbDatos.Enabled = false;
                            break;
                        case 1:
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
