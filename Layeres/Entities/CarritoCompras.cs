using SINAC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{/// <summary>
 /// Representa un Carrito
 /// </summary>
    public class CarritoCompras
    {
        public int ID { get; set; }
        public int IdReserva { get; set; }
        public int CantidadTickets { get; set; } 
        public long MontoaPagar { get; set; }
        public int Moneda { get; set; }
        public int MetodoPago { get; set; }
        public int Pais { get; set; }
        public string NombreTarjetaHabiente { get; set; }
        public int CVV { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public Reservacion Reserva { get; set; }

        public List<Visitantes> ListaVisitantes { get; set; }
        public TipoMoneda moneda { get; set; }
        public MetodoPago metodoPago { get; set; }
        public void AgregarAdicional(Visitantes visitante)
        {
            ListaVisitantes.Add(visitante);
        }
       
    }
}
