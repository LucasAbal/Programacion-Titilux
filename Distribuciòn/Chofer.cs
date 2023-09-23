using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuciòn
{
    class Chofer
    {
        protected Int32 _ci;
        protected String _nombre;
        protected List<String> _telefono;
        protected ADODB.Connection _conexion;
        public Int32 ci
        {
            set { _ci = value; }
            get { return (_ci); }
        }
        public string nombre
        {
            set { _nombre = value; }
            get { return (_nombre); }
        }
        public ADODB.Connection conexion
        {
            set { _conexion = value; }
            get { return (_conexion); }
        }
        public List<String> telefonos
        {
            set { _telefono = value; }
            get { return (_telefono); }
        }
        public Chofer()
        {
            _ci = 0;
            _nombre = "";
            _telefono = new List<string>();
            _conexion = new ADODB.Connection();
        }

        public byte Buscar()
        {
            String sql;
            ADODB.Recordset rs;
            object filasafectadas;
            byte resultado = 0;

            if (_conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "select nombre from clientes where ci=" + _ci;
                try
                {
                    rs = _conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return (2); //Error al consultar tabla de clientes 
                }
                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontre 
                }
                else // si encunetra un registro, la busca por la clave primaria
                {
                    _nombre = Convert.ToString(rs.Fields[0].Value);
                    sql = "select telefono from cliente_telefono where cliente=" + _ci;
                    try
                    {
                        rs = _conexion.Execute(sql, out filasafectadas);
                    }
                    catch
                    {
                        return (4); //Error al consultar tabla de clientes telefono 
                    }
                    _telefono.Clear();
                    while (!rs.EOF)
                    {
                        _telefono.Add(Convert.ToString(rs.Fields[0].Value));
                        rs.MoveNext();
                    }
                }
                rs = null;
                filasafectadas = null;
            }// if _conexion
            return (resultado);
        }// buscar
        public byte Guardar(Boolean mod)
        {
            string sql;
            object filasAfectadas;
            byte resultado = 0; //conexion cerrada
            if (_conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {

                if (mod)
                {
                    sql = "update clientes set nombre='" + _nombre + "' where ci=" + _ci;

                }
                else
                {
                    sql = "insert into clientes(ci,nombre) values(" + _ci + ",'" + _nombre + "')";
                }
                try
                {
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (2);
                }
                if (mod)
                {
                    sql = "delete from cliente_telefono where clientes =" + _ci;
                    try
                    {
                        _conexion.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        return (3);
                    }
                }
                foreach (string tel in _telefono)
                {
                    sql = "insert into cliente_telefono(cliente,telefono) values(" + _ci + ",'" + tel + "')";
                    try
                    {
                        _conexion.Execute(sql, out filasAfectadas);
                    }
                    catch
                    {
                        return (4);
                    }
                }
                filasAfectadas = null;
            }
            return (resultado);
        }
        public byte Eliminar()
        {
            byte resultado = 0;
            string sql;
            object filasAfectadas;
            if (_conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "delete from cliente_telefono where cliente =" + _ci;
                try
                {
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (2);
                }
                sql = "delete from cliente where ci =" + _ci;
                try
                {
                    _conexion.Execute(sql, out filasAfectadas);
                }
                catch
                {
                    return (3);
                }
                filasAfectadas = null;
            }
            return (resultado);
        }
    }
}
