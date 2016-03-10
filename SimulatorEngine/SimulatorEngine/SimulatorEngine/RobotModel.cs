using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        bool isMoving = false;
        Point positionToReach;

        #region GET/SET
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
            set
            {
                _position = value;
                //send a notification to the controller
                this.SimulatorEngine.Controller.SendPositionChange(this.Name, this.Position.X, this.Position.Y);
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Orientation
        {
            get { return _orientation; }
            set
            {
                _orientation = value;
                //send a notification to the controller
                this.SimulatorEngine.Controller.SendOrientationChanged(this.Name, this.Orientation);
            }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        #endregion

        public RobotModel(SimulatorEngineModel simulatorEngine, string name, Point position_xy, int orientation, string instructionFilePath)
            : this(simulatorEngine, name, position_xy.X, position_xy.Y, orientation, instructionFilePath)
        {
            //no code here
        }

        public RobotModel(SimulatorEngineModel simulatorEngine, string name, int position_x, int position_y, int orientation, string instructionFilePath)
        {
            this.SimulatorEngine = simulatorEngine;
            this.Name = name;
            this.Position = new Point(position_x, position_y);
            this.Orientation = orientation;
            this.CurrentInstruction = DEFAULT_CURRENT_INSTRUCTION;
            this.Instructions = new List<string>();
            AddInstructions(instructionFilePath);
        }

        //send instruction to the robot
        public void AddInstructions(string instructionFilePath)
        {
            string line = "";
            StreamReader file = new StreamReader(instructionFilePath);
            while ((line = file.ReadLine()) != null)
            {
                this.Instructions.Add(line);
            }
        }

        /// <summary>
        /// simple Degree to radian convesions
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        private double DegreeToRadian(int degree)
        {
            return Math.PI * degree / 180;
        }

        /// <summary>
        /// This calculate the position to reach and move the robot depend of it's speed
        /// </summary>
        /// <param name="distanceToReach"></param>
        /// <returns></returns>
        private bool UpdatePosition(int distanceToReach)
        {

            // the distance that the robot can reach for one tick = VITESSE/ SAMPLE_PER_SECOND
            double distanceByTick = this.Speed / SimulatorEngineModel.SAMPLE_PER_SECOND;

            if(!isMoving)
            {
                positionToReach = new Point(Convert.ToInt32(this.Position.X + distanceToReach * Math.Cos(DegreeToRadian(Orientation))),
                                            Convert.ToInt32(this.Position.Y + distanceToReach * Math.Sin(DegreeToRadian(Orientation))));
                isMoving = true;
            }

            this.Position = new Point(Convert.ToInt32(this.Position.X + distanceByTick * Math.Cos(DegreeToRadian(Orientation))), Convert.ToInt32(this.Position.Y + distanceByTick * Math.Sin(DegreeToRadian(Orientation))));

            Console.WriteLine("{0};{1}", this.Position.X, this.Position.Y);

            if (this.Position.X == positionToReach.X && Position.Y == positionToReach.Y)
            {
                isMoving = false;
                return true;
            }
            return false;

        }

        /// <summary>
        /// This return the parameter of the robot instruction
        /// </summary>
        /// <returns></returns>
        private int getInstructionParam()
        {
            return Convert.ToInt32(Regex.Match(this.Instructions[CurrentInstruction], @"-?[0-9]\d*(\.\d+)?").Value);
        }

        /// <summary>
        /// This apply one instruction
        /// </summary>
        public void ApplyInstruction()
        {
            //get the instruction name
            string instructionName = Regex.Match(this.Instructions[CurrentInstruction], @"[a-zA-Z]+").Value;
            //define if the instruction is not done yet
            bool instructionTerminated = false;
            switch (instructionName)
            {
                //init the position and the orientation of the robot with default values
                case "RS":
                    this.Position = new Point(200, 800);
                    this.Orientation = 0;
                    instructionTerminated = true;
                    break;

                //change the speed
                case "VI":
                    this.Speed = getInstructionParam();
                    instructionTerminated = true;
                    break;

                //move to a new point
                case "AV":
                    instructionTerminated = UpdatePosition(getInstructionParam());
                    break;

                //change the oritentation
                case "GC":
                    this.Orientation = getInstructionParam();
                    instructionTerminated = true;
                    break;

                default:
                    instructionTerminated = true;
                    break;
            }

            if (instructionTerminated == true && CurrentInstruction < this.Instructions.Count - 1)
            {
                Console.WriteLine(Instructions[CurrentInstruction] + " done");
                CurrentInstruction++;
            }
        }


    }
}
