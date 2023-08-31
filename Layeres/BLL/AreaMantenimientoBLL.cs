using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.BLL
{
    class AreaMantenimientoBLL
    {
        private static readonly log4net.ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        /// <summary>
        /// Funcion que permite guardar una area en la base de datos
        /// </summary>
        /// <param name="area">area a guardar</param>
        public void Guardar(AreaMantenimiento area)
        {
            if (String.IsNullOrEmpty(area.Nombre))
                throw new ApplicationException("Debe ingresar el Nombre del Area");


            AreaMantenimientoDAL.InsertarArea(area);
        }

        public static List<AreaMantenimiento> ObtenerTodos()
        {
            return DAL.AreaMantenimientoDAL.SeleccionarTodosSP();
        }
        public static AreaMantenimiento ObtenerPorId(string tipo)
        {
            return DAL.AreaMantenimientoDAL.SeleccionarPorTipo(tipo);
        }

        public void Eliminar(int Codigo)
        {
            AreaMantenimientoDAL area = new AreaMantenimientoDAL();
            area.EliminarAreaMantenimiento(Codigo);
        }


        public void Filtrar(string Tipo)
        {
            AreaMantenimientoDAL area = new AreaMantenimientoDAL();
            area.FiltarPorTipo(Tipo);
        }

        public Entities.AreaMantenimiento SeleccionarPorTipo(string tipo)
        {
            try
            {
                return DAL.AreaMantenimientoDAL.SeleccionarPorTipo(tipo);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error al buscar el area \n" + ex.Message);
                _MyLogControlEventos.Error(ex.Message);
            }

        }
    }
}
