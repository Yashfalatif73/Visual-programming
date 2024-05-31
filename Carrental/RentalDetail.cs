using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Carrental
{
    public partial class RentalDetail : Form
    {
        public RentalDetail()
        {
            InitializeComponent();
            Rentalload();
            carload();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarRentalDB;Integrated Security=True");


        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql1;
        bool Mode = true;
        string id;

        public void carload()
        {
            cmd = new SqlCommand("Select * from Car", con);
            con.Open();
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                int value = dr.GetInt32(dr.GetOrdinal("CarId"));
                txtcarsid.Items.Add(value);

            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            // string rentalid = txtrentalid.Text;
            int carid = (int)txtcarsid.SelectedItem;
            string custid = txtcustid.Text;
            string custname = txtcustname.Text;
            decimal fee = decimal.Parse(txtfee.Text);
            DateTime rentaldate = txtdate.Value;
            DateTime duedate = txtdue.Value;

            //string duedate = txtdue.Value.Date.ToString("yyyy-MM-dd");








            sql = "INSERT into Rental_Detail(CarId,CustomerId,CustomerName,RentalDate,ReturnDate,Fee) Values(@CarId,@CustomerId,@CustomerName,@RentalDate,@ReturnDate,@Fee )";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CarId", carid);
            cmd.Parameters.AddWithValue("@CustomerId", custid);
            cmd.Parameters.AddWithValue("@CustomerName", custname);
            cmd.Parameters.AddWithValue("@RentalDate", rentaldate);
            cmd.Parameters.AddWithValue("@ReturnDate", duedate);
            cmd.Parameters.AddWithValue("@Fee", fee);



            cmd.ExecuteNonQuery();





            sql1 = "update car set Available =  'No' Where CarId = @carid";

            cmd1 = new SqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("@CarId", carid);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Record Added");
            con.Close();
            Rentalload();

        }

        private void RentalDetail_Load(object sender, EventArgs e)
        {

        }

        private void txtcarid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from Car where CarId = '" + txtcarsid.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();



            if (dr.Read())
            {
                string aval;
                aval = dr["Available"].ToString();
                label11.Text = aval;
                if (aval == "no")
                {
                    txtcustid.Enabled = false;
                    txtcustname.Enabled = false;
                    txtfee.Enabled = false;
                    txtdate.Enabled = false;
                    txtdue.Enabled = false;


                }
                else
                {
                    txtcustid.Enabled = true;
                    txtcustname.Enabled = true;
                    txtfee.Enabled = true;
                    txtdate.Enabled = true;
                    txtdue.Enabled = true;
                }

            }
            else
            {
                label9.Text = "Car Not available";
            }
            con.Close();
        }



        public void Rentalload()
        {
            sql = "select * from Rental_Detail";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {


                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);


            }
            con.Close();
        }
        private void txtcustid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//enter key
            {
                cmd = new SqlCommand("Select * from Customer where CustomerId = '" + txtcustid.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();



                if (dr.Read())
                {


                    txtcustname.Text = dr["CustomerName"].ToString();

                }
                else
                {
                    MessageBox.Show("customer id not found");
                }
                con.Close();
            }
        }

        private void txtcustid_TextChanged(object sender, EventArgs e)
        {

        }
        public void grid(string id)
        {
            sql = "select * from Rental_Detail where RentalId='" + id + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {





                txtcarsid.Text = dr[0].ToString();
                txtcustid.Text = dr[1].ToString();
                txtcustname.Text = dr[2].ToString();
                if (DateTime.TryParse(dr[3].ToString(), out DateTime rentalDate))
                {
                    txtdate.Value = rentalDate;
                }
                else
                {
                    // Handle the case where the date cannot be parsed
                    txtdate.Value = DateTime.Now;
                }

                if (DateTime.TryParse(dr[4].ToString(), out DateTime dueDate))
                {
                    txtdue.Value = dueDate;
                }
                else
                {

                    txtdue.Value = DateTime.Now; // Set a default value or handle accordingly
                }
                //txtdate.Text = dr[3].ToString();
                txtdue.Text = dr[5].ToString();
                txtfee.Text = dr[6].ToString();


            }
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                txtcarsid.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                grid(id);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)

            {
                Mode = false;

                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from Rental_Detail where Rentalid=@Rentalid";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Rentalid", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");

                con.Close();
                Rentalload();
                Mode = true;
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //Main m = new Main();
            // Main.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                Mode = false;
                txtcarsid.Enabled = false;

                // Get the ID from the clicked row
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                grid(id);
            }
        }
    }
}
