using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    abstract class Player
    {
        protected Mediator mediator;
        public int id;

        //parent class for Player1 and Player2
        public Player(Mediator mediator,int id)
        {
            this.mediator = mediator;
            this.id = id;
        }
    }
}
