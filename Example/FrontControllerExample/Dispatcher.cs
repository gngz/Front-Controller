using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using FrontControllerExample.Views;

namespace FrontControllerExample
{

    sealed class Dispatcher
    {
        private static Dispatcher instance;
        private Dictionary<string, IView> routes;

        // Singleton
        private Dispatcher()
        {
            routes = new Dictionary<string, IView>();
        }

        public static Dispatcher GetInstance()
        {
            if(instance == null)
                instance = new Dispatcher();
            return instance;
        }



        public void AddRoute(string aAddress, IView aView)
        {
            if(routes.ContainsKey(aAddress))
            {
                routes[aAddress] = aView;
            } 
            else
            {
                routes.Add(aAddress, aView);
            }
            
        }

        public void Dispatch(string aAddress)
        {
            if(routes.ContainsKey(aAddress))
            {
                routes[aAddress].Display();
            }
            else
            {
                Console.WriteLine($"The route {aAddress} is not found!");
            }
        }
    }
}
