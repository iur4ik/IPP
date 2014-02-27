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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //verifies what data is introduced, number of ingredients
        //if the numebr of ingredients is hihger, a notification in form of message box is shown
        //stores all names of checked checkBoxes in Lists
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 3 || checkedListBox2.CheckedItems.Count > 2 ||
                checkedListBox3.CheckedItems.Count > 5)
            {
                if (checkedListBox1.CheckedItems.Count > 3)
                {
                    // If so, loop through all checked items and print results.
                    string s = "";
                    for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                    {
                        s = s + "Max 3 types of chesses are allowed \n";
                    }
                    MessageBox.Show(s);
                }
                if (checkedListBox2.CheckedItems.Count > 2)
                {
                    string s = "";
                    for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                    {
                        s = s + "Max 2 types of meat are allowed \n";
                    }
                    MessageBox.Show(s);
                }
                if (checkedListBox3.CheckedItems.Count > 5)
                {
                    string s = "";
                    for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                    {
                        s = s + "Max 5 types of chesses are allowed \n";
                    }
                    MessageBox.Show(s);
                }
            }
            else 
            {
                if (Order.Cheeses.Count != 0)
                    Order.Cheeses.Clear();
                if (Order.Meat.Count != 0)
                    Order.Meat.Clear();
                if (Order.Vegetables.Count != 0)
                    Order.Vegetables.Clear();
                //code for going to second form
                foreach (object itemChecked in checkedListBox1.CheckedItems) 
                {
                    Order.Cheeses.Add(itemChecked.ToString());
                }
                foreach (object itemChecked in checkedListBox2.CheckedItems)
                {      
                    Order.Meat.Add(itemChecked.ToString());
                }
                foreach (object itemChecked in checkedListBox3.CheckedItems)
                {   
                    Order.Vegetables.Add(itemChecked.ToString());
                }
                //declaring a ninstance of Form2, and showing the form
                Order.customer = textBox1.Text;
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
