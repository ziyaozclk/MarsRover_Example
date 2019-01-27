using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover_Case.ConsoleApp.CardinalDirections
{
    public interface ICardinalDirection
    {
        void Change(IRover rover);
    }
}
