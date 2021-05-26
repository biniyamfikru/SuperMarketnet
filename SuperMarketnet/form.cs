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
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        public static string sellerName = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc1\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PassTb.Text = "";
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Please enter your username and pass");
            }
            else
            {
                if(roleCb.SelectedIndex > -1)
                {
                    if(roleCb.SelectedItem.ToString() == "Admin")
                    {
                        if (UNameTb.Text == "admin" || PassTb.Text == "admin")
                        {
                            productForm prod = new productForm();
                            this.Hide();
                            prod.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password. PLease try again!");
                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(8) from sellertable where sellername='" + UNameTb.Text + "' and sellerpassword ='" + PassTb.Text + "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            sellerName = UNameTb.Text;
                            selllingForm sForm = new selllingForm();
                            this.Hide();
                            sForm.Show();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                        }
                        Con.Close();
                    }
                    
                }

                else
                {
                    MessageBox.Show("Please select your role");
                }

            }
        }
    }
}
