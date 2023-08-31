using SINAC.Enums;
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

namespace SINAC.Layeres.UI
{
    public partial class FrmRerservacion : Form
    {
        AreaMantenimientoBLL logicaA = new AreaMantenimientoBLL();
        Reservacion reserva = new Reservacion();
        ReservacionBLL logica = new ReservacionBLL();
        Visitantes visita = new Visitantes();
        VisitantesBLL logicaVisitas = new VisitantesBLL();
        AreaMantenimiento area = new AreaMantenimiento();
        Usuario user = new Usuario() ;
        public FrmRerservacion(Usuario u)
        {
            InitializeComponent();

            user = u;
         
        }
        private int m = 10;
        private int s = 60;

        //private int num;
        private void FrmRerservacion_Load(object sender, EventArgs e)
        {
            TimeS.Text = "00:00";
            timer1.Start();
            int contador = 47;
            for (int i = 1; i < 500; i++)
            {
                contador = contador + 1;
                reserva.ID = contador;

            }



            txtNumero.Text = reserva.ID.ToString();
            timer1.Enabled = true;
            CargarTipoAreas();
            Refrescar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvRerservaciones.SelectedRows.Count > 0)
                {
                    AreaMantenimiento area = (AreaMantenimiento)dgvRerservaciones.SelectedRows[0].DataBoundItem;

                    reserva.FechaDeConservaciones = DateTime.Now;
                    reserva.ID_Usuario = FrmLogIn.usLog.CorreoElectronico;
                    reserva.Area = (AreaMantenimiento)cboTipoParque.SelectedItem;

                    FrmCarritoCompras f = new FrmCarritoCompras();
                    f.Show();
                    this.Hide();
                    logica.Guardar(reserva);
                    MessageBox.Show("Reservación seleccionada con éxito", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void Refrescar()
        {
            dgvRerservaciones.DataSource = AreaMantenimientoBLL.ObtenerTodos();


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

        private void dgvRerservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRerservaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRerservaciones.SelectedRows.Count > 0)
            {
                //Entities.AreaMantenimiento area = (Entities.AreaMantenimiento)dgvRerservaciones.SelectedRows[0].DataBoundItem;
                //var art = dgvRerservaciones.SelectedRows[0].DataBoundItem as AreaMantenimiento;
                //cboTipoParque.SelectedValue = art.Tipo;

            }
        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            logicaA.Filtrar(area.Tipo);
        }

        private void cboTipoParque_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cboTipoParque.SelectedItem.Equals(Enums.TipoArea.MonumentosNacionales))
            //{
            //    dgvRerservaciones.DataSource = BLL.AreaMantenimientoBLL.ObtenerPorId("");
            //}
            //else if (cmbTipoArea.SelectedItem.Equals(Entities.AreaDeConservacion.TipoArea.Refugio.ToString()))
            //{
            //    dgvAreasDeConservacion.DataSource = BLL.AreaDeConservacionBLL.SeleccionarAreaPorTipo(Entities.AreaDeConservacion.TipoArea.Refugio.ToString());
            //}
            //else if (cmbTipoArea.SelectedItem.Equals(Entities.AreaDeConservacion.TipoArea.Reserva.ToString()))
            //{
            //    dgvAreasDeConservacion.DataSource = BLL.AreaDeConservacionBLL.SeleccionarAreaPorTipo(Entities.AreaDeConservacion.TipoArea.Reserva.ToString());
            //}
            //BLL.AreaMantenimientoBLL logica = new BLL.AreaMantenimientoBLL();
            //if (cboTipoParque.SelectedIndex == 0)
            //{
            //    dgvRerservaciones.DataSource = logica.SeleccionarPorTipo("Monumento Nacional");

            //}
            //else if (cboTipoParque.SelectedIndex == 1)
            //{
            //    dgvRerservaciones.DataSource = logica.SeleccionarPorTipo("Parques Nacionales");
            //}
            //else if (cboTipoParque.SelectedIndex == 2)
            //{
            //    dgvRerservaciones.DataSource = logica.SeleccionarPorTipo("Reservaciones Biólogicas");
            //}

        }

        private void CargarTipoAreas()
        {

            area = (AreaMantenimiento)cboTipoParque.SelectedItem;
            cboTipoParque.DataSource = BLL.AreaMantenimientoBLL.ObtenerTodos();
            cboTipoParque.DisplayMember = "Tipo";
            //cboTipoParque.Items.Add(Enums.TipoArea.MonumentosNacionales);
            //cboTipoParque.Items.Add(Enums.TipoArea.ParquesNacionales);
            //cboTipoParque.Items.Add(Enums.TipoArea.ReservasBiologicas);

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTotal.Text = reserva.MontoaPagar.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario fu = new FrmUsuario();
            fu.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
