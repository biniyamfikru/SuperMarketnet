using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketnet
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

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
                if(roleCb.SelectedItem.ToString() == "Admin")
                {
                    if(UNameTb.Text == "admin" || PassTb.Text == "admin")
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
            }
        }
    }
}
