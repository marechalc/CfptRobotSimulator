using IvyControllers;
using SimulatorEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRSView
{
    public partial class View : Form
    {
        IvyController Controller { get; set; }
        Dictionary<string,RobotModel> robots { get; set; }

        public View()
        {
            InitializeComponent();

            //SC/ Instantiate the list of robots
            this.robots = new List<RobotModel>();
        }

        private void View_Load(object sender, EventArgs e)
        {
            //DL/ Create controller with a name corresponding to the hash code of the application
            this.Controller = new IvyController(this.GetHashCode().ToString());
            Controller.PositionChanged += Controller_PositionChanged;
            Controller.OrientationChanged += Controller_OrientationChanged;
        }

        /// <summary>
        /// //SC/ Change robot orientation with the parameters given by the Ivy Bus
        /// </summary>
        /// <param name="robotName">Name of the robot</param>
        /// <param name="angle">Angle in radian</param>
        private void Controller_OrientationChanged(string robotName, int angle)
        {
            if (this.RobotExist(robotName))
            {
                //SC/ Get our robot of our dictionnary and set is new orienation
                RobotModel robot = this.robots[robotName];
                // TO DO CHANGE ORIENTATION
            }
            else
            {
                //SC/ Robot doesn't exist create a new one
                this.CreateRobot(robotName, x, y);
            }
        }

        /// <summary>
        /// //SC/ Change robot position with the parameters given by the Ivy Bus
        /// </summary>
        /// <param name="robotName">Name of the robot</param>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        private void Controller_PositionChanged(string robotName, int x, int y)
        {
            if(this.RobotExist(robotName))
            {
                //SC/ Get our robot of our dictionnary and set is new position
                RobotModel robot = this.robots[robotName];
                robot.Position = new Point(x, y);
            }
            else
            {
                //SC/ Robot doesn't exist create a new one
                this.CreateRobot(robotName, x, y);
            }
        }

        /// <summary>
        /// //SC/ Create a new robot and add it to the dictionnary
        /// </summary>
        /// <param name="robotName">Name of the robot</param>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        private void CreateRobot(string robotName, int x, int y)
        {
            //SC/ Create a new robot
            RobotModel robot = new RobotModel(null, robotName, new Point(x, y), 0, "");

            //SC/ Add it to our list
            this.robots.Add(robot.Name,robot);
        }

        /// <summary>
        /// //SC/ Check if the robot already exist in our view
        /// </summary>
        /// <param name="robotName">Name of the robot</param>
        /// <returns></returns>
        private Boolean RobotExist(string robotName)
        {
            Boolean robotExist = false;
            robotExist = this.robots.ContainsKey(robotName);
            return robotExist;
        }
    }
}
