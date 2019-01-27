using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover_Case.ConsoleApp
{
    public class Plateau
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Plateau(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsValid(Position position)
        {
            var isValidX = position.X >= 0 && position.X <= Width;
            var isValidY = position.Y >= 0 && position.Y <= Height;
            return isValidX && isValidY;
        }
    }
}
