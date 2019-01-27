using MarsRover_Case.ConsoleApp.CardinalDirections;
using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Movements
{
    public interface IMovement
    {
        void Execute(IRover rover);
    }
}
