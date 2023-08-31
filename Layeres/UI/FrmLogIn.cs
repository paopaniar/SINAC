using SINAC.Layeres.BLL;
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
    public partial class FrmLogIn : Form
    {
        
        


        Usuario usuario = null;
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        public static Usuario usLog = null;
        public FrmLogIn()
        {
            InitializeComponent();
           
            //Idioma.Controles(this);
            //this.Text = Idioma.info[""];
        }
        bool flag = true;

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

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

        private void btnRegistarse_Click(object sender, EventArgs e)
        {
            FrmUsuario f = new FrmUsuario();
            f.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                flag = true;
                if (this.txtCorreo.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar su correo electrónico", "Mensaje");
                    flag = false;
                }
                if (this.txtClave.Text.Length == 0)
                {
                    MessageBox.Show("Debe ingresar su clave", "Mensaje");
                    flag = false;
                }

                if (flag)
                {
                    usuario = usuarioBLL.ObtenerPorId(this.txtCorreo.Text);
                    if (usuario != null)
                    {

                        if (usuario.Clave == Encriptar(this.txtClave.Text))
                        {
                            usLog = usuario;
                            usLog.CorreoElectronico = this.txtCorreo.Text;
                        
                            if (usuario.CodRol == 0)//admin == 0
                            {
                                Area_de_Mantenimiento f = new Area_de_Mantenimiento(usuario);
                                f.Show();
                            }
                            if (usuario.CodRol == 1)
                            {
                                FrmRerservacion a = new FrmRerservacion(usuario);
                                a.Show();
                            }
                            if (usuario.CodRol == 2)
                            {
                                Area_de_Mantenimiento a = new Area_de_Mantenimiento(usuario);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Clave incorrecta");

                        }
                    }
                    else
                    {
                        MessageBox.Show("No  se puede reconocer su usuario");
                    }
                }
            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRecuperarClave rec = new FrmRecuperarClave();
            rec.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        //private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Idioma.cambiarIdioma("es.txt");
            
        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
    }
}
