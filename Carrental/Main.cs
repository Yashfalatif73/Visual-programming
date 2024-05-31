using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrental
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
           // this.Main = Main;
            //this.Form1 = Form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentalDetail r = new RentalDetail();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnDetail r = new ReturnDetail();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           this.Close();
            Form1 form1 = new Form1();
            form1.Show();


            //if (Form1 != null)
            //{
            //    Form1.Show();
            //}
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
