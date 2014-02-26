using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Player2 : Player
    {
        public Player2(Mediator mediator, int id) : base(mediator, id) { }

        //it is intantiated to create the second player
        public void Send()
        {
            mediator.Send(this);
        }
    }
}
