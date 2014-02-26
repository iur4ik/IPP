using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPP2
{
    public class IncModel : IModel
    {
        public event ModelHandler<IncModel> changed;
        int value;
        // implementation of IModel interface set the initial value to 0
        public IncModel()
        {
            value = 0;
        }
        // Set value function to set the value in case if the user directly changes the value
        // in the textbox and the view change event fires in the controller
        public void setvalue(int v)
        {
            value = v;
        }
        // Change the value and fire the event with the new value inside ModelEventArgs
        // This will invoke the function valueIncremented in the model and will be displayed
        // in the textbox subsequently
        public void increment()
        {
            value++;
            changed.Invoke(this, new ModelEventArgs(value));
        }
        // Attach the function which is implementing the IModelObserver so that it can be
        // notified when a value is changed
        public void attach(IModelObserver imo)
        {
            changed += new ModelHandler<IncModel>(imo.valueIncremented);
        }
    }
}
