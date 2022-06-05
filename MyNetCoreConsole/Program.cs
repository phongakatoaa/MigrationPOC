using System;
using MyNetEF;
using MyNetStandard;

namespace MyNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Core 3.1 Console");
            var service = new CarService(new MigrationPOCContext());
            foreach (var c in service.List())
            {
                Console.WriteLine(c.Model);
            }
        }
    }
}
