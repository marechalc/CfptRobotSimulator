/**
 * Author       : Gilles Bergerat
 * Description  : Receptor
 * Class        : T.IS-E2A
 * Date         : 10.12.2015
 * Version      : 1.0
 * */
using System;
using System.Windows.Forms;
using IvyBus;
namespace IvyTools
{
    public partial class Form1 : Form
    {
        private Ivy bus;

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Displays data received in a listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMessage(object sender, IvyMessageEventArgs e)
        {
            foreach (var message in e.GetArguments())
            {
                lbxData.Items.Add(message);
            }
        }

        /// <summary>
        /// Allows you to change subscription to a message
        /// </summary>
        private void changedMesage()
        {
            bus.Stop();

            bus = new Ivy();

            try
            {
                bus.Start(tbxAdresse.Text);
            }
            catch (IvyException ie)
            {
                MessageBox.Show("Error " + ie.GetBaseException());
            }
        }

        /// <summary>
        /// Connect to the IvyBus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            bus = new Ivy("my_apply", "my_apply Ready");

            try
            {
                bus.Start(tbxAdresse.Text);
                MessageBox.Show("You are connected");
            }
            catch (IvyException ie)
            {
                MessageBox.Show("Error " + ie.GetBaseException());
            }
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
        }

        /// <summary>
        /// Disconnect to the IvyBus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            bus.Stop();
            MessageBox.Show("You are disconnected");
        }

        /// <summary>
        /// Select the data to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxChooseData_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedMesage();
            int choice = cbxChooseData.SelectedIndex;
            switch (choice)
            {
                case 0: // PositionChanged selected
                    bus.BindMsg("^(PositionChanged.*)", addMessage);
                    break;

                case 1: // OrientationChanged selected
                    bus.BindMsg("^(OrientationChanged.*)", addMessage);
                    break;

                case 2: // Position X only selected
                    bus.BindMsg("(.*Posx.r.*)", addMessage);
                    break;

                case 3: // Position Y only selected
                    bus.BindMsg("(.*Posy.r.*)", addMessage);
                    break;

                case 4: // Sending engine selected
                    bus.BindMsg("(.*MOTEUR.*)", addMessage);
                    break;

                case 5: // Received Bluetooth selected
                    bus.BindMsg("(.*BLUETOOTH.*)", addMessage);
                    break;
                default:
                    break;
            }
        }
    }
}