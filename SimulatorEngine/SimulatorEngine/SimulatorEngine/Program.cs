using System;

namespace SimulatorEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Begin Simulation ==============");
            Controller c = new Controller();
            SimulatorEngineModel SimulatorEngine = new SimulatorEngineModel();
            SimulatorEngine.StartSimulation();
            while (Console.Read() != 'q') ;

        }
    }
}
