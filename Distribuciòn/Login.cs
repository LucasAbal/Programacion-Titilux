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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.cn.Open("miodbc", txtUsuario.Text, txtContraseña.Text);
            }
            catch
            {
                MessageBox.Show("El usuario o contraseña estan mal");

            }
            Program.cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            Program.doyPermiso(txtUsuario.Text);
            this.Close();
        }
    }
}
