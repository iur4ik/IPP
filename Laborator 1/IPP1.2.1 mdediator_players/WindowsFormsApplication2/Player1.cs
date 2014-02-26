using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Player1 : Player
    {
        public Player1(Mediator mediator, int id) : base(mediator, id) { }

        //it calls function Send from Mediator object called mediator
        public void Send()
        {
            mediator.Send(this);
        }
    }
}
