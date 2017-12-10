using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    //This class should take care of object Current Location as well as Changing it (looking for borders, gates etc.)
    class Location
    {
        private int xCoordiante;
        private int yCoordinate;
        public int XCoordinate
        {
            get { return this.xCoordiante; }
            set
            {
                if (value <= 0 || value >= 127)
                {
                    throw new ArgumentException("Border reached");
                }
                this.xCoordiante = value;
            }
        }
        public int YCoordinate { get { return this.yCoordinate; } set {
                if (value<=0||value>=80)
                {
                    throw new ArgumentException("Border reached");
                }
                this.yCoordinate = value; } }
        public Location(int xCoordinate, int yCoordinate)
        {

        }
    }
}
