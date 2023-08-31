using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{
    /// <summary>
    /// Representa un Visitante
    /// </summary>
    public class Visitantes
    {
        public int IDVisitantes { get; set; }
        public string NombresCompletos { get; set;}
       public string ID_Usuario { get; set; }
        public int Tiquete { get; set; }

      
        public override string ToString()
        {
            return "Nombre Visitante: " + NombresCompletos.ToString() + " Identificación: " + IDVisitantes ;
        }
        

    }
}
