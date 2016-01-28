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

namespace IvyControllerTestApp
{
    public partial class MainForm : Form
    {
        private bool _connected;

        private IvyController Controller { get; set; }
        private bool Connected
        {
            get
            {
                return _connected;
            }
            set
            {
                if (value)
                {
                    btnConnect.Text = "Disconnect";
                    gbSend.Enabled = true;
                    gbReceived.Enabled = true;
                    tbxAddress.Enabled = false;
                    tbxPort.Enabled = false;
                    _connected = true;
                }
                else
                {
                    btnConnect.Text = "Connect";
                    if (Controller != null) { Controller.Dispose(); }
                    gbSend.Enabled = false;
                    gbReceived.Enabled = false;
                    tbxAddress.Enabled = true;
                    tbxPort.Enabled = true;
                    _connected = false;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSendPos_Click(object sender, EventArgs e)
        {
            Controller.SendPositionChange(txtPosName.Text, (int)numPosX.Value, (int)numPosY.Value);
        }

        private void btnSendOrientation_Click(object sender, EventArgs e)
        {
            Controller.SendOrientationChanged(txtOrientationName.Text, (int)numAngle.Value);
        }

        void Controller_PositionChanged(string robotName, int x, int y)
        {
            lbxReceived.Items.Add(
                String.Format("Position changed for robot {0}. New point is ({1}, {2}).",
                robotName, x, y));
        }

        void Controller_OrientationChanged(string robotName, int orientation)
        {
            lbxReceived.Items.Add(
                String.Format("Orientation changed for robot {0}. New angle is ({1}).",
                robotName, orientation));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Controller != null)
            {
                Controller.Dispose();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Connected)
            {
                try
                {
                    Controller = new IvyController(this.GetHashCode().ToString(), tbxAddress.Text, tbxPort.Text);
                    Controller.PositionChanged += Controller_PositionChanged;
                    Controller.OrientationChanged += Controller_OrientationChanged;

                    Connected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error while loading IvyController: {0}", ex.Message));

                    Connected = false;
                }
            }
            else
            {
                Connected = false;
            }
        }
    }
}
