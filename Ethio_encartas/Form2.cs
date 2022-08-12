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
    public partial class Form2 : Form
    {
        string imglocation = " ";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-VHP8HDU;Initial Catalog=EthioEncarta;Integrated Security=True;Pooling=False");
            try
            {
                byte[] image = null;
                System.IO.FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                con.Open();
                string query = "insert into finalProject(name,description,image) values('"
                    + textBox1.Text + "','" + textBox1.Text + "',@image)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@image", image));
                int n = cmd.ExecuteNonQuery();
                MessageBox.Show(n.ToString() + "data successfully entered");
                textBox1.Clear();
                textBox2.Clear();

            }catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }

        }
    }
}
