using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DIMappings;
using DotNetPro.KontaktManager.CrossCutting.Logging;
using DotNetPro.KontaktManager.CrossCutting.Logging.Contracts;
using DotNetPro.KontaktManager.Data.Repositories;
using DotNetPro.KontaktManager.Data.Repositories.Contracts;
using DotNetPro.KontaktManager.Logic.PersonManagement;
using DotNetPro.KontaktManager.Logik.PersonManagement.Contracts;
using Ninject;

namespace DotNetPro.KontaktManager.UI.ConsoleClient
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(Aggregator.Mappings);

            var manager = kernel.Get<IPersonManager>();


            Console.WriteLine("Alle");
            manager.GetAll().ToList().ForEach(p => Console.WriteLine(p.Firstname)); 
            
            Console.WriteLine("\nErwachsen");
            manager.GetAdults().ToList().ForEach(p => Console.WriteLine(p.Firstname)); 
            
            Console.WriteLine("\nKinder");
            manager.GetChildren().ToList().ForEach(p => Console.WriteLine(p.Firstname));


            Console.ReadKey();
        }
    }
}
