using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.BLL
{
    class ReservacionBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public void Guardar(Reservacion reserv)
        {


            ReservacionDAL datos = new ReservacionDAL();
            Reservacion existe = ReservacionDAL.ObtenerPorId(reserv.ID);

            if (existe == null)
                ReservacionDAL.InsertarReservacion(reserv);


            //    datos.Modificar(u);
            //else
            //   datos.
        }
       
        public static List<Reservacion> ObtenerTodos()
        {
            return ReservacionDAL.ObtenerTodos();
        }

        //public Entities.Reservacion SeleccionarPorUser(string user)
        //{
        //    try
        //    {
        //        return DAL.ReservacionDAL.ObtenerPorUser(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Ocurrió un error al buscar la reserva \n" + ex.Message);
        //        _MyLogControlEventos.Error(ex.Message);
        //    }

        //}

        //public Entities.Reservacion SeleccionarPorId(int id)
        //{
        //    try
        //    {
        //        return DAL.ReservacionDAL.ObtenerPorId(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Ocurrió un error al buscar la reserva \n" + ex.Message);
        //        _MyLogControlEventos.Error(ex.Message);
        //    }

        //}

    }
}
