using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.BLL
{
    class CarritoCompraBLL
    {
        public void Guardar(CarritoCompras carrito)
        {
            if (carrito.CantidadTickets==null || carrito.CantidadTickets<1)
            {
                throw new ApplicationException("Debe ingresar la cantidad de tickets");
            }
            if (carrito.MetodoPago==null)
            {
                throw new ApplicationException("Debe seleccionar un método de pago");
            }
            if (carrito.Moneda==null)
            {
                throw new ApplicationException("Por favor seleccione una moneda");
            }
          
            CarritoComprasDAL.InsertarCompra(carrito);

        }
    }
}

