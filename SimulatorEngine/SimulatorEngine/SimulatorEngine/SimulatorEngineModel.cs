using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Resources;

namespace SimulatorEngine
{
    public class SimulatorEngineModel
    {
        public const int SAMPLE_PER_SECOND = 10;

    
        private const String VI_PATTERN = "";
        private List<RobotModel> _robots;

     
        private SurfaceModel _surface;
        private Timer _simulationTime;
        private Controller _controller;
 

        private Controller Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }

       public Timer SimulationTime
       {
           get { return _simulationTime; }
           set { _simulationTime = value; }
       }

       public List<RobotModel> Robots
       {
           get { return _robots; }
           set { _robots = value; }
       }
        /// <summary>
        /// Constructor by default
        /// </summary>
        /// <param name="ctrlr"></param>
        public SimulatorEngineModel(Controller ctrlr)
        {
            this.Controller = ctrlr;
            SimulationTime = new Timer();
            SimulationTime.Interval = 100;
            SimulationTime.Elapsed += Update;
            Robots = new List<RobotModel>();
            Robots.Add(new RobotModel(this, "RB1", 0, 0, 0));
            CreateRobots();



        }


        /// <summary>
        /// Tick of the timer (1 tick simulate 100 ms)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Update(object sender, ElapsedEventArgs e)
        {
           foreach(RobotModel robot in Robots)
           {
               robot.ApplyInstruction();
           }
            
        }



        
        /// <summary>
        /// 
        /// </summary>
        public void StartSimulation()
        {
            SimulationTime.Start();
        }


        public void CreateRobots()
        {
            string line = "";
            StreamReader file = new StreamReader("parcours/20160121_parcours_carre.txt");

           foreach(RobotModel robot in Robots)
            while((line = file.ReadLine()) != null)
            {
                robot.Instructions.Add(line);
            }

           
        }
    }
}
