using SINAC.Enums;
using SINAC.Layeres.BLL;
using SINAC.Layeres.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SINAC.Layeres.UI
{
    public partial class Area_de_Mantenimiento : Form
    {

        AreaMantenimientoBLL logica = new AreaMantenimientoBLL();
        AreaMantenimiento area = new AreaMantenimiento();
        public Area_de_Mantenimiento(Usuario u)
        {
            InitializeComponent();
        }
       
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
                try
            {
               
                    //AreaMantenimiento area = (AreaMantenimiento)dvgArea.SelectedRows[0].DataBoundItem;
                    area.Codigo = int.Parse(txtCodigo.Text);
                    area.Nombre = txtNombre.Text;
                    area.SitioWeb = txtSitio.Text;
                    area.Horario = dteHorarios.Value;
                    area.Disponibilidad = int.Parse(txtDisponibilidad.Text);
                    area.Precio = int.Parse(txtPrecio.Text);

                    if ((TipoArea)this.cboTipoArea.SelectedItem == Enums.TipoArea.MonumentosNacionales)
                    {
                        area.Tipo = "Monumento Nacional";
                    }
                    else
                    {
                        if ((TipoArea)this.cboTipoArea.SelectedItem == Enums.TipoArea.ParquesNacionales)
                        {
                            area.Tipo = "Parques Nacionales";
                        }
                        else
                        {
                            area.Tipo = "Reservaciones Biólogicas";
                        }
                    }
                    if (this.comboBox1.SelectedIndex == 0)
                    {
                        area.Hora = "Grupo A: 8.00";
                    }

                    if (this.comboBox1.SelectedIndex == 1)
                    {
                        area.Hora = "Grupo B: 9.00";
                    }
                    if (this.comboBox1.SelectedIndex == 2)
                    {
                        area.Hora = "Grupo C: 10.00";
                    }

                    if (this.comboBox1.SelectedIndex == 3)
                    {
                        area.Hora = "Grupo D: 11:00";
                    }
                    if (this.comboBox1.SelectedIndex == 4)
                    {
                        area.Hora = "Grupo E: 12:00";
                    }
                    if (this.comboBox1.SelectedIndex == 5)
                    {
                        area.Hora = "Grupo F: 13:00";
                    }
                    if (this.comboBox1.SelectedIndex == 6)
                    {
                        area.Hora = "Grupo G: 14:00";
                    }

                    Image imagen = pictureBox1.Image;
                    area.Foto = Convertir_Imagen_Bytes(imagen);

                    logica.Guardar(area);
                    Refrescar();

                    MessageBox.Show("Area guardada con éxito", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show(appEx.Message, "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error no controlado: " + ex.Message, "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refrescar()
        {
            // dgvCategorias.DataSource = BLL.CategoriaBLL.ObtenerTodos();
            dvgArea.DataSource = Layeres.BLL.AreaMantenimientoBLL.ObtenerTodos();
        }
        private void Area_de_Mantenimiento_Load(object sender, EventArgs e)
        {
            cboTipoArea.Items.Add(Enums.TipoArea.ParquesNacionales);
            cboTipoArea.Items.Add(Enums.TipoArea.ReservasBiologicas);
            cboTipoArea.Items.Add(Enums.TipoArea.MonumentosNacionales);
            comboBox1.Items.Add("Grupo A: 8:00");
            comboBox1.Items.Add("Grupo B: 9:00");
            comboBox1.Items.Add("Grupo C: 10:00");
            comboBox1.Items.Add("Grupo D: 11:00");
            comboBox1.Items.Add("Grupo E: 12:00");
            comboBox1.Items.Add("Grupo F: 13:00");
            comboBox1.Items.Add("Grupo G: 14:00");

            SetMyCustomFormat();
            Refrescar();
        }

        private void dvgArea_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgArea.SelectedRows.Count > 0)
            {
                Entities.AreaMantenimiento area = (Entities.AreaMantenimiento)dvgArea.SelectedRows[0].DataBoundItem;
                this.txtCodigo.Text = area.Codigo.ToString();
                this.txtNombre.Text = area.Nombre;
                this.txtSitio.Text = area.SitioWeb;
                this.txtDisponibilidad.Text =area.Disponibilidad.ToString();
                dteHorarios.Value = area.Horario.Date;
                cboTipoArea.SelectedItem = area.Tipo;
                comboBox1.SelectedItem = area.Hora;
                pictureBox1.Image = Convertir_Bytes_Imagen(area.Foto);
               






            }
        }

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

         public static Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dvgArea.SelectedRows.Count > 0)
                {
                   
                    area.Codigo = int.Parse(txtCodigo.Text);
                    area.Nombre = txtNombre.Text;
                    area.SitioWeb = txtSitio.Text;
                    area.Horario = dteHorarios.Value;
                    area.Disponibilidad = int.Parse(txtDisponibilidad.Text);
                    area.Precio = int.Parse(txtPrecio.Text);
                    if ((TipoArea)this.cboTipoArea.SelectedItem == Enums.TipoArea.MonumentosNacionales)
                    {
                        area.Tipo = "Monumento Nacional";
                    }
                    else
                    {
                        if ((TipoArea)this.cboTipoArea.SelectedItem == Enums.TipoArea.ParquesNacionales)
                        {
                            area.Tipo = "Parques Nacionales";
                        }
                        else
                        {
                            area.Tipo = "Reservaciones Biólogicas";
                        }
                    }
                    if (this.comboBox1.SelectedIndex == 0)
                    {
                        area.Hora = "Grupo A: 8.00";
                    }

                    if (this.comboBox1.SelectedIndex == 1)
                    {
                        area.Hora = "Grupo B: 9.00";
                    }
                    if (this.comboBox1.SelectedIndex == 2)
                    {
                        area.Hora = "Grupo C: 10.00";
                    }

                    if (this.comboBox1.SelectedIndex == 3)
                    {
                        area.Hora = "Grupo D: 11:00";
                    }
                    if (this.comboBox1.SelectedIndex == 4)
                    {
                        area.Hora = "Grupo E: 12:00";
                    }
                    if (this.comboBox1.SelectedIndex == 5)
                    {
                        area.Hora = "Grupo F: 13:00";
                    }
                    if (this.comboBox1.SelectedIndex == 6)
                    {
                        area.Hora = "Grupo G: 14:00";
                    }
                    Image imagen = pictureBox1.Image;
                    area.Foto = Convertir_Imagen_Bytes(imagen);

                    logica.Guardar(area);
                    Refrescar();


                    MessageBox.Show("Area modificada con éxito");
                }
                else
                {
                    MessageBox.Show("Seleccione el area que desea modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dvgArea.SelectedRows.Count > 0)
                {
                    AreaMantenimiento area = (AreaMantenimiento)dvgArea.SelectedRows[0].DataBoundItem;
                    var result = MessageBox.Show("Seguro que desea eliminar el area en conservación?", "Pregunta", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        logica.Eliminar(area.Codigo);

                        Refrescar();
                        MessageBox.Show("El area en conservación se removio existosamente");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el area que desea eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Refrescar();
            }
        }

        private void dteHorarios_ValueChanged(object sender, EventArgs e)
        {

        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dteHorarios.Format = DateTimePickerFormat.Custom;
            dteHorarios.CustomFormat = "MMMM dd, yyyy - dddd";
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraficos f = new FrmGraficos();
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPruebaReport x = new FrmPruebaReport();
            x.Show();
        }

        private void visitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisitantes c = new FrmVisitantes();
            c.Show();
        }

        private void cboTipoArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregarUnPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 u = new Form1();
            u.Show();
        }

        private void dvgArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void historialFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorialFechas f = new FrmHistorialFechas();
            f.Show();
        }
    }

}
