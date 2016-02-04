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
        private const int _SAMPLE_PER_SECOND = 10;

        public int SAMPLE_PER_SECOND
        {
            get { return _SAMPLE_PER_SECOND; }
        } 


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
        }

        /// <summary>
        /// Tick of the timer (1 tick = 100 ms)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Update(object sender, ElapsedEventArgs e)
        {
           
            
        }



        
        /// <summary>
        /// 
        /// </summary>
        public void StartSimulation()
        {
            SimulationTime.Start();
        }

        public void StrategyParser()
        {
            string line = "";
            StreamReader file = new StreamReader(Properties.Resources.test_parcours_carre);
            RobotModel robot = new RobotModel(this, "RB1", 0, 0, 0, "");

            while((line = file.ReadLine()) != null)
            {
                robot.Instruction = line;
            }
        }
    }
}
