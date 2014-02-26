using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPP2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //shows the  formed ID, user's by changing text of a label
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Your order has been sent. \n Id number is " + Order.setID() + " Name: " + Order.customer;
        }
        //closes the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
