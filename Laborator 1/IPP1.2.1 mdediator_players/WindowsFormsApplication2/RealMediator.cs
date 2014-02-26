using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class RealMediator : Mediator
    {
        public Player1 player_1 { get; set; }
        public Player2 player_2 { get; set; }

        //private int totalScorePlayer1;
        //private int totalScorePlayer2;

        public override void Send(Player player)
        {
            if (player.id == 1)//player == player_1
            {
                Scorebord.totalScorePlayer1++;
            }
            else 
            { 
                Scorebord.totalScorePlayer2++; 
            }
        }
    }
}
