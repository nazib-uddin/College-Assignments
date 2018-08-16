using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Extra_Credit
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Database.mdb";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Info where Username = '" + username.Text + "' and Password = '" + password.Text + "' ";
            OleDbDataReader dr = cmd.ExecuteReader();
            int count = 0;

            while (dr.Read())
            {
                count++;
            }

            if (count == 1)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Main ss = new Main();
                ss.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            con.Close();

        }
    }
}
