using SINAC.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SINAC.Layeres.Entities
{
    class CotizadorFacade
    {
        public CarritoCompras CrearReservacion(int cantidad, TipoMoneda moneda, MetodoPago metodo)
        {
            CarritoCompras carrito = new CarritoCompras();
            carrito.CantidadTickets = cantidad;
            carrito.moneda= moneda;
            carrito.metodoPago = metodo;
            //carrito.ListaVisitantes = new List<Visitantes>();
            //if (visitante)
            //{
            //    carrito.ListaVisitantes.Add(new Visitantes());
            //}

            return carrito;
        }
      
            public void GuardarXML(CarritoCompras carrito, string ruta)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(ruta))
                xmlDoc.Load(ruta);
            else
            {
                XmlDeclaration dec = xmlDoc.CreateXmlDeclaration("1.0", null, null);
                xmlDoc.AppendChild(dec);// Se crea la raiz

                string rutaXslt = Application.StartupPath + "\\Reservaciones.xslt";
                XmlProcessingInstruction xslt = xmlDoc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + rutaXslt + "\"");
                xmlDoc.AppendChild(xslt);

                XmlElement root = xmlDoc.CreateElement("Reservaciones");
                xmlDoc.AppendChild(root);
            }

           
            XmlElement raiz = xmlDoc.DocumentElement;
            XmlElement nodoCompra = xmlDoc.CreateElement("Compra");

            //nodoCompra.SetAttribute("ID", carrito.ID.ToString());

            XmlElement nodoTickets = xmlDoc.CreateElement("CantidadTickets");
            nodoTickets.SetAttribute("CantidadTickets", carrito.CantidadTickets.ToString());
            XmlElement nodoMoneda = xmlDoc.CreateElement("Moneda");
            nodoCompra.SetAttribute("Moneda", carrito.Moneda.ToString());
            XmlElement nodoMetodoPago = xmlDoc.CreateElement("MetodoPago");
            nodoCompra.SetAttribute("MetodoPago", carrito.MetodoPago.ToString());

            //foreach (var ad in carrito.ListaVisitantes)
            //{
            //    XmlElement xVisitante = xmlDoc.CreateElement("Visitante");
            //    xVisitante.InnerText = ad.NombresCompletos;
            //    xVisitante.AppendChild(xVisitante);
            //}
            XmlElement nodoMontoaPagar = xmlDoc.CreateElement("MontoaPagar");
            nodoCompra.SetAttribute("MontoaPagar", carrito.MontoaPagar.ToString());
            

            nodoCompra.AppendChild(nodoTickets);
            nodoCompra.AppendChild(nodoMoneda);
            nodoCompra.AppendChild(nodoMetodoPago);
            nodoCompra.AppendChild(nodoMontoaPagar);
            xmlDoc.DocumentElement.AppendChild(nodoCompra);


            xmlDoc.Save(ruta);


        }



        public void GuardarComoJson(CarritoCompras carrito, string ruta)
        {
            
            MemoryStream ms = new MemoryStream();

            DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(CarritoCompras));

            oDataContractJsonSerializer.WriteObject(ms, carrito);
            string datosJson = Encoding.Default.GetString(ms.ToArray());

            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                sw.WriteLine(datosJson);
            }
        }
    }
}
