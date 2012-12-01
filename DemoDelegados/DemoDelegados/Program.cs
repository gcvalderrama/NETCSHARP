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

            cmdPrint = new Func<string, string>(
                    delegate(string mensaje) {
                        Thread.Sleep(10000);
                        return "Hola " + mensaje;
                    }
                );
            var cb = new AsyncCallback(delegate(IAsyncResult result) {
                var del = result.AsyncState as Func<string, string>;
                var men = del.EndInvoke(result);
                Console.WriteLine(men);
            });
            cmdPrint.BeginInvoke("Juan", cb, cmdPrint);
            Otra();            
            Console.ReadLine();
        }          
        public static void Otra()
        {
            Console.WriteLine("Hacinedo otra tarea");
        }
       
    }
}
