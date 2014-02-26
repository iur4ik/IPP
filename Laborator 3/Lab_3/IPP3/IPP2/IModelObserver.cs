using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP2
{
    public interface IModelObserver
    {
        void valueIncremented(IModel model, ModelEventArgs e);
    }
}
