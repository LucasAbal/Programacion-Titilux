using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADODB;
using System.Windows.Forms;

namespace Distribuciòn
{
    class Lote
    {
        public Connection conexion;

        public int capacidad { get; set; }
        public string ubicacion { get; set; }

        public Lote(string cadenaConexion)
        {
            conexion = new Connection();
            conexion.Open("miodbc");
        }

        public int AgregarLote(int capacidad, string ubicacion)
        {
            object filasAfectadas;
            string consulta = $"INSERT INTO lote (capacidad, ubicacion) VALUES ({capacidad}, '{ubicacion}')";
            conexion.Execute(consulta, out filasAfectadas);

            // Obtener la ID del lote recién agregado
            Recordset rs = new Recordset();
            rs.Open("SELECT LAST_INSERT_ID() AS NewID", conexion);

            if (!rs.EOF)
            {
                int nuevaID = Convert.ToInt32(rs.Fields["NewID"].Value);
                return nuevaID;
            }

            return -1; // En caso de error
        }

        public List<string> ObtenerLotesExistentes()
        {
            List<string> lotesExistente = new List<string>();

            Recordset rs = new Recordset();
            rs.Open("SELECT * FROM lote", conexion);

            while (!rs.EOF)
            {
                int id = Convert.ToInt32(rs.Fields["id"].Value);
                int capacidad = Convert.ToInt32(rs.Fields["capacidad"].Value);
                string ubicacion = rs.Fields["ubicacion"].Value.ToString();

                lotesExistente.Add($"ID: {id}, Capacidad: {capacidad}, Ubicación: {ubicacion}");
                rs.MoveNext();
            }

            return lotesExistente;
        }

        public List<string> ObtenerInformacionLote(int id)
        {
            List<string> informacionLote = new List<string>();

            // Realiza una consulta a la base de datos para obtener la información del lote
            string consulta = $"SELECT capacidad, ubicacion FROM lote WHERE id = {id}";

            Recordset rs = new Recordset();
            rs.Open(consulta, conexion);

            if (!rs.EOF)
            {
                int capacidad = Convert.ToInt32(rs.Fields["capacidad"].Value);
                string ubicacion = rs.Fields["ubicacion"].Value.ToString();

                informacionLote.Add(capacidad.ToString());
                informacionLote.Add(ubicacion);
            }

            return informacionLote;
        }

        public int ObtenerIDPaquete(string nombrePaquete)
        {
            // Realiza una consulta para obtener el ID del paquete en función del nombre
            string consulta = $"SELECT id FROM paquete WHERE tamano = '{nombrePaquete}'";

            Recordset rs = new Recordset();
            rs.Open(consulta, conexion);

            if (!rs.EOF)
            {
                int paqueteID = Convert.ToInt32(rs.Fields["id"].Value);
                return paqueteID;
            }

            return -1; // En caso de error o si no se encontró el paquete
        }

        public bool AgregarRelacionLotePaquete(int loteID, int paqueteID)
        {
            object filasAfectadas;
            string consulta = $"INSERT INTO lote_paquete (loteID, paqueteID) VALUES ({loteID}, {paqueteID})";
            conexion.Execute(consulta, out filasAfectadas);

            // Verificar si se insertaron filas (éxito) o no
            return (int)filasAfectadas > 0;
        }
        public int ObtenerTotalPaquetesEnLote(int loteID)
        {
            // Realiza una consulta para contar los paquetes relacionados con el lote
            string consulta = $"SELECT COUNT(*) AS TotalPaquetes FROM lote_paquete WHERE loteID = {loteID}";

            Recordset rs = new Recordset();
            rs.Open(consulta, conexion);

            if (!rs.EOF)
            {
                int totalPaquetes = Convert.ToInt32(rs.Fields["TotalPaquetes"].Value);
                return totalPaquetes;
            }

            return 0; // En caso de error o si no se encontraron paquetes relacionados
        }
    }
}