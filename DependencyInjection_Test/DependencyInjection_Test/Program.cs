using Autofac;
using System;
//https://www.youtube.com/watch?v=EFASI_pHFrg
namespace DependencyInjection_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ConsoleNotiflication>().As<INotiflicationService>();
            var container = containerBuilder.Build();

            var notiflicationService = container.Resolve<INotiflicationService>();


            var user = new User("Tim", notiflicationService);
            user.ChangeUsername("Robert");
        }

    }
}
