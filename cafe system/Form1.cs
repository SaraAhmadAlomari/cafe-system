using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = cafe_system.Properties.Resources.icon;

        }
       
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\96278\OneDrive\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            guestorder guestorder = new guestorder();
            guestorder.Show();
        }
        public static string user;
        private void button1_Click(object sender, EventArgs e)
        {
            user = name.Text;
            if (name.Text == "" || password.Text == "")
            {
                MessageBox.Show("Enter user name or password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sql = new SqlDataAdapter("select count(*) from UsersTbl where Uname='"+name.Text+"'and Upassword='"+password.Text+"'",con);
                DataTable tb = new DataTable();
                sql.Fill(tb);
                if (tb.Rows[0][0].ToString() == "1")
                {
                    userorder userorder = new userorder();
                    userorder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong User or password");
                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
        
    }
}
