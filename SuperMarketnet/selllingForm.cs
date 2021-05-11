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

namespace SuperMarketnet
{
    public partial class selllingForm : Form
    {
        public selllingForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc1\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void populate()
        {
            Con.Open();
            string query = "select prodName, prodQty from producttable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTable", Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(reader);
            /*CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;*/
            comboBox2.ValueMember = "catname";
            comboBox2.DataSource = dt;
            Con.Close();
        }
        private void populateBill()
        {
            Con.Close();
            Con.Open();
            string query = "select * from BillTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selllingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBill();
            FillCombo();
        }
        int flag = 0;
        private void sellDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            prodName.Text = sellDGV.SelectedRows[0].Cells[0].Value.ToString();
            prodPrice.Text = sellDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString()+"/"+ DateTime.Today.Month.ToString()+"/"+ DateTime.Today.Year.ToString(); 
        }

        int GrdTotal, n;

        private void button4_Click(object sender, EventArgs e)
        {
            if(billId.Text== "")
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into BillTable values('" + billId.Text + "','" + SellerName.Text + "','" + Datelbl.Text + "','" + Amount.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("order added succesfully");
                    Con.Close();
                    populateBill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SoonanSuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 100));
            e.Graphics.DrawString("Date: " + gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(100, 160));
            e.Graphics.DrawString("Codespace", new Font("Century Gothic", 25, FontStyle.Italic), Brushes.Red, new Point(230,230));

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Close();
            Con.Open();
            string query = "select Prodname, prodqty from producttable where prodcat='" + comboBox2.SelectedValue.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            if (prodName.Text == "" || prodQty.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(prodQty.Text) * Convert.ToInt32(prodPrice.Text);

                DataGridViewRow gridView = new DataGridViewRow();
                gridView.CreateCells(OrderDGV);
                gridView.Cells[0].Value = n + 1;
                gridView.Cells[1].Value = prodName.Text;
                gridView.Cells[2].Value = prodPrice.Text;
                gridView.Cells[3].Value = prodQty.Text;
                gridView.Cells[4].Value = Convert.ToInt32(prodQty.Text) * Convert.ToInt32(prodPrice.Text);
                OrderDGV.Rows.Add(gridView);
                n++;
                GrdTotal = GrdTotal + total;
                Amount.Text = Convert.ToString(GrdTotal);
            }
        }
    }
}
