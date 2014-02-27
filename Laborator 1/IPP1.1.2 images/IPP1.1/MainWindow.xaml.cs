using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
//using System.Windows.Forms;

namespace IPP1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //each of 10 buttons will download an image from the given url
        //before downloading first 5 links are stored in pro.urls List
        private Proxy pro = new Proxy();

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/warm_water_current-t2.jpg");
            display("1");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/louisiade_archipelago-t2.jpg");
            display("2");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/circle_of_clouds-t2.jpg");
            display("3");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/river_gorge_satelite_view-t2.jpg");
            display("4");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/galaxy_4-t2.jpg");
            display("5");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/earth_8-t2.jpg");
            display("6");
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/star_dust_2-t2.jpg");
            display("7");
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/blue_hole_nebula-t2.jpg");
            display("8");
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/apple_10-t2.jpg");
            display("9");
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            pro.urls.Add("http://hd.wallpaperswide.com/thumbs/crab_nebula-t2.jpg");
            display("10");
        }

        //notifies teh user of an image to be downloaded, or when is already downloaded 
        //counts the number of links in pro.urls, is number is 5 they are downloaded
        //disables buttons when Proxy dowloads the images
        public void display(string imageNum) 
        {
            textBox1.AppendLine("image" + imageNum + " to be downloaded");
            pro.i++;
            pro.imageName.Add("image" + imageNum);
            if (pro.i == 5)
            {
                disableButtons();
                
                textBox1.AppendLine("\n");
                for (int i = 0; i < 5; i++)
                {
                    pro.CountImages(i);
                    textBox1.AppendLine("image downloaded");
                }
                disableButtons();
            }
        }

        //disables all the buttons
        private void disableButtons()
        {
            Button btn = button1;
            foreach (FrameworkElement item in ((Panel)btn.Parent).Children)
            {
                if (item is Button)
                {
                    if (btn.Name != item.Name)
                        item.IsEnabled = !item.IsEnabled;
                }
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //
        //private void AddTextChangedHandler(System.Windows.Forms.Control parent, bool enable)
        //{
        //    foreach (System.Windows.Forms.Control c in parent.Controls)
        //    {
        //        System.Windows.Forms.Button b = c as System.Windows.Forms.Button;
        //        if (b != null)
        //        {
        //            b.Enabled = enable;
        //        }
        //    }
        //}
    }
}
