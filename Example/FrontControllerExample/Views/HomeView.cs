using System;
using System.Collections.Generic;
using System.Text;

namespace FrontControllerExample.Views
{
    class HomeView : IView
    {
        public void Display()
        {
            Console.WriteLine("This is the Home page!");
        }
    }
}
