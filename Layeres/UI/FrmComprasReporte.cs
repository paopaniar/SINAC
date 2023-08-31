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

namespace SINAC.Layeres.UI
{
    public partial class FrmComprasReporte : Form
    {
        public FrmComprasReporte()
        {
            InitializeComponent();
        }

        private void FrmComprasReporte_Load(object sender, EventArgs e)
        {

           
            //var lista = BLL.ReservacionBLL.ObtenerTodos();
            //Reservacion todos = new Reservacion();
            //todos.FechaDeConservaciones = todos.FechaDeConservaciones;
            //todos.ID = 1;


            //lista.Insert(0, todos);


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value!= null)
            {
                Reservacion c = new Reservacion();
                this.tableHistorialCompras.Fill(dSHistorialCompras.TableHistorialCompras, c.FechaDeConservaciones);
                   

                this.reportViewer1.RefreshReport();
                
            }
        }
    }
}
