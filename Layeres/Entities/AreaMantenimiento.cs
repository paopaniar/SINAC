using SINAC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{
    /// <summary>
    /// Representa un Area
    /// </summary>
    public class AreaMantenimiento
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string SitioWeb { get; set; }
        public DateTime Horario { get; set; }
        public string Tipo { get; set; }
        public string Hora { get; set; }
        public int Precio { get; set; } 
        public TipoArea tipo { get; set; }
        public int Disponibilidad { get; set; }
        public byte[] Foto { get; set; }
    }
}
