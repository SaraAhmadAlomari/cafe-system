using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafe_system
{
    public partial class usersform : Form
    {
        public usersform()
        {
            InitializeComponent();
            this.Icon = cafe_system.Properties.Resources.icon;
        }
        SqlConnection con =new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\96278\OneDrive\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            userGV.DataSource = ds.Tables[0];
            con.Close();
        }
        void clear()
        {
            username.Text = "";
            phone.Text = "";
            password.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            userorder userorder = new userorder();
            userorder.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemsform itemsform = new itemsform();
            itemsform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
             string query="insert into UsersTbl values ('"+username.Text+"','"+phone.Text+"','"+password.Text+"')";
            
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("user successfully created");
            con.Close();
            populate();
            clear();
        }

        private void usersform_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void userGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            username.Text = userGV.CurrentRow.Cells[0].Value.ToString();
            phone.Text = userGV.CurrentRow.Cells[1].Value.ToString();
            password.Text= userGV.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(username.Text=="")
            {
                MessageBox.Show("Select the user to be deleted");
            }
            else
            {
                con.Open();
                string query="delete from UsersTbl where Uname ='"+username.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                con.Close();
                populate();
            }
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (username.Text == ""||phone.Text==""||password.Text=="")
            {
                MessageBox.Show("Fill All Filed");
            }
            else
            {
                con.Open();
                string query = "update UsersTbl set Uname ='" + username.Text + "',Upassword='"+password.Text+
                   "'where Uphone='"+phone.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
                con.Close();
                populate();
            }
            clear();
        }
    }
}
