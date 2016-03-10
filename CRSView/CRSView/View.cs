using IvyControllers;
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
        IvyController Controller; //SC/ Link to our controller
        Dictionary<string, Robot> robots; //SC/ Dictionnary of robots

        public View()
        {
            InitializeComponent();

            //SC/ Instantiate the game area and the list of robots
            GameArea gameArea = new GameArea(3000, 2000);
            this.robots = new Dictionary<string,Robot>();
        }

        private void View_Load(object sender, EventArgs e)
        {
            //DL/ Create controller with a name corresponding to the hash code of the application
            this.Controller = new IvyController(this.GetHashCode().ToString());
            Controller.PositionChanged += Controller_PositionChanged;
            Controller.OrientationChanged += Controller_OrientationChanged;
        }

        /// <summary>
        /// //SC/ Update the View
        /// </summary>
        private void updateView()
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            var pen = new Pen(Color.Red);

            foreach (var robot in this.robots)
            {
                // TO DO
                g.DrawRectangle(
                    pen, 
                    robot.Value.Position.X / 3000f * Width , 
                    robot.Value.Position.Y / 2000f * Height, 
                    20, 
                    20);
            }

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
                Robot robot = this.robots[robotName];
                // TO DO CHANGE ORIENTATION
            }
            else
            {
                //SC/ Robot doesn't exist !
            }
            updateView();
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
                Robot robot = this.robots[robotName];
                robot.Position = new Point(x, y);
            }
            else
            {
                //SC/ Robot doesn't exist create a new one
                // and add it to our list of robots
                this.CreateRobot(robotName, x, y);
            }
            updateView();
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
            Robot robot = new Robot(robotName, new Point(x, y));

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
