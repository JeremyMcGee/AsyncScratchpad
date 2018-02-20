using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncScratchpad
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = RunIt();
            Console.WriteLine("Main, done.");
            Console.ReadLine();
        }

        static async Task<string> RunIt()
        {
            Task<string> t = new Task<string>
            (() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Method, done.");
                return "Task...";
            });

            t.Start();
            return await t;
        }
    }
}
