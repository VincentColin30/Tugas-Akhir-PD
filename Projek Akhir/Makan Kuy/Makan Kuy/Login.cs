using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Makan_Kuy
{
    public partial class Login : Form
    {
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public MySqlDataReader dr;
        public DataTable dt;
        public string str;
        public void bukakoneksi()
        {
            str = "server=localhost;uid=root;database=makankuy";
            conn = new MySqlConnection(str);

            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("tidak terkoneksi");
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string username;
        private void button1_Click(object sender, EventArgs e)
        {
            bukakoneksi();
            da = new MySqlDataAdapter("SELECT COUNT(*) FROM login WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'", conn);
            dt = new DataTable(); 
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usernama Atau Password Anda Salah");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
