using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP2
{
    public interface IView
    {
        event ViewHandler<IView> changed;
        void setController(IController cont);
    }
}
