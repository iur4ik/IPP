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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double totalPrice = 0; 
        //adds ingredients to the listBox1 and displays the total price in textBox1
        private void Form2_Load(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            addElementsToListBox(Order.Cheeses);
            addElementsToListBox(Order.Meat);
            addElementsToListBox(Order.Vegetables);
            Order.intDictionaryValues();
            totalPrice = Order.totalPrice();
            textBox1.Text = totalPrice.ToString();
        }

        //stores the checked items in lsitBox
        private void addElementsToListBox(List<string> list)
        {
            foreach (string element in list)
            {
                listBox1.Items.Add(element);
            }
        }
        //button to close Form2 window
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //creates a instance of Form3 and displays the window
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // Instantiate a Form3 object.
            f3.ShowDialog();
            this.Close();
        }
    }
}
