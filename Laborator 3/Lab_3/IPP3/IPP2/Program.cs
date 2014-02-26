﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IPP2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // Create the View, Model and Controller object yourself. 
            // Create a controller object with the concreate implementation IncController 
            // and pass the view and model.
            // Controller will store its associated model and view inside the constructor
            // View which is inside the form will tie the controller automatically
            // Run the view object created by you which is infact the form
            Form1 view = new Form1();
            IModel mdl = new IncModel();
            IController cnt = new IncController(view, mdl);
            Application.Run(view);
        }
    }
}
