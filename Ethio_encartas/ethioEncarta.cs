using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Ethio_encartas
{
    public partial class ethioEncarta : Form
    {
      
       private bool on = true;
       public static ethioEncarta instance;
       public Panel pnl;
        public ethioEncarta()
        { InitializeComponent();
            instance = this;
            pnl = panel4;
        }

        private void ethioEncarta_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeLable.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void art_litrutare_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
            Form2 uc = new Form2();         
            
            uc.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {             
              
        }   

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Tools_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void peopelsandsociety_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void onToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            on = true;
        }

        private void Calander_Click(object sender, EventArgs e)
        {
            if (on)
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

        private void Geography_Click(object sender, EventArgs e)
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

        private void sience_Click(object sender, EventArgs e)
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

        private void sport_Click(object sender, EventArgs e)
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

        private void offToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            on = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UserControl1 uc = new UserControl1();
            panel4.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLable.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

        
 
