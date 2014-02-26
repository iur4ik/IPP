using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP2
{
    public delegate void ViewHandler<IView>(IView sender, ViewEventArgs e);

    public class ViewEventArgs : EventArgs 
    {
        public int value;
        public ViewEventArgs(int v)
        {
            value = v;
        }
    }
}
