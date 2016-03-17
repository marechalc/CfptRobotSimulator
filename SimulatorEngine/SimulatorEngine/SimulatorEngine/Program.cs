using System;

namespace SimulatorEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Begin Simulation ==============");
            SimulatorEngineModel SimulatorEngine = new SimulatorEngineModel();
            SimulatorEngine.StartSimulation();
            

        }
    }
}
