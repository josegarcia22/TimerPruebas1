using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TimerPruebas.Implementations;

//1
namespace TimerPruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            IPublisher publi = new Publisher(new Implementations.Consola());
            publi.StartPublishing();
            Console.ReadLine();
            publi.StopPublishing(); 


        }
    }
}
