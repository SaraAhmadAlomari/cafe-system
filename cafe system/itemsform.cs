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
    public partial class itemsform : Form
    {
        public itemsform()
        {
            InitializeComponent();
            this.Icon = cafe_system.Properties.Resources.icon;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\96278\OneDrive\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void clear()
        {
            name.Text = "";
            price.Text = "";
           number.Text = "";
        }
        void populate()
        {
            con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            itemsGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            userorder userorder = new userorder();
            userorder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersform usersform = new usersform();
            usersform.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || number.Text == "" || price.Text == "")
            {
                MessageBox.Show("Fill All Filed");
            }
            else
            {
                con.Open();
                string query = "insert into ItemTbl values (" + number.Text + ",'" + name.Text + "','" + catg.SelectedItem.ToString() + "','"+price.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Added successfully");
                con.Close();
                populate();
                clear();
            }
        }

        private void itemsform_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void itemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            number.Text = itemsGV.CurrentRow.Cells[0].Value.ToString();
            name.Text = itemsGV.CurrentRow.Cells[1].Value.ToString();
            catg.SelectedItem = itemsGV.CurrentRow.Cells[2].Value.ToString();
            price.Text = itemsGV.CurrentRow.Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (number.Text == "")
            {
                MessageBox.Show("Select item number to be deleted");
            }
            else
            {
                con.Open();
                string query = "delete from ItemTbl where itemNumber ='" + number.Text + "'";
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
            if (name.Text == "" || number.Text == "" || price.Text == ""||catg.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Fill All Filed");
            }
            else
            {
                con.Open();
                string query = "update ItemTbl set itemName ='" + name.Text + "',pricce='" + price.Text+ "',category='" + catg.SelectedItem.ToString()+
                   "'where itemNumber='" + number.Text + "'";
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
