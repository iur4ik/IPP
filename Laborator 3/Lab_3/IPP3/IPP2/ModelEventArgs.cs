using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP2
{
    public delegate void ModelHandler<IModel>(IModel sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public int newval;
        public ModelEventArgs(int v)
        {
            newval = v;
        }
    }
}
