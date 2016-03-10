using System;
using System.Collections.Generic;
using System.Timers;
using IvyControllers;

namespace SimulatorEngine
{
    public class SimulatorEngineModel
    {
        public const int SAMPLE_PER_SECOND = 10;
        private const String VI_PATTERN = "";
        private List<RobotModel> _robots;
        private SurfaceModel _surface; // not implemented yet
        private Timer _simulationTime;
        private IvyController _controller;

        #region GET/SET
        public IvyController Controller
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
        #endregion

       /// <summary>
        /// Constructor by default
        /// </summary>
        /// <param name="ctrlr"></param>
        public SimulatorEngineModel()
        {
            this.Controller = new IvyController("simulator_engine");
            SimulationTime = new Timer();
            SimulationTime.Interval = 100;
            SimulationTime.Elapsed += Update;
            Robots = new List<RobotModel>();
            Robots.Add(new RobotModel(this, "RB1", 0, 0, 0, "parcours/20160121_parcours_carre.txt"));
        }


        /// <summary>
        /// Tick of the timer (1 tick simulate 100 ms). Apply 1 instructions to each robots
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
        /// This start the timer
        /// </summary>
        public void StartSimulation()
        {
            SimulationTime.Start();
        }

        
    }
}
