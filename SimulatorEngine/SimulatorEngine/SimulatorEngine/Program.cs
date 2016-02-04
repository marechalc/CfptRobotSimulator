using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("test");
            Controller c = new Controller();
            SimulatorEngineModel SimulatorEngine = new SimulatorEngineModel(c);
            SimulatorEngine.StartSimulation();
        }
    }
}
