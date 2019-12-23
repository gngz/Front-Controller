using FrontControllerExample.Views;
using System;

namespace FrontControllerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontController controller = FrontController.GetInstance();

            // Rotas
            controller.AddRoute("", new HomeView());
            controller.AddRoute("about", new AboutView());
            controller.AddRoute("contact", new ContactView());
            
            HandleRequests();
        }

        static void HandleRequests()
        {
            FrontController controller = FrontController.GetInstance();
            
            while(true)
            {
                Console.Write("Enter desired route: ");
                var route = Console.ReadLine();
                controller.DispatchRoute(route);
                Console.WriteLine();
            }
        }
    }
}
