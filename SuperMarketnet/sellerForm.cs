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
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc1\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into SellerTable values(" + sellerIdTb.Text + ",'" + sellerNameTb.Text + "'," + sellerAgeTb.Text + "," + sellerPhoneTb.Text + ",'" + sellerPassTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added succesfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prodBt_Click(object sender, EventArgs e)
        {
            productForm prod = new productForm();
            this.Hide();
            prod.Show();
        }
        private void populate()
        {
            Con.Close();
            Con.Open();
            string query = "select * from Sellertable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void sellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sellerIdTb.Text = sellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            sellerNameTb.Text = sellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            sellerAgeTb.Text = sellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            sellerPhoneTb.Text = sellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            sellerPassTb.Text = sellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void delBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerIdTb.Text == "")
                {
                    MessageBox.Show("Select category to delete");
                }
                else
                {
                    Con.Open();
                    String query = "delete from sellerTable where sellerId = " + sellerIdTb.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successfully deleted category");
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
            populate();
        }

        private void editBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellerIdTb.Text == "" || sellerNameTb.Text == "" || sellerAgeTb.Text == "" || sellerPhoneTb.Text == "" || sellerPassTb.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update sellerTable set sellerName='" + sellerNameTb.Text + "', sellerAge='" + sellerAgeTb.Text + "', sellerphone ='" + sellerPhoneTb.Text + "', sellerpassword='" + sellerPassTb.Text + "' where sellerId = '" + sellerIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("seller information edited successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
