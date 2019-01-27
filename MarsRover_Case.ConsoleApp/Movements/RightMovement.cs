using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Movements
{
    public class RightMovement : IMovement
    {
        public void Execute(IRover rover)
        {
            switch (rover.CardinalDirectionType)
            {
                case CardinalDirectionType.North:
                    rover.CardinalDirectionType = CardinalDirectionType.East;
                    break;
                case CardinalDirectionType.East:
                    rover.CardinalDirectionType = CardinalDirectionType.South;
                    break;
                case CardinalDirectionType.South:
                    rover.CardinalDirectionType = CardinalDirectionType.West;
                    break;
                case CardinalDirectionType.West:
                    rover.CardinalDirectionType = CardinalDirectionType.North;
                    break;
            }
        }
    }
}
