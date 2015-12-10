using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvyBus;


namespace IvyControllers
{
    public abstract class AbstractIvyController
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
        /// Default message filter for the Ivy Bus used by constructors that do not define it.
        /// </summary>
        public const string DEFAULT_BUS_MESSAGE_FILTER = "";

        /// <summary>
        /// Default ready message for the Ivy Bus used by constructors that do not define it.
        /// </summary>
        public const string DEFAULT_BUS_READY_MESSAGE = "READY";
        
        #endregion

        #region Properties
        
        /// <summary>
        /// Provides connection to a shared network bus, used to broadcast information through network.
        /// </summary>
        protected Ivy IvyBus { get; set; }

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
        public AbstractIvyController(string name, string readyMessage, string messageFilter, string broadcastAddress, string broadcastPort)
        {
            IvyBus = new Ivy(name, readyMessage);
            IvyBus.BindMsg(messageFilter, MessageReceivedCallback);
            IvyBus.Start(String.Format("{0}:{1}", broadcastAddress, broadcastPort));
        }

        /// <summary>
        /// Instanciates an IvyController using default broadcast address and port.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="readyMessage"></param>
        /// <param name="messageFilter"></param>
        public AbstractIvyController(string name, string readyMessage, string messageFilter)
            : this(name, readyMessage, messageFilter, DEFAULT_BUS_BROADCAST_ADDRESS, DEFAULT_BUS_BROADCAST_PORT)
        { }

        /// <summary>
        /// Instanciates an IvyController using default ready message, message filter, broadcast address and port.
        /// </summary>
        /// <param name="name"></param>
        public AbstractIvyController(string name)
            : this(name, DEFAULT_BUS_READY_MESSAGE, DEFAULT_BUS_MESSAGE_FILTER, DEFAULT_BUS_BROADCAST_ADDRESS, DEFAULT_BUS_BROADCAST_PORT)
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Sends the given message through the bus.
        /// </summary>
        /// <param name="args"></param>
        public void SendMessageThroughBus(object[] args)
        {
            IvyBus.SendMsg("", args);
        }

        /// <summary>
        /// Called on every message received through the bus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal virtual void MessageReceivedCallback(object sender, IvyMessageEventArgs e)
        {

        }
        #endregion
    }
}
