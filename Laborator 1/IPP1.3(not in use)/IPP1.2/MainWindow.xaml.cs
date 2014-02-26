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
using System.Windows.Input;
//using System.Windows.UIElement;

namespace IPP1._2
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

        RealMediator realMediator = new RealMediator();

        Player1 thePlayer1 = new Player(realMediator);
        Player2 thePlayer2 = new Player(realMediator);

        realMediator.player_1 = thePlayer1;
        realMediator.player_2 = thePlayer2;

        thePlayer1.Send();
        thePlayer2.Send();

        private void myKey(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Key.D0) || (e.Key == Key.NumPad0))
            {
                //call Players 2's methods here
                Player2.count();
                DisplayScore("1", Player1.Counter);
            }
            else if ((e.Key == Key.D1) || (e.Key == Key.NumPad1))
            { 
                //call Player 1's methods here
                Player1.count();
                DisplayScore("1", Player1.Counter);
            }
        }

        //public void DisplayScore(string id, int score) {
        //    if (id == "1")
        //    {
        //        textBox1.Clear();
        //        textBox1.Text = score.ToString();
        //    }
        //    else {
        //        textBox2.Clear();
        //        textBox2.Text = score.ToString();
        //    }
        //}

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void button2_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
