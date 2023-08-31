using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{
    /// <summary>
    /// Representa un Usuario
    /// </summary>
    public class Usuario
    {
        public string Nombre { get; set; }
        public  string Apellidos { get; set; }
        public string Telefono { get; set; }
        public int Nacionalidad { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Profesion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Clave { get; set; }
        public int CodRol { get; set; }
       
    }
}
