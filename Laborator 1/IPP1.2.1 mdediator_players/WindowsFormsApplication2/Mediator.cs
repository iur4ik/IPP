using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    abstract class Mediator
    {
        public abstract void Send(Player player);
        //public abstract int Update(Player player);
    }
}
