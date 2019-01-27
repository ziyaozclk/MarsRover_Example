using MarsRover_Case.ConsoleApp.CardinalDirections;
using MarsRover_Case.ConsoleApp.Movements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Rovers
{
    public interface IRover
    {
        Plateau plateau { get; set; }
        Position CurrentPosition { get; set; }
        CardinalDirectionType CardinalDirectionType { get; set; }
        void Initialize(Plateau plateau, Position position, CardinalDirectionType directionType);
        void Move(IEnumerable<IMovement> movements);
    }
}
