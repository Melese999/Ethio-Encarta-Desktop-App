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
    public partial class Art : UserControl
    {
        public static Art instance;
        public String search;
        public Art()
        {
            InitializeComponent();
            instance = this;
                      
        }

        private void label2_Click(object sender, EventArgs e)
        {        
            if ("abebe" == search)
            {
                 MessageBox.Show("suvvvvvv");
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
