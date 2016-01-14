using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SimulatorEngine
{
    class SimulatorEngineModel
    {

        private Controller _controller;

        internal Controller Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }
       private List<RobotModel> _robots;
       private SurfaceModel _surface;
       private Timer _simulationTime;

       public Timer SimulationTime
       {
           get { return _simulationTime; }
           set { _simulationTime = value; }
       }

        public SimulatorEngineModel(Controller ctrlr)
        {
            this.Controller = ctrlr;
            SimulationTime = new Timer();
            SimulationTime.Elapsed += Update;

        }

        void Update(object sender, ElapsedEventArgs e)
        {
           

        }





    }
}
