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
    public partial class viewOrder : Form
    {
        public viewOrder()
        {
            InitializeComponent();
            this.Icon = cafe_system.Properties.Resources.icon;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\96278\OneDrive\Documents\cafedb.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            con.Open();
            string query = "select * from ordersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bulider = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            orderGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewOrder_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("--------summry orders----------",new Font("Abeezee", 25,FontStyle.Bold),Brushes.Green,new Point(200,40));
            e.Graphics.DrawString("Number:" + orderGV.CurrentRow.Cells[0].Value.ToString(), new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(120,135));
            e.Graphics.DrawString("Date:" + orderGV.CurrentRow.Cells[1].Value.ToString(), new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(120,170));
            e.Graphics.DrawString("Seller:" + orderGV.CurrentRow.Cells[2].Value.ToString(), new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(120,205));
            e.Graphics.DrawString("Amount:" + orderGV.CurrentRow.Cells[3].Value.ToString(), new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(120,240));
        }


        private void orderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
