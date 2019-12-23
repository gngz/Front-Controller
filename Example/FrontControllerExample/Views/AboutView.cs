using System;
using System.Collections.Generic;
using System.Text;

namespace FrontControllerExample.Views
{
    class AboutView : IView
    {
        public void Display()
        {
            Console.WriteLine("This is the about page!");
        }
    }
}