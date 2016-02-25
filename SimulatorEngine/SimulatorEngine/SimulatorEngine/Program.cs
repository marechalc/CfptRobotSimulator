using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimulatorEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Match instructionName = Regex.Match("GC90    // Go Cap (en degré, sens trigo)", @"[a-zA-Z]+");
            Console.WriteLine("test");
            Controller c = new Controller();
            SimulatorEngineModel SimulatorEngine = new SimulatorEngineModel(c);
            SimulatorEngine.StartSimulation();
            while (Console.Read() != 'q') ;

        }
    }
}
