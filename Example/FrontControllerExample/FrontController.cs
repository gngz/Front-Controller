using FrontControllerExample.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrontControllerExample
{
    sealed class FrontController
    {
        private static FrontController instance;
        private Dispatcher dispatcher;

        private FrontController()
        {
            dispatcher = Dispatcher.GetInstance();
        }

        public static FrontController GetInstance()
        {
            if (instance == null)
                instance = new FrontController();
            return instance;
        }

        public void AddRoute(string aAddress, IView aView)
        {
            dispatcher.AddRoute(aAddress, aView);
        }

        private void LogRoute(string aAddress)
        {
            Console.WriteLine($"[LOG] The route {aAddress} was requested!");
        }

        public void DispatchRoute(string aAddress)
        {
            this.LogRoute(aAddress);
            Console.Write("Response: ");
            dispatcher.Dispatch(aAddress);
        }

    }
}
