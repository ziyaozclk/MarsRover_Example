using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Rovers
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
