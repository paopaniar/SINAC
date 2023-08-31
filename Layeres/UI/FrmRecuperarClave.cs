using SINAC.Layeres.BLL;
using SINAC.Layeres.DAL;
using SINAC.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINAC.Layeres.UI
{
    public partial class FrmRecuperarClave : Form
    {

        Usuario u = null;
        UsuarioBLL user = new UsuarioBLL();
        public static Usuario usRecuperar = null;
        public FrmRecuperarClave()
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
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                u = user.ObtenerPorId(this.textBox2.Text);
                //u = user.ObtenerPorId(FrmLogIn.usLog.CorreoElectronico);
              
               
                if (u != null)
                {
                        
                    UsuarioBLL logica = new UsuarioBLL();
                    u.Clave = Encriptar(textBox1.Text);
                    u.CorreoElectronico = this.textBox2.Text;
                    logica.Guardar(u);
                        MessageBox.Show("Clave guardada con éxito");

                    
                }
                else
                {
                    MessageBox.Show("Este usuario no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");

                    break;
                case 1:
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es");

                    break;


            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void FrmRecuperarClave_Load(object sender, EventArgs e)
        {

        }
    }
}
