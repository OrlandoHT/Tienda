using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;

namespace AccesoDatosTienda
{
    public class TiendaAccesoDatos
    {
        Conexion con;
        public TiendaAccesoDatos()
        {
            con = new Conexion("localhost", "root", "", "Tiendaa", 3306);
        }
        public void GuardarProducto(EntiTienda tienda)
        {
            string consulta = string.Format("Insert into producto values({0},'{1}','{2}','{3}'",
                tienda.Idproducto, tienda.Nombre, tienda.Descripcion, tienda.Precio);
            con.EjecutarConsulta(consulta);
        }
        public void EliminarProducto(int idProducto)
        {
            string consulta = string.Format("Delete from producto where idproducto={0}", idProducto);
            con.EjecutarConsulta(consulta);
        }
        public void ModificarProducto(EntiTienda tienda)
        {
            string consulta = string.Format("update producto set nombre='{0}', descripcion='{1}', precio='{2}' where idproducto = {3}",
                tienda.Nombre, tienda.Descripcion, tienda.Precio, tienda.Idproducto);
            con.EjecutarConsulta(consulta);
        }
        public List<EntiTienda> GetEntiTiendas()
        {
            var listTienda = new List<EntiTienda>();
            var ds = new DataSet();

            string consulta = "select * from producto";
            ds = con.ObtenerDatos(consulta, "producto");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var producto = new EntiTienda
                {
                    Idproducto = Convert.ToInt32(row["idproducto"]),
                    Nombre = row["nombre"].ToString(),
                    Descripcion = row["descripcion"].ToString(),
                    Precio = row["precio"].ToString()
                };
                listTienda.Add(producto);
            }
            return listTienda;
        }
    }
}
