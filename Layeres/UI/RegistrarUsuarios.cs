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

namespace SINAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                UsuarioBLL logica = new UsuarioBLL();

                Usuario user = new Usuario();
                user.Nombre = txtNombre.Text;
                user.Apellidos = txtApellidos.Text;
                user.Telefono = mskTxtTelefono.Text;

                if ((TipoNacionalidad)this.cboNacionalidad.SelectedItem == TipoNacionalidad.Nacional)
                {
                    user.Nacionalidad = 0;
                }
                else
                    user.Nacionalidad = 1;

                user.Nacimiento = dteFechaNacimiento.Value;
                user.Profesion = txtProfesion.Text;
                user.CorreoElectronico = txtCorreo.Text;
                user.Clave = Encriptar(txtClave.Text);

                if ((TipoRol)this.cboRol.SelectedItem == TipoRol.usuario)
                {
                    user.CodRol = 1;
                }
                else
                    user.CodRol = 0;
               


                logica.Guardar(user);

                MessageBox.Show("Usuario guardado con éxito", "SINAC", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
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


        public static string Encriptar(string password)
        {
            System.Security.Cryptography.HashAlgorithm hashValue = new
            System.Security.Cryptography.SHA1CryptoServiceProvider();

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);

            byte[] byteHash = hashValue.ComputeHash(bytes);

            hashValue.Clear();

            return (Convert.ToBase64String(byteHash));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboNacionalidad.Items.Add(TipoNacionalidad.Nacional);
            cboNacionalidad.Items.Add(TipoNacionalidad.Extranjero);
            cboNacionalidad.SelectedIndex = 0;

            cboRol.Items.Add(TipoRol.usuario);
            cboRol.Items.Add(TipoRol.Administrador);
            cboRol.Items.Add(TipoRol.guardaParques);
            cboRol.SelectedIndex = 1;
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
        this.Dispose();
            
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rol_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProfesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dteFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskTxtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
