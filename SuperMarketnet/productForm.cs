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
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc1\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            CatCb.ValueMember = "CatName";
            CatCb.DataSource = dt;
            Con.Close();
        }
        private void productForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoryForm cat = new categoryForm();
            this.Hide();
            cat.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into ProductTable values(" + prodIdTb.Text + ",'" + prodNameTb.Text + "'," + prodQuanTb.Text+ "," + prodPriceTb.Text + ",'" + CatCb.SelectedValue.ToString()+ "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added succesfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from producttable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodIdTb.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            prodNameTb.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            prodQuanTb.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            prodPriceTb.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellerForm seller = new sellerForm();
            this.Hide();
            seller.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodIdTb.Text == "")
                {
                    MessageBox.Show("Select product to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from productTable where prodId = " + prodIdTb.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successfully deleted product");
                    Con.Close();
                    populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodIdTb.Text == "" || prodNameTb.Text == "" || prodQuanTb.Text == "" ||  prodPriceTb.Text == "" || CatCb.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTable set prodName='" + prodNameTb.Text + "', prodqty='" + prodQuanTb.Text + "', prodprice='" + prodPriceTb.Text + "', prodcat='" + CatCb.SelectedValue.ToString() + "' where prodId = '" + prodIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product edited successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from producttable where prodcat='"+comboBox2.SelectedValue.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            form homePage = new form(); 
            this.Hide();
            homePage.Show();
        }
    }
}
