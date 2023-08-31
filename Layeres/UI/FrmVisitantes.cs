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
    public partial class FrmVisitantes : Form
    {
        public FrmVisitantes()
        {
            InitializeComponent();
        }

        private void FrmVisitantes_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            
            // TODO: This line of code loads data into the 'dSVisitantes.Visitantes' table. You can move, or remove it, as needed.
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.visitantesTableAdapter.Fill(this.dSVisitantes.Visitantes);

            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
