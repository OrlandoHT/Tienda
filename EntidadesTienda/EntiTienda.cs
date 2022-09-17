using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTienda
{
    public class EntiTienda
    {
        private int _idproducto;
        private string _nombre;
        private string _descripcion;
        private string _precio;

        public int Idproducto { get => _idproducto; set => _idproducto = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Precio { get => _precio; set => _precio = value;
    }
}
