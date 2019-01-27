using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Movements
{
    public class ForwardMovement : IMovement
    {
        public void Execute(IRover rover)
        {
            switch (rover.CardinalDirectionType)
            {
                case CardinalDirectionType.North:
                    rover.CurrentPosition = new Position(rover.CurrentPosition.X, rover.CurrentPosition.Y + 1);
                    break;
                case CardinalDirectionType.East:
                    rover.CurrentPosition = new Position(rover.CurrentPosition.X + 1, rover.CurrentPosition.Y);
                    break;
                case CardinalDirectionType.South:
                    rover.CurrentPosition = new Position(rover.CurrentPosition.X, rover.CurrentPosition.Y - 1);
                    break;
                case CardinalDirectionType.West:
                    rover.CurrentPosition = new Position(rover.CurrentPosition.X - 1, rover.CurrentPosition.Y);
                    break;
            }
        }
    }
}
