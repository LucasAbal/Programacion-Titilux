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
        public static Inicio frmInicio;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmInicio = new Inicio());
        }
        public static ADODB.Connection cn = new ADODB.Connection();
        public static void doyPermiso(string usuario)
        {
            String sql;
            ADODB.Recordset rs = new ADODB.Recordset();
            object filasAfectadas; // objeto donde se alamcena los registros de filas afectadas
            byte rol = 0;   

            Program.frmInicio.menuAplicacion.Enabled = false; // Inhabilito los puntos del menu
            Program.frmInicio.menuChofer.Enabled = false;
            Program.frmInicio.menuIngresar.Enabled = true;

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
                            Program.frmInicio.menuAplicacion.Enabled = true;
                            Program.frmInicio.menuChofer.Enabled = false;
                            break;
                        case 2: // Camionero
                            Program.frmInicio.menuAplicacion.Enabled = true;
                            Program.frmInicio.menuChofer.Enabled = false;
                            break;
                        case 3: // Administrador
                            Program.frmInicio.menuAplicacion.Enabled = true;
                            Program.frmInicio.menuChofer.Enabled = true;
                            break;
                    }
                }
            }
            rs = null;
            filasAfectadas = null;
        } 
    }
}
