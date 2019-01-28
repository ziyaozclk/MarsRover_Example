using MarsRover_Case.ConsoleApp.Movements;
using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MarsRover_Case.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandString =
                @"4 4
1 2 N
LRRMLMLMM
3 3 E
MMRMMRMRRM";

            RoverManager roverManager = new RoverManager();

            var roverResult = roverManager.CommadExecute(commandString);

            foreach (var rover in roverResult)
            {
                Console.WriteLine(rover.CurrentPosition.X + " " + rover.CurrentPosition.Y + " " + rover.CardinalDirectionType.ToString());
            }
            Console.WriteLine("Hello World!");
        }
    }
}
