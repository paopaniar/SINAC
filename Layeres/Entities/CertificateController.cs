using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{
    class CertificateController
    {
        /// <summary>
        /// Muestra un cuadro de diálogo para seleccionar un certificado X.509 de una colección de certificados.
        /// </summary>
        /// <param name="store">Especifica el nombre del almacén del certificado X.509 que se va a abrir.</param>
        /// <param name="location">Especifica la ubicación del almacén de certificados X.509.</param>
        /// <param name="windowTitle">El título del cuadro de diálogo.</param>
        /// <param name="windowMsg">Un mensaje descriptivo para guiar al usuario. El mensaje se muestra en el cuadro de diálogo.</param>
        /// <returns></returns>
        public static X509Certificate2 SelectCert(StoreName store, StoreLocation location, string windowTitle, string windowMsg)
        {

            X509Certificate2 certSelected = null;
            X509Store x509Store = new X509Store(store, location);
            x509Store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection col = x509Store.Certificates;
            X509Certificate2Collection sel = X509Certificate2UI.SelectFromCollection(col, windowTitle, windowMsg, X509SelectionFlag.SingleSelection);

            if (sel.Count > 0)
            {
                X509Certificate2Enumerator en = sel.GetEnumerator();
                en.MoveNext();
                certSelected = en.Current;
            }

            x509Store.Close();

            return certSelected;
        }
    }
}
