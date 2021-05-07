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

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selllingForm_Load(object sender, EventArgs e)
        {
            populate();
        }
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
                Amount.Text = GrdTotal + " Birr";
            }
        }
    }
}
