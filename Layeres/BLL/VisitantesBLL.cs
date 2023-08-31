using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.BLL
{
    class VisitantesBLL
    {
        public void GuardarVisitante(Visitantes visitas)
        {
            if (String.IsNullOrEmpty(visitas.NombresCompletos))
                throw new ApplicationException("Debe ingresar el nombre completo e identificación");
            if (visitas.NombresCompletos.Length <= 3)
                throw new ApplicationException("El nombre debe tener más de 3 letras");

            VisitantesDAL.InsertarVisitantes(visitas);

        }
    }
}
