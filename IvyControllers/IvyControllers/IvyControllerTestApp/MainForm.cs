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
        IvyController Controller { get; set; }

        public MainForm()
        {
            InitializeComponent();

            // Create controller with a name corresponding to the hash code of the application
            Controller = new IvyController(this.GetHashCode().ToString());
            Controller.PositionChanged += Controller_PositionChanged;
            Controller.OrientationChanged += Controller_OrientationChanged;
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
    }
}
