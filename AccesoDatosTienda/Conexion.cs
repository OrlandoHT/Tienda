using System.Data;
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

    }
}
