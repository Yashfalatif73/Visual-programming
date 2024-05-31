using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carrental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = txtuname.Text;
            string pass = txtpass.Text;

            if(uname.Equals("Admin") && pass.Equals("123"))
            {

                Main m = new Main();
                this.Hide();
                m.Show();

            }
            else
            {
                MessageBox.Show("Username or Password do not match");
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
            }
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
          
            
                if (txtuname.Text == "Admin")
                {
                    txtpass.Focus();
                }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
