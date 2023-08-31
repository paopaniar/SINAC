using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SINAC.Layeres.Entities
{
    /// <summary>
    /// Representa una Reservacion
    /// </summary>
    public class Reservacion
    {
        public DateTime FechaDeConservaciones { get; set; }
        public string ID_Tipo { get; set; }
        public string ID_Usuario { get; set; }
        public int ID { get; set; }
        public Usuario user { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public AreaMantenimiento Area { get; set; }




      

    }
}
