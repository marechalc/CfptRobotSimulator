﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvyBus;
using System.Text.RegularExpressions;


namespace IvyControllers
{
    public class IvyController : IDisposable
    {
        #region Constants
        /// <summary>
        /// Default broadcast address for the Ivy Bus used by constructors that do not define it.
        /// </summary>
        public const string DEFAULT_BUS_BROADCAST_ADDRESS = "255.255.255.255";

        /// <summary>
        /// Default port for the Ivy Bus used by constructors that do not define it.
        /// </summary>
        public const string DEFAULT_BUS_BROADCAST_PORT = "2010";

        /// <summary>
        /// Default ready message for the Ivy Bus used by constructors that do not define it.
        /// </summary>
        public const string DEFAULT_BUS_READY_MESSAGE = "READY";
        
        /// <summary>
        /// Regex pattern used for PositionChanged messages
        /// </summary>
        public const string POSITION_CHANGED_REGEX = @"^PositionChanged ([A-Za-z]+) ([0-9]+) ([0-9]+)";

        /// <summary>
        /// Regex pattern used for OrientationChanged messages
        /// </summary>
        public const string ORIENTATION_CHANGED_REGEX = @"^RotationChanged ([A-Za-z]+) ([0-9]+)";
        #endregion

        #region Private properties
        /// <summary>
        /// Provides connection to a shared network bus, used to broadcast information through network.
        /// </summary>
        private Ivy IvyBus { get; set; }
        #endregion

        #region Events
        public delegate void PositionChangedEventHandler(string robotName, int x, int y);
        public delegate void OrientationChangedEventHandler(string robotName, int angle);
        
        public event PositionChangedEventHandler PositionChanged;
        public event OrientationChangedEventHandler OrientationChanged;
        #endregion

        #region Constructors
        /// <summary>
        /// Instanciates an IvyController.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="readyMessage"></param>
        /// <param name="messageFilter"></param>
        /// <param name="broadcastAddress"></param>
        /// <param name="broadcastPort"></param>
        public IvyController(string name, string readyMessage, string broadcastAddress, string broadcastPort)
        {
            IvyBus = new Ivy(name, readyMessage);
            IvyBus.Start(String.Format("{0}:{1}", broadcastAddress, broadcastPort));

            IvyBus.BindMsg(POSITION_CHANGED_REGEX, OnPositionChangedReceived);
            IvyBus.BindMsg(ORIENTATION_CHANGED_REGEX, OnOrientationChangedReceived);
        }

        /// <summary>
        /// Instanciates an IvyController using default broadcast address and port.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="readyMessage"></param>
        /// <param name="messageFilter"></param>
        public IvyController(string name, string readyMessage)
            : this(name, readyMessage, DEFAULT_BUS_BROADCAST_ADDRESS, DEFAULT_BUS_BROADCAST_PORT)
        { }

        /// <summary>
        /// Instanciates an IvyController using default ready message, message filter, broadcast address and port.
        /// </summary>
        /// <param name="name"></param>
        public IvyController(string name)
            : this(name, DEFAULT_BUS_READY_MESSAGE, DEFAULT_BUS_BROADCAST_ADDRESS, DEFAULT_BUS_BROADCAST_PORT)
        { }
        #endregion

        #region Private Methods
        /// <summary>
        /// Called by IvyBus when a rotation change message has been received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPositionChangedReceived(object sender, IvyMessageEventArgs e)
        {
            Regex regex = new Regex(POSITION_CHANGED_REGEX);

            Match result = regex.Match(e.GetArguments()[0]);

            if (result.Captures.Count == 3)
            {
                string robotName = result.Captures[0].Value;
                int x = Convert.ToInt32(result.Captures[1].Value);
                int y = Convert.ToInt32(result.Captures[2].Value);

                PositionChanged(robotName, x, y);
            }
        }

        /// <summary>
        /// Called by IvyBus when an orientation change message has been received
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOrientationChangedReceived(object sender, IvyMessageEventArgs e)
        {
            Regex regex = new Regex(ORIENTATION_CHANGED_REGEX);

            Match result = regex.Match(e.GetArguments()[0]);

            if (result.Captures.Count == 2)
            {
                string robotName = result.Captures[0].Value;
                int angle = Convert.ToInt32(result.Captures[1].Value);

                OrientationChanged(robotName, angle);
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Broadcasts a new position on the bus
        /// </summary>
        /// <param name="robotName">Identifier of the robot</param>
        /// <param name="x">New horizontal position in millimeters</param>
        /// <param name="y">New vertical position in millimeters</param>
        public void SendPositionChange(string robotName, int x, int y)
        {
            IvyBus.SendMsg(String.Format("PositionChanged {0} {1} {2}",
                robotName, x, y));
        }

        /// <summary>
        /// Broadcasts a new orientation on the bus
        /// </summary>
        /// <param name="robotName">Identifier of the robot</param>
        /// <param name="angle">New orientation of the robot</param>
        public void SendOrientationChanged(string robotName, int angle)
        {
            IvyBus.SendMsg(String.Format("OrientationChanged {0} {1}",
                robotName, angle));
        }

        #region IDisposable implementation
        public void Dispose()
        {
            IvyBus.Stop();
        }
        #endregion
        #endregion
    }
}
