using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRSView
{
    public class GameArea
    {
        #region PROPERTIES
        private int _width; //SC/ width in millimeter
        private int _height; //SC/ height in millimeter
        #endregion

        #region GET/SET
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        #endregion

        /// <summary>
        /// //SC/ Default Constructor
        /// </summary>
        /// <param name="width">width in millimeter</param>
        /// <param name="height">height in millimeter</param>
        public GameArea(int width, int height)
        {
            this.Width = width;
            this.Height = Height;
        }

    }
}
