using SINAC.Enums;
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
    public partial class FrmPruebaPaises : Form
    {
        public FrmPruebaPaises()
        {
            InitializeComponent();
        }

        private void FrmPruebaPaises_Load(object sender, EventArgs e)
        {
            SRHello.HelloEndpointClient ws = new SRHello.HelloEndpointClient();
            var request = new SRHello.helloRequest();
            List<Paises> reques = new List<Paises>();

            foreach (var r in reques)
            {


                reques.Add(r);
            }

            comboBox1.Items.Add(reques);
        }
    }
}
