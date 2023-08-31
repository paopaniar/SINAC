using SINAC.Layeres.BLL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINAC
{
    public partial class FrmHistorialFechas : Form
    {
        public FrmHistorialFechas()
        {
            InitializeComponent();
        }

        private void FrmHistorialFechas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSHistorialFechas.SP_HistorialReporte' table. You can move, or remove it, as needed.
            var lista = ReservacionBLL.ObtenerTodos();
            Reservacion r = new Reservacion();
            
            if (dateTimePicker1.Value == null)
            {
                

                this.reportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            this.SP_HistorialReporteTableAdapter.Fill(this.DSHistorialFechas.SP_HistorialReporte, dateTimePicker1.Value);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
