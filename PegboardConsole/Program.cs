using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PegboardConsole.Services;

namespace PegboardConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var initialStartingPosition = int.Parse()
            if (args.Length == 0)
            {
                Console.Out.WriteLine(
                    "Arguments Not Supplied: 0-14 for starting position, Optional: number of Winning Results to display");
            }
            else
            {
                int initial = 0;
                if (!int.TryParse(args[0], out initial))
                    Console.Out.WriteLine("First argument must be an integer between 0 and 14");
                else
                {
                    var displayResults = int.MaxValue;
                    if (args.Length == 2)
                    {
                        int.TryParse(args[1], out displayResults);
                    }
                    var svc = new PegboardGameService();
                    Console.Out.WriteLine("Starting Simulation with Initial Empty Peg at Position {0}", initial);
                    var results = svc.StartSimulation(initial);
                    foreach (var r in results.Skip(0).Take(displayResults))
                    {
                        Console.Out.WriteLine(r);
                        Console.Out.WriteLine();
                    }

                    Console.Out.WriteLine("{0} Total Winning Combinations Found", results.Count);
                }
            }

            Console.Out.WriteLine("Press Any Key to Exit");
            Console.In.ReadLine();
        }
    }
}
