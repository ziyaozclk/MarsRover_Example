using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MarsRover_Case.ConsoleApp.CardinalDirections;
using MarsRover_Case.ConsoleApp.Rovers;

namespace MarsRover_Case.ConsoleApp.Movements
{
    public class LeftMovement : IMovement
    {
        public void Execute(IRover rover)
        {
            switch (rover.CardinalDirectionType)
            {
                case CardinalDirectionType.North:
                    rover.CardinalDirectionType = CardinalDirectionType.West;
                    break;
                case CardinalDirectionType.East:
                    rover.CardinalDirectionType = CardinalDirectionType.North;
                    break;
                case CardinalDirectionType.South:
                    rover.CardinalDirectionType = CardinalDirectionType.East;
                    break;
                case CardinalDirectionType.West:
                    rover.CardinalDirectionType = CardinalDirectionType.South;
                    break;
            }
        }
    }
}
