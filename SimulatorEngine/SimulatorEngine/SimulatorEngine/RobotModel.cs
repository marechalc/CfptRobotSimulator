using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SimulatorEngine
{
    public class RobotModel
    {
        private const int DEFAULT_SPEED = 0;
        private const int DEFAULT_CURRENT_INSTRUCTION = 0;
        private SimulatorEngineModel _simulatorEngine;
        Point _position;
        int _speed;
        string _name;
        int _orientation;
        int _currentInstruction;

        public int CurrentInstruction
        {
            get { return _currentInstruction; }
            set { _currentInstruction = value; }
        }
        private List<string> _instructions;

        public List<string> Instructions
        {
            get { return _instructions; }
            set { _instructions = value; }
        }


        public SimulatorEngineModel SimulatorEngine
        {
            get { return _simulatorEngine; }
            set { _simulatorEngine = value; }
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

        public RobotModel(SimulatorEngineModel simulatorEngine, string name, Point position_xy, int orientation)
            : this(simulatorEngine, name, position_xy.X, position_xy.Y, orientation)
        {
            //no code here
        }

        public RobotModel(SimulatorEngineModel simulatorEngine, string name, int position_x, int position_y, int orientation)
        {
            this.SimulatorEngine = simulatorEngine;
            this.Name = name;
            this.Position = new Point(position_x, position_y);
            this.Orientation = orientation;
            this.CurrentInstruction = DEFAULT_CURRENT_INSTRUCTION;    
        }


        private double DegreeToRadian(int degree)
        {
            return Math.PI * degree / 180;
        }

        private bool UpdatePosition(int distanceToReach)
        {
            // AVANCEMENT PAR TICK: VITESSE/ SAMPLE_PER_SECOND
            double distanceByTick = this.Speed / SimulatorEngineModel.SAMPLE_PER_SECOND;

            Point positionToReach= new Point(Convert.ToInt32(this.Position.X + distanceToReach * Math.Cos(DegreeToRadian(Orientation))),
                                             Convert.ToInt32(this.Position.Y + distanceToReach * Math.Sin(DegreeToRadian(Orientation))));

            this.Position= new Point(this.Position.X+Convert.ToInt32(this.Position.X + distanceByTick * Math.Cos(DegreeToRadian(Orientation))),this.Position.Y+Convert.ToInt32(this.Position.X+distanceByTick * Math.Sin(DegreeToRadian(Orientation))));

           if(this.Position.X==positionToReach.X && Position.Y==positionToReach.Y)
           {
               return true;
           }

           return false;

        }

        /// <summary>
        /// This apply an instruction
        /// </summary>
        public  void ApplyInstruction()
        {
            string instructionName = Regex.Split(this.Instructions[CurrentInstruction], @"\[a-zA-Z]+")[0];
            int instructionParam = Convert.ToInt32(Regex.Split(this.Instructions[CurrentInstruction], @"\-?[0-9]\d*(\.\d+)?")[0]);
            bool instructionTerminated = false;
            switch (instructionName)
            {
                case "RS":
                    this.Position = new Point(200, 800);
                    this.Orientation = 0;
                    instructionTerminated = true;
                    break;

                case "VI":
                    this.Speed = instructionParam;
                    instructionTerminated = true;
                    break;

                case "AV":
                          
                    instructionTerminated=UpdatePosition(instructionParam);

                    break;


                case "GC":
                    this.Orientation = instructionParam;
                    instructionTerminated = true;
                    break;

            }

            if(instructionTerminated==true)
            {
                update();
                CurrentInstruction++;
            }

        }

        public void update()
        {

            Console.WriteLine(Instructions[CurrentInstruction] + "done");


        }
    }
}
