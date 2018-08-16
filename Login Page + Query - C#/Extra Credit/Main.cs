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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace Extra_Credit
{
    public partial class Main : Form
    {
        private OleDbConnection con = new OleDbConnection();

        int count;

        public Main()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Database.mdb";
     
        }


        private void incidentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incidentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);


        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Incidents' table. You can move, or remove it, as needed.
            this.incidentsTableAdapter1.Fill(this.databaseDataSet.Incidents);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "INSERT INTO Incidents ([Incident Report No],[Category of Incident],[Location]) VALUES ( @inreno, @catofin, @loc) ";
                command.Parameters.AddWithValue("@Incident Report No", inreno.Text);
                command.Parameters.AddWithValue("@Category of Incident", catofin.Text);
                command.Parameters.AddWithValue("@Location", loc.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            con.Close();

        }

        private void search_Click(object sender, EventArgs e)
        {

            count = 0;
            con.Open();
            OleDbCommand command = con.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from [Incidents] where [Category of Incident]='" + srch.Text + "'";
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt);

            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            con.Close();


            if (count == 0)
            {
                MessageBox.Show("Not Found");
            }

        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

            {
                DataTable table = new DataTable();
                con.Open();

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                        dataGridView1.Rows.Remove(row);
                }
                MessageBox.Show("Data Deleted");
               con.Close();
              

            }

            else

                MessageBox.Show("Error");
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void incidentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void incidentsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void summary_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "select * from [Summary Report] ";
                cmd.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                incidentsBindingSource.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }


        private void load_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "select * from [Summary Report] ";
                cmd.CommandText = query;


                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Refresh();
                    chart1.Series["Series1"].Points.AddXY(reader["Category of Incident"].ToString(), reader["CountOfCategory of Incident"].ToString());
                }
                con.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }


        }
    }
}
