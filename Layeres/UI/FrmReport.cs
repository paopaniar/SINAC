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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Areas' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            this.areaTableAdapter.Fill(this.dataSet1.Areas);

            this.reportViewer1.RefreshReport();
        }
    }
}
