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
    public partial class userorder : Form
    {
        public userorder()
        {
            InitializeComponent();
            this.Icon = cafe_system.Properties.Resources.icon;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\96278\OneDrive\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void clear()
        {
            sellername.Text = "";
            quantity.Text = "";
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

        void filterByCategory()
        {
            con.Open();
            string query = "select * from ItemTbl where category ='"+catg.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            itemsGV.DataSource = ds.Tables[0];
            con.Close();
        }

        DataTable dataTable = new DataTable();
        int flag=0;
       
        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemsform itemsform = new itemsform();
            itemsform.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            usersform usersform = new usersform();
            usersform.Show();

        }
        private void userorder_Load(object sender, EventArgs e)
        {
            populate();
            dataTable.Columns.Add("orderNum", typeof(int));
            dataTable.Columns.Add("ItemName", typeof(string));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("UnitPrice", typeof(int));
            dataTable.Columns.Add("Total", typeof(int));
            orderGV.DataSource = dataTable;
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            sellername.Text = Form1.user;
        }
        
        
        int num=0;
        int price, total;
        string  cat,item;
        int sum = 0;

        private void catg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into ordersTbl values (" + number.Text + ",'" + date.Text + "','" + sellername.Text + "'," + amount.Text + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order successfully created");
            con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewOrder viewOrder = new viewOrder();
            viewOrder.Show();
        }

        private void itemsGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            item = itemsGV.CurrentRow.Cells[1].Value.ToString();
            cat = itemsGV.CurrentRow.Cells[2].Value.ToString();
            price = Convert.ToInt32(itemsGV.CurrentRow.Cells[3].Value.ToString());
            flag = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quantity.Text == "")
            {
                MessageBox.Show("What is the Quantityof Item?!");
            }
           else if (flag == 0)
            {
                MessageBox.Show("select the prodect to be orderd!");
            }
            
            else
            {
                
                num = num + 1;
                total = price *Convert.ToInt32( quantity.Text);
                dataTable.Rows.Add(num,item , cat, price, total);
                orderGV.DataSource = dataTable;
                flag = 0;
            }
            sum = sum + total;
            amount.Text =""+ sum ;
        }

       

       
    }
}
