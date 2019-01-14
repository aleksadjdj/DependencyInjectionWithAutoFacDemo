using Autofac;
using DemoLibrary;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
