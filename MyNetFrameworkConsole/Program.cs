using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNetStandard;
using MyNetEF;
namespace MyNetFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".NET Framework 4.8 Console");
            var service = new CarService(new MigrationPOCContext());
            var cars = service.List();
            foreach (var c in cars)
            {
                Console.WriteLine(c.Model);
            }
        }
    }
}
