using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace AutoFacABasicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ColorPrinter>().As<IPrinter>();
            var container = builder.Build();
            var printer=  container.Resolve<IPrinter>();
            printer.Print("Color Printer Dependency is resolved");

            Console.ReadLine();

            





        }
    }
}
