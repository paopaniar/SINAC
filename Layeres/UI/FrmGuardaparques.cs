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
    public partial class FrmGuardaparques : Form
    {
        public FrmGuardaparques()
        {
            InitializeComponent();
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

                if ((TipoRol)this.cboRol.SelectedItem == TipoRol.guardaParques)
                {
                    user.CodRol = 2;
                }



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

        private void FrmGuardaparques_Load(object sender, EventArgs e)
        {
            cboNacionalidad.Items.Add(TipoNacionalidad.Nacional);
            cboNacionalidad.Items.Add(TipoNacionalidad.Extranjero);
            cboNacionalidad.SelectedIndex = 0;

            cboRol.Items.Add(TipoRol.guardaParques);
            cboRol.SelectedIndex = 2;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

                if ((TipoRol)this.cboRol.SelectedItem == TipoRol.guardaParques)
                {
                    user.CodRol = 2;
                }



                logica.Modificar(user);

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
    }
}
