using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SimulatorEngine
{
    public class RobotModel
    {
        private const int DEFAULT_SPEED = 0;

        private SimulatorEngineModel _simulatorEngine;
        Point _position;
        int _speed;
        string _name;
        int _orientation;
        string _instruction;

        public SimulatorEngineModel SimulatorEngine
        {
            get { return _simulatorEngine; }
            set { _simulatorEngine = value; }
        }

        public string Instruction
        {
            get { return _instruction; }
            set
            {
                _instruction = value;
                ApplyInstruction();
            }
        }

        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public RobotModel(SimulatorEngineModel simulatorEngine, string name, Point position_xy, int orientation, string instruction)
            : this(simulatorEngine, name, position_xy.X, position_xy.Y, orientation, instruction)
        {
            //no code here
        }

        public RobotModel(SimulatorEngineModel simulatorEngine, string name, int position_x, int position_y, int orientation, string instruction)
        {
            this.SimulatorEngine = simulatorEngine;
            this.Name = name;
            this.Position = new Point(position_x, position_y);
            this.Orientation = orientation;
            this.Instruction = instruction;
        }

        /// <summary>
        /// This apply an instruction
        /// </summary>
        private void ApplyInstruction()
        {
            string instructionName = Regex.Split(this.Instruction, @"\[a-zA-Z]+")[0];
            int instructionParam = Convert.ToInt32(Regex.Split(this.Instruction, @"\-?[0-9]\d*(\.\d+)?")[0]);

            switch (instructionName)
            {
                case "RS":
                    this.Position = new Point(200, 800);
                    this.Orientation = 0;
                    break;

                case "VI":
                    this.Speed = instructionParam;
                    break;

                case "AV":

                    break;


                case "GC":
                    this.Orientation = instructionParam;
                    break;

            }



        }

        public void update()
        {




        }
    }
}
