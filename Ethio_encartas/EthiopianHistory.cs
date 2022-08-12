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
    public partial class EthiopianHistory : UserControl
    { 
        public EthiopianHistory()
        {

            InitializeComponent();           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHP8HDU;Initial Catalog=EthioEncarta;Integrated Security=True;Pooling=False");
            try
            {
                String sql = "select  *from finalProject";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(sql, con);
                    SqlDataReader read = command.ExecuteReader();
                    
                    while (read.Read())
                    {
                        label1.Text = read[0].ToString();
                        textBox1.Text = read[1].ToString();
                        byte[] img = (byte[])(read[2]);
                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = Image.FromStream(ms);
                          


                        }
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show("unsuccessfull");
                }
                       
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textfetch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
