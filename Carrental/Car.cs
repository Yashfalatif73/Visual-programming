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
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Carrental
{
    public partial class Car : Form
    {
        public Car()
        {



            InitializeComponent();
            Autono();
            load();
            dataGridView1.CellClick += dataGridView1_CellClick;
            
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



            sql = "select carid from car order by carid desc";
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
                proid = ("00000");
            }
            else
            {
                proid = ("00000");
            }


            txtcarid.Text = proid.ToString();
            con.Close();

        }


        public void load()
        {

            cmbavl.Items.Clear();
            cmbavl.Items.Add("Yes");
            cmbavl.Items.Add("No");
            sql = "select * from car";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                long bufLength;
                if (!dr.IsDBNull(dr.GetOrdinal("Picture1")))
                {
                  bufLength  = dr.GetBytes(dr.GetOrdinal("Picture1"), 0, null, 0, 0);
                }
                else
                {
                    bufLength = 0;
                }
                    dataGridView1.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),bufLength.ToString() );
                
                //dr[6], dr[7]) 

            }
            con.Close();
        }
        public void grid(string id)
        {
            sql = "select * from car where carid='" + id + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {




                byte[] imageData;

                if (!dr.IsDBNull(dr.GetOrdinal("Picture1")))
                {
                    long bufLength = dr.GetBytes(dr.GetOrdinal("Picture1"), 0, null, 0, 0);

                    if (bufLength > 0)
                    {
                        imageData = new byte[bufLength];

                        dr.GetBytes(dr.GetOrdinal("Picture1"), 0, imageData, 0, (int)bufLength);

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

                txtcarid.Text = dr[0].ToString();
                txtmake.Text = dr[1].ToString();
                txtmodel.Text = dr[2].ToString();
                cmbavl.SelectedItem = dr.GetString(3);
                Image imagedata = pictureBox1.Image;


            }
            con.Close();
        }
        private void RentalDetail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carid = txtcarid.Text;
            string make = txtmake.Text;
            string model = txtmodel.Text;




            



            if (Mode == false && dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells.Count > 0 && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                // In 'Add' mode, Autono() will generate a new carid
                Autono();
                id = txtcarid.Text;
            }


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





                    sql = "INSERT into Car(CarId,Model,Make,Available,Picture1) Values(@CarId,@Model,@Make, @available,@Picture1)";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@CarId", carid);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Make", make);
                    cmd.Parameters.AddWithValue("@available", cmbavl.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Picture1", imageData);



                    //cmd.Parameters.AddWithValue("@Picture1", pictureBox1);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted");
                    txtmake.Clear();
                    txtmodel.Clear();
                    cmbavl.Items.Clear();
                    txtmake.Focus();

                    load();
                }

               



            else
                {
                    sql = "update Car set Make=@make,model= @Model, Available=@available ,Picture1=@Picture1 WHERE carid=@carid";
                    con.Open();
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@Make", make);
                    cmd.Parameters.AddWithValue("@Model", model);

                    cmd.Parameters.AddWithValue("@available", cmbavl.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CarId", id);
                    cmd.Parameters.AddWithValue("@Picture1", imageData);
                    //cmd.Parameters.AddWithValue("@Picture2", picturebox2);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record edited");
                    txtcarid.Enabled = true;
                    Mode = true;
                    txtmake.Clear();
                    txtmodel.Clear();
                    cmbavl.Items.Clear();
                    txtmake.Focus();

                    load();
                }
            }
            else
            {
                MessageBox.Show("Please select an image to save.");
            }

        }








        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtregno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;

                txtcarid.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();









                grid(id);
            }
            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
               
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from car where carid=@id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");

                con.Close();
                load();
                Mode = true;
            }


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            load();
            
            Autono();
            txtmake.Clear();
            txtmodel.Clear();
            txtmake.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                Mode = false;
                txtcarid.Enabled = false;

                // Get the ID from the clicked row
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                grid(id);
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select Image(*.png, *.jpg)|*.png;*.jpg";



            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcarid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
