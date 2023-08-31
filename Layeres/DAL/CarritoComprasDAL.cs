using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.DAL
{
    class CarritoComprasDAL
    {
        /// <summary>
        /// Funcion para guardar un carrito en la Base de Datos
        /// </summary>
        /// <param name="carrito">CarritoCompras que se va a guardar</param>
        public static void InsertarCompra(CarritoCompras carrito)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarCompra";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@ID", carrito.ID);
                    comando.Parameters.AddWithValue("@IdReserva", carrito.IdReserva);
                    comando.Parameters.AddWithValue("@CantidadTickets", carrito.CantidadTickets);
                    comando.Parameters.AddWithValue("@MontoaPagar", carrito.MontoaPagar);
                    comando.Parameters.AddWithValue("@Moneda", carrito.Moneda);
                    comando.Parameters.AddWithValue("@MetodoPago", carrito.MetodoPago);
                    comando.Parameters.AddWithValue("@Pais", carrito.Pais);
                   
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
