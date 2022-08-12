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
    public partial class UserControl1 : UserControl
    {
        ethioEncarta ethioEncarta = new ethioEncarta();
        public static UserControl1 instance;
        public Label lbl;
        private bool on = true;
        public UserControl1()
        {
            InitializeComponent();
            instance = this;
            lbl = label3;
            timer1.Start();
            label3.Text = DateTime.Now.ToString("hh:mm:ss tt");
           
        }

        private void History_Click(object sender, EventArgs e)
        {
            Console.Beep();
            panel3.Controls.Clear();

            HistoryForms1 uc = new HistoryForms1();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Console.Beep();
            }
            panel3.Controls.Clear();
            Art uc = new Art();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Console.Beep();
            }
            panel3.Controls.Clear();
            PeoplesForm uc = new PeoplesForm();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(on)
            {
                Console.Beep();
            }
            panel3.Controls.Clear();

            calander uc = new calander();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Console.Beep();
            }
            panel3.Controls.Clear();
            Geography uc = new Geography();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Console.Beep();
            }
            panel3.Controls.Clear();
            Sicence uc = new Sicence();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Console.Beep();
            }
            panel3.Controls.Clear();
            Sport uc = new Sport();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Console.Beep();
            }
        }
    }
}
