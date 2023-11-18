using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuciòn
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static Login frmLogin;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(frmLogin = new Login());
            
        }
        public static ADODB.Connection cn = new ADODB.Connection();

        public static void doyPermiso(string usuario)
        {
            
            String sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            object filasAfectadas; // objeto donde se alamcena los registros de filas afectadas
            byte rol = 0;   

            if (cn.State != 0)
            {
                // Asignamos el comado que queremos enviar a sql mediante una variable
                sql = "select rol from Rol_Usuario where usuario ='" + usuario + "'";
                try
                {
                    rs = cn.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    rs = null; // destruimos el objeto
                    return; // detenemos el procedimiento
                }
                if (rs.RecordCount > 0)//si el contador de registros es mayor a cero 
                {
                    rol = Convert.ToByte(rs.Fields[0].Value);
                    switch (rol)
                    {
                        case 1: // Cliente
                            InicioCliente frmInicioCliente = new InicioCliente();
                            frmInicioCliente.Show();
                            frmInicioCliente.FormClosed += (s, arg) => frmLogin.Visible = (true);
                            break;
                        case 2: // Camionero
                            InicioChofer frmInicioChofer = new InicioChofer();
                            frmInicioChofer.Show();
                            frmInicioChofer.FormClosed += (s, arg) => frmLogin.Visible = (true);
                            break;

                        case 3: // Administrador de almacen
                            InicioAlmacen frmInicioAlmacen = new InicioAlmacen();
                            frmInicioAlmacen.Show();
                            frmInicioAlmacen.FormClosed += (s,arg) => frmLogin.Visible = (true);
                            break;
                        case 4: // Administrador de Ingresos
                            InicioAdministradorDeIngresos frmInicioAdmin = new InicioAdministradorDeIngresos();
                            frmInicioAdmin.Show();
                            frmInicioAdmin.FormClosed += (s, arg) => frmLogin.Visible = (true);
                            break;
                    }
                }
            }
            rs = null;
            filasAfectadas = null;
        }
    }
}
