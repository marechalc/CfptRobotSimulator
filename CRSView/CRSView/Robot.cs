using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRSView
{
    public class Robot
    {
        #region PROPERTIES
        private string _name;
        private Point _position;
        private int _orientation;
        #endregion

        #region GET/SET
        public int Orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Point Position
        {
            get { return _position; }
            set { _position = value; }
        }
        #endregion

        public Robot(string name, Point position)
        {
            this.Name = name;
            this.Position = position;
        }
        
        public Robot(string name, Point position, int orientation)
        {
            this.Name = name;
            this.Position = position;
            this.Orientation = orientation;
        }
    }
}
