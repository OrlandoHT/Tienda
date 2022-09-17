using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;
using AccesoDatosTienda;

namespace LogicaTienda
{
    public class ManejadorProducto
    {
        private TiendaAccesoDatos tiendaAccesoDatos = new TiendaAccesoDatos();

        public List<EntiTienda> GetProducto()
        {
            var listProdcuto = _tienda.GetProducto();
            return listEmpleados;
        }
        public void GuardarEmpleados(EntiEmpleados empleado)
        {
            _empleadosAccesoDatos.GuardarEmpleados(empleado);
        }
        public void EliminarEmpleados(int idEmpleado)
        {
            _empleadosAccesoDatos.EliminarEmpleados(idEmpleado);
        }
        public void ModificarEmpleados(EntiEmpleados empleado)
        {
            _empleadosAccesoDatos.ModificarEmpleados(empleado);
        }
    }
}
