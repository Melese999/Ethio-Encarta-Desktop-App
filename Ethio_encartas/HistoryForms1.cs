using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ethio_encartas
{
    public partial class HistoryForms1 : UserControl
    {
        public Panel pp;
        public HistoryForms1()
        {
            InitializeComponent();
            pp =
            ethioEncarta.instance.pnl;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pp.Controls.Clear();
            EthiopianHistory ee = new EthiopianHistory();
            pp.Controls.Add(ee);
            ee.BringToFront();
            ee.Show();
          
        }

        private void HistoryForms1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
