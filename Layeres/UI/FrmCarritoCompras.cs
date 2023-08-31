using Microsoft.Reporting.WebForms;
using Microsoft.Win32;
using SINAC.Enums;
using SINAC.Layeres.BLL;
using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace SINAC.Layeres.UI
{
    public partial class FrmCarritoCompras : Form
    {
        public FrmCarritoCompras()
        {
            InitializeComponent();
        }
        private int m = 10;
        private int s = 60;
        double total = 0;

        Reservacion reserva = new Reservacion();
        CarritoCompras carrito = new CarritoCompras();
        Visitantes visita = new Visitantes();
        VisitantesBLL logicaVisitas = new VisitantesBLL();
        AreaMantenimiento area = new AreaMantenimiento();
        Usuario user = new Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                carrito.ID = Convert.ToInt32(txtCVV.Text);
                carrito.CantidadTickets = Convert.ToInt32(NmrUpdowm.Value);
                carrito.IdReserva = reserva.ID;

                if ((TipoMoneda)this.cboTipoMoneda.SelectedItem == TipoMoneda.Colones)
                {
                    carrito.Moneda = 0;
                    carrito.MontoaPagar = carrito.CantidadTickets * area.Precio;
                }
                else
                {
                    carrito.Moneda = 1;
                    carrito.MontoaPagar = (carrito.CantidadTickets * area.Precio) * 640;

                }
                //TimeS.Text = reserva.Tiempo.ToString();
                if ((MetodoPago)this.cboTipoPago.SelectedItem == MetodoPago.SinpeMovil)
                {
                    carrito.MetodoPago = 2;
                }
                if ((MetodoPago)this.cboTipoPago.SelectedItem == MetodoPago.TarjetaCredito)
                {
                    carrito.MetodoPago = 0;
                }
                if ((MetodoPago)this.cboTipoPago.SelectedItem == MetodoPago.TarjetaDebito)
                {
                    carrito.MetodoPago = 1;
                }
                if ((Paises)this.cboPais.SelectedItem == Paises.CostaRica)
                {
                    carrito.Pais = 0;
                }

            }
            catch (Exception)
            {
               
                throw;
            }
          
            Tarjeta tarjeta = new Tarjeta();
            try
            {
                tarjeta.Cvv = Convert.ToInt32(txtCVV.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el CVV de su Tarjeta", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
           
            CarritoComprasDAL.InsertarCompra(carrito);
            MessageBox.Show("Compra Finalizada con éxito", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           
        }

        private void FrmCarritoCompras_Load(object sender, EventArgs e)
        {
            TimeS.Text = "00:00";
            timer1.Start();
            timer1.Enabled = true;
            cboTipoPago.Items.Add(MetodoPago.SinpeMovil);
            cboTipoPago.Items.Add(MetodoPago.TarjetaCredito);
            cboTipoPago.Items.Add(MetodoPago.TarjetaDebito);
            cboTipoMoneda.Items.Add(TipoMoneda.Colones);
            cboTipoMoneda.Items.Add(TipoMoneda.Dolares);
            cboPais.Items.Add(Paises.CostaRica);

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(visita.Tiquete.ToString(), 70);
            ReservacionBLL logica = new ReservacionBLL();
            //logica.SeleccionarPorId(FrmLogIn.usLog.CorreoElectronico);
            //dgvRerserva.DataSource = logica.SeleccionarPorUser(FrmLogIn.usLog.CorreoElectronico);


        }

      
        private void button2_Click(object sender, EventArgs e)
        {
         
            try
            {
                List<Visitantes> lista = new List<Visitantes>();
                visita.NombresCompletos = txtNombres.Text;
                visita.IDVisitantes = Convert.ToInt32(txtIdentificacion.Text);
                visita.ID_Usuario= FrmLogIn.usLog.CorreoElectronico;
                visita.Tiquete = 12345;

                //foreach (Visitantes inc in lstVisitas.Items)
                //{
                //    lista.Add(inc);
                  
                   

                //}
           
              
                logicaVisitas.GuardarVisitante(visita);
                MessageBox.Show("Visitante guardado con éxito", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombres.Text = " ";
                txtIdentificacion.Text = " ";
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void MostrarXml(string ruta)
        {
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.Arguments = ruta;
            info.FileName = "iexplore.exe";
            proceso.StartInfo = info;
            proceso.Start();
        }

        public void Actualizar(Visitantes visitante)
        {
            //lstVisitas.Items.Add(visitante);
        }

        private void TimeS_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == 0)
            {
                m = m - 1;
            }
            if (m == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Finalizó el tiempo", "Ingrese nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            TimeS.Text = "0" + m + ":" + "0" + s;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void cboTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //txtTotal.Text = carrito.MontoaPagar.ToString();
            if ((TipoMoneda)cboTipoMoneda.SelectedItem==0)
            {
                total = 1000 * (Convert.ToInt32(NmrUpdowm.Value));
               
            }
            else
            {
                 total = 1000 * (Convert.ToInt32(NmrUpdowm.Value)) /641;
               
            }
            txtTotal.Text = total.ToString();
        }
           

        private void historialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            CotizadorFacade factory = new CotizadorFacade();
            CarritoCompras _carrito;
            _carrito = factory.CrearReservacion((int)NmrUpdowm.Value, 
                (TipoMoneda)cboTipoMoneda.SelectedItem, 
                (MetodoPago)cboTipoPago.SelectedItem);

            txtTotal.Text = carrito.MontoaPagar.ToString();

            if (_carrito != null)
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    factory.GuardarXML(_carrito, saveFileDialog1.FileName);
                    MessageBox.Show("Información guardada con éxito!", "Guardar");
                    MostrarXml(saveFileDialog1.FileName);
                    factory.GuardarComoJson(_carrito, saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.Length - 4) + ".json");
                }
            }
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
       

        }

      
        

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void generarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SavePDF(this.reportViewer1, "Reporte.pdf");
            Facturación f = new Facturación();
            f.Show();
        }

        private void lstVisitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (lstVisitas.SelectedItem != null)
            //    {
            //        Visitantes visitas = lstVisitas.SelectedItem as Visitantes;
            //        Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //        pictureBox1.Image = qrcode.Draw(visitas.Tiquete.ToString(), 70);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
       



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void firmarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFirmarXML xml = new FrmFirmarXML();
            xml.Show();
        }

        private void dgvRerserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
