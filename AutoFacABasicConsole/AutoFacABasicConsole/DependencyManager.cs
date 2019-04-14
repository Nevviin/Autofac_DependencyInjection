using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace AutoFacABasicConsole
{
    public class DependencyManager
    {

        public void RegisterDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ColorPrinter>().As<IPrinter>();
            var container = builder.Build();
            container.Resolve<IPrinter>();

        }



    }
}
