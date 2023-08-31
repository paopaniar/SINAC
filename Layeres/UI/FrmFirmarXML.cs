using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINAC.Layeres.UI
{
    public partial class FrmFirmarXML : Form
    {
        // Representa un certificado X.509. En criptografía, X.509 es un estándar para infraestructuras de claves públicas
        X509Certificate2 certificate;
        public FrmFirmarXML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtFactura.Clear();
               
                    certificate = new X509Certificate2(@"Certificado\ANA ROJAS PRUEBA (FIRMA).pfx", "123");
                

                if (certificate != null)
                {
                    txtFactura.Text = certificate.Subject;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFirmarXML_Load(object sender, EventArgs e)
        {
            txtXml.Text = @"<Transaccion>
                                <TarjetaCredito>
                                    <Numero>5544220099338844</Numero>
                                    <Vencimiento>03/04/2022</Vencimiento>
                                </TarjetaCredito>
                            </Transaccion>";
        }

        private void btnFirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (certificate == null)
                {
                    MessageBox.Show("Debe seleccionar una factura", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtXml.Text))
                {
                    MessageBox.Show("Debe agregar el XML", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtiene la llave privada del certificado seleccionado
                RSA rsaKey = (RSA)certificate.PrivateKey;
                // Firma y muestra el Xml firmado
                txtXmlFirmado.Text = XmlController.SignXml(txtXml.Text, rsaKey);

                MessageBox.Show("Xml firmado con éxito", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (certificate == null)
                {
                    MessageBox.Show("Debe seleccionar una factura", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtXmlFirmado.Text))
                {
                    MessageBox.Show("Debe agregar el XML firmado", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtiene la llave privada del certificado seleccionado
                RSA rsaKey = (RSA)certificate.PrivateKey;
                // Verifica el Xml firmado
                bool result = XmlController.VerifyXml(txtXmlFirmado.Text, rsaKey);

                if (result)
                    MessageBox.Show("Xml válido", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xml NO válido", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
