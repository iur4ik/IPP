using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    static class Scorebord
    {
        //RealMediator m = new RealMediator();
        
        //variables, that are incremented by RealMediator
        //function Update returns the current score for the player (given as aprameter)
        static public int totalScorePlayer1;
        static public int totalScorePlayer2;
        
        static public int Update(Player player)
        {
            if (player.id == 1)
            {
                return totalScorePlayer1;
            }
            else
            {
                return totalScorePlayer2;
            } 
        }
    }
}
