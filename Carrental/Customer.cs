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
using System.Security.Cryptography;
using System.IO;

namespace Carrental
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            Autono();
            Customerload();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarRentalDB;Integrated Security=True");


        SqlCommand cmd;
        SqlDataReader dr;
        string proid;
        string sql;
        bool Mode = true;
        string id;
        public void Autono()
        {



            sql = "select CustomerId from Customer order by CustomerId desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00001");
            }
            else
            {
                proid = ("00001");
            }


            txtid.Text = proid.ToString();
            con.Close();

        }
        public void grid(string id)
        {
           sql = "select * from Customer where customerid='" + id + "'";
           cmd = new SqlCommand(sql, con);
           con.Open();
          dr = cmd.ExecuteReader();

          while (dr.Read())
           {


                byte[] imageData;

                if (!dr.IsDBNull(dr.GetOrdinal("Picture")))
                {
                    long bufLength = dr.GetBytes(dr.GetOrdinal("Picture"), 0, null, 0, 0);

                    if (bufLength > 0)
                    {
                        imageData = new byte[bufLength];

                        dr.GetBytes(dr.GetOrdinal("Picture"), 0, imageData, 0, (int)bufLength);

                        MemoryStream ms = new MemoryStream(imageData);
                        Image image = Image.FromStream(ms);

                        pictureBox1.Image = image;
                    }
                    else
                    {

                        pictureBox1.Image = null;
                    }
                }
                else
                {

                    pictureBox1.Image = null;
                }

                txtid.Text = dr[0].ToString();
                txtname.Text = dr[1].ToString();
                txtaddress.Text = dr[2].ToString();
                txtmobile.Text = dr[3].ToString();
                txtcnic.Text = dr[4].ToString();
           

                txtguarantorcnic.Text = dr[6].ToString();
                txtguarantorname.Text = dr[7].ToString();
                txtguarantorcontact.Text = dr[8].ToString();

            }
            con.Close();
        }


        
        public void Customerload()
        {
            sql = "select * from Customer";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                long bufLength;
                if (!dr.IsDBNull(dr.GetOrdinal("Picture")))
                {
                    bufLength = dr.GetBytes(dr.GetOrdinal("Picture"), 0, null, 0, 0);
                }
                else
                {
                    bufLength = 0;
                }
                dataGridView1.Rows.Add(dr.GetInt32(dr.GetOrdinal("CustomerId")),dr.GetString(dr.GetOrdinal("CustomerName")),dr.GetString(dr.GetOrdinal("Address")), dr.GetString(dr.GetOrdinal("Mobile")), dr.GetString(dr.GetOrdinal("CNIC")), bufLength.ToString(), dr.GetString(dr.GetOrdinal("GuarantorName")),dr.GetString(dr.GetOrdinal("GuarantorName")), dr.GetString(dr.GetOrdinal("GuarantorContact")));
                // dataGridView1.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6),dr.GetString(7)); dr.GetString(dr.GetOrdinal("GuarantorCNIC")),


            }
            con.Close();
            /// han
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string CustomerId = txtid.Text;
            string CustomerName = txtname.Text;
            string Address = txtaddress.Text;
            string Mobile = txtmobile.Text;
            string CNIC = txtcnic.Text;
            string guarantorcnic = txtguarantorcnic.Text;
            string guarantorname = txtguarantorname.Text;
            string guarantorcontact = txtguarantorcontact.Text;



            //Image picturebox1 = pictureBox1.Image;

            if (pictureBox1.Image != null)
            {

                // Convert image to byte array
                Image image = pictureBox1.Image;
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] imageData = ms.ToArray();
                Autono();




                if (Mode == true)
                {



                    sql = "INSERT into Customer(CustomerId,CustomerName,Address,Mobile,CNIC,GuarantorCNIC,GuarantorName,GuarantorContact) Values(@CustomerId,@CustomerName,@Address,@Mobile,@CNIC,@GuarantorCNIC,@GuarantorName,@GuarantorContact )";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Mobile", Mobile);
                    cmd.Parameters.AddWithValue("@CNIC", CNIC);
                    cmd.Parameters.AddWithValue("@Picture1", imageData);
                    cmd.Parameters.AddWithValue("@GuarantorCNIC", guarantorcnic);
                    cmd.Parameters.AddWithValue("@guarantorName", guarantorname);
                    cmd.Parameters.AddWithValue("@guarantorContact", guarantorcontact);



                    //cmd.Parameters.AddWithValue("Picture1", picturebox1);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted");

                    txtname.Clear();
                    txtaddress.Clear();
                    txtmobile.Clear();
                    txtcnic.Clear();
                    txtguarantorcnic.Clear();
                    txtguarantorname.Clear();
                    txtguarantorcontact.Clear();

                    pictureBox1.Image = null;
                    txtname.Focus();

                    Customerload();


                }
                else
                {


                    sql = "update Customer set CustomerName=@CustomerName, Address=@Address, Mobile=@Mobile, CNIC=@CNIC,Picture=@Picture ,GuarantorCNIC=@GuarantorCNIC, GuarantorName=@GuarantorName, GuarantorContact=@GuarantorContact WHERE CustomerId=@CustomerId";
                    con.Open();
                    cmd = new SqlCommand(sql, con);


                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Mobile", Mobile);
                    cmd.Parameters.AddWithValue("@CNIC", CNIC);
                    cmd.Parameters.AddWithValue("@Picture", imageData);
                    cmd.Parameters.AddWithValue("@GuarantorCNIC", guarantorcnic);
                    cmd.Parameters.AddWithValue("@GuarantorName", guarantorname);
                    cmd.Parameters.AddWithValue("@GuarantorContact", guarantorcontact);




                    txtid.Enabled = true;
                    Mode = true;
                    txtname.Clear();
                    txtaddress.Clear();
                    txtmobile.Clear();
                    txtguarantorcnic.Clear();
                    txtguarantorname.Clear();
                    txtguarantorcontact.Clear();
                    pictureBox1.Image = null;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record edited");

                    txtname.Focus();
                    con.Close();
                    Customerload();
                }
            }

            else
            {
                MessageBox.Show("Please select an image to save.");
            }
            
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                txtid.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                grid(id);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;

                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from Customer where Customerid=@customerid";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@customerid", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");

                con.Close();
                Customerload();
                Mode = true;
            }


        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Customerload();

            Autono();
            txtname.Clear();
            txtaddress.Clear();
            txtmobile.Clear();
            txtcnic.Clear();
            txtguarantorcnic.Clear();
            txtguarantorname.Clear();
            txtguarantorcontact.Clear();
           // txtpicture.Clear();
            txtname.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                Mode = false;
                txtid.Enabled = false;

                // Get the ID from the clicked row
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                grid(id);
            }
        }

        private void txtguarantorcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select Image(*.png, *.jpg)|*.png;*.jpg";



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

