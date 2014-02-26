using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP2
{
    public interface IModel
    {
        void attach(IModelObserver imo);
        void increment();
        void setvalue(int v);
    }
}
