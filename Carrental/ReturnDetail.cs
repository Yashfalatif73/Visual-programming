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
namespace Carrental
{
    public partial class ReturnDetail : Form
    {
        public ReturnDetail()
        {
            InitializeComponent();
            Returnload();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarRentalDB;Integrated Security=True");


        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql1;




        //public void returnload()
        //{
        //    cmd = new SqlCommand("Select * from Car", con);
        //    con.Open();
        //    dr = cmd.ExecuteReader();



        //    while (dr.Read())
        //    {
        //        textBoxcarid.Items.Add(dr["CarId"].ToString());

        //    }
        //    con.Close();
        //}
        public void Returnload()
        {
            sql = "select * from Return_Detail";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {


                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            

            }
            con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {


            DateTime dateTime = DateTime.Parse(textBoxdate.Text);
          
            string elp = textBoxelapsed.Text;
            string fine = textBoxfine.Text;




            sql = "INSERT into Return_Detail(CarId,CustomerId,Date,DaysElapsed,Fine) Values(@CarId,@CustomerId,@Date,@DaysElapsed,@Fine )";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@CarId", textBoxcarid.SelectedValue);
            cmd.Parameters.AddWithValue("@CustomerId", textboxcustomername.SelectedValue);
            cmd.Parameters.AddWithValue("@Date", dateTime);
            cmd.Parameters.AddWithValue("@DaysElapsed", elp     );
            cmd.Parameters.AddWithValue("@Fine", fine);



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added");
            con.Close();
            //textBoxcarid.SelectedItem = null;
            //textboxcustomername.SelectedItem= null;
            textBoxdate.Clear();
            textBoxelapsed.Clear();
            textBoxfine.Clear();

            textBoxcarid.Focus();
            Returnload();
            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {



           
            
              
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carRentalDBDataSet4.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter1.Fill(this.carRentalDBDataSet4.Car);
            // TODO: This line of code loads data into the 'carRentalDBDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.carRentalDBDataSet3.Customer);
            //// TODO: This line of code loads data into the 'carRentalDBDataSet2.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.carRentalDBDataSet2.Car);
            //// TODO: This line of code loads data into the 'carRentalDBDataSet1.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.carRentalDBDataSet1.Customer);
            //// TODO: This line of code loads data into the 'carRentalDBDataSet.Return_Detail' table. You can move, or remove it, as needed.
            //this.return_DetailTableAdapter.Fill(this.carRentalDBDataSet.Return_Detail);

        }

        private void textBoxdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy(this.carRentalDBDataSet1.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.carTableAdapter.FillBy(this.carRentalDBDataSet2.Car);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textboxcustomername_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Selected Customer: {textboxcustomername.SelectedValue}", "Selecte
                con.Open();

                using (SqlCommand cmd = new SqlCommand("Select * from Rental_Detail where CustomerId = '" + textBoxcarid.SelectedValue + "'", con))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", textBoxcarid.SelectedValue);


                

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBoxdate.Text = dr["ReturnDate"].ToString();





                        //    textboxcustomername.Text = dr["CustomerId"].ToString();
                        //else
                        //    textboxcustomername.Text = string.Empty;

                        //if (dr["ReturnDate"] != DBNull.Value)
                        //    textBoxdate.Text = dr["ReturnDate"].ToString();
                        //else
                        //    textBoxdate.Text = string.Empty;
                        int elapped = (int)(DateTime.Now - dr.GetDateTime(dr.GetOrdinal("ReturnDate"))).TotalDays;

                    

                            textBoxelapsed.Text = elapped.ToString();

                            if (elapped > 0)
                            {
                                int fine = elapped * 200;
                                textBoxfine.Text = fine.ToString();
                            }
                            else
                            {
                                textBoxfine.Text = "0";
                                textBoxfine.Text = "0";
                            }
                        }
                        con.Close();
                    }
                
            }


            //if (e.KeyChar == 13)

            //    cmd = new SqlCommand("Select * from CarId,CustomerId,RentalDate,ReturnDate,DATTEDIFF(dd,RentalDate,GETDATE()) as elap from Rental_Detail  where CarId = '" + textBoxcarid.Text + "'",con);
            //    con.Open();
            //    dr = cmd.ExecuteReader();




            //    // Handle the exception as needed
            //}
            //if(dr.Read())
            //{
            //    textBoxcustomerid.Text = dr["CustomerId"].ToString();
            //    textBoxdate.Text = dr["ReturnDate"].ToString();

            //}






        }

        private void textBoxcarid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter1.FillBy(this.carRentalDBDataSet3.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter1.FillBy1(this.carRentalDBDataSet3.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.carTableAdapter1.FillBy(this.carRentalDBDataSet4.Car);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
    }

