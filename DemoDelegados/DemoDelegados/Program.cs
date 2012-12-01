using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoDelegados
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, string> cmdPrint = null;

            cmdPrint += Print;

            var result = cmdPrint.BeginInvoke("Juan", null, null);

            Otra();

            while (!result.IsCompleted)
            {
                Console.WriteLine("esperando");
                Thread.Sleep(1000);
            }

            var men = cmdPrint.EndInvoke(result);

            Console.WriteLine(men);

            Console.ReadLine();

        }
        public static string Print(string mensaje)
        {
            Thread.Sleep(10000);
            return "Hola " + mensaje;
        }
        public static void Otra()
        {
            Console.WriteLine("Hacinedo otra tarea");
        }
       
    }
}
