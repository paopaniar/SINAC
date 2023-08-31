
using Microsoft.Reporting.WinForms;
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
using System.Windows.Forms;

namespace SINAC
{
    public partial class Facturación : Form
    {
        public Facturación()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSFacturapdf.PA_SeleccionarReservaPorUsuarioId' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Reservacion r = new Reservacion();
            r.ID_Usuario = "panipao0@gmail.com";
            this.PA_SeleccionarReservaPorUsuarioIdTableAdapter.Fill(this.DSFacturapdf.PA_SeleccionarReservaPorUsuarioId, r.ID_Usuario);

            this.reportViewer1.RefreshReport();

        }

        public void SavePDF(ReportViewer viewer, string savePath)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            SavePDF(this.reportViewer1, "Reporte.pdf");
        }
    }
}
