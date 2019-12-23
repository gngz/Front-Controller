using System;
using System.Collections.Generic;
using System.Text;

namespace FrontControllerExample.Views
{
    class ContactView : IView
    {
        public void Display()
        {
            Console.WriteLine("There is our's contacts");
        }
    }
}
