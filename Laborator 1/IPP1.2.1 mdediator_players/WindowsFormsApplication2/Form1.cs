using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(myKey);
        }

        static RealMediator mediator = new RealMediator();
        //static Scorebord score = new Scorebord();
        
        //instantiates two players
        static Player1 thePlayer1 = new Player1(mediator,1);
        static Player2 thePlayer2 = new Player2(mediator,2);

        //thePlayer1.Send();
        //thePlayer2.Send();

        //determines which key (0(NumPad0) or 1(NumPad1)) is pressed and updates the score
        private void myKey(Object o, KeyPressEventArgs e)
        {
            if((e.KeyChar == (char)Keys.D0) || (e.KeyChar == (char)Keys.NumPad0))
            {
                thePlayer1.Send();//increments the value by 1
                int scored = Scorebord.Update(thePlayer1);//updates the value of scoreboard for player 1
                textBox1.Text = scored.ToString();//displays the current score of player 1 in the textBox1
            }
            else if ((e.KeyChar == (char)Keys.D1) || (e.KeyChar == (char)Keys.NumPad1))
            {
                thePlayer2.Send();//increments the value by 1
                int scored_1 = Scorebord.Update(thePlayer2);//updates the value of scoreboard for player 2
                textBox2.Text = scored_1.ToString();//displays the current score of player 2 in teh textBox2
            }
        }

        //after 30-second time elapses, textboxes and button1 are disabled 
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //textBox1.Enabled = false;
            //textBox2.Enabled = false;
            //button1.Enabled = true;
        }

        //triggers an event at 30 seconds
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            System.Timers.Timer theTimer = new System.Timers.Timer();
            theTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            theTimer.Interval = 30000;
            theTimer.Enabled = true;
        }
        /////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
