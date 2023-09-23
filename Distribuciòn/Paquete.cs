using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADODB;

namespace Distribuciòn
{
    public class Paquete
    {
        private Connection conexion;
        
        public int peso { get; set; }
        public string tamano { get; set; }
        
        public Paquete(string cadenaConexion)
        {
            conexion = new Connection();
            conexion.Open("miodbc");
        }

        public void AgregarPaquete(int peso, string tamano)
        {
            object filasAfectadas;
            string consulta = $"INSERT INTO paquete (Peso, Tamano) VALUES ('{peso}', '{tamano}')";

            conexion.Execute(consulta, out filasAfectadas);
        }

        public List<string> ObtenerPaquetesExistentes()
        {
            List<string> paquetesExistente = new List<string>();

            Recordset rs = new Recordset();
            rs.Open("SELECT * FROM paquete", conexion);

            while (!rs.EOF)
            {
                int id = Convert.ToInt32(rs.Fields["id"].Value); // Agregar la ID
                int peso = Convert.ToInt32(rs.Fields["peso"].Value);
                string tamano = rs.Fields["tamano"].Value.ToString();

                paquetesExistente.Add($"ID: {id}, Peso: {peso}, Tamaño: {tamano}");

                rs.MoveNext();
            }

            return paquetesExistente;
        }
    }
}
