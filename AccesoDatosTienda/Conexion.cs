using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatosTienda
{
    public class Conexion
    {
        private MySqlConnection _conn;
        public Conexion(string servidor, string empleado, string password, string basedatos, uint puerto)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();
            cadenaConexion.Server = servidor;
            cadenaConexion.UserID = empleado;
            cadenaConexion.Password = password;
            cadenaConexion.Database = basedatos;
            cadenaConexion.Port = puerto;

            _conn = new MySqlConnection(cadenaConexion.ToString());
        }
        public void EjecutarConsulta(string consulta)
        {
            _conn.Open();
            var command = new MySqlCommand(consulta, _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }
        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, _conn);
            da.Fill(ds, tabla);
            return ds;
        }
    }
}
