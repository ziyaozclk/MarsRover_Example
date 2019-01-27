using MarsRover_Case.ConsoleApp.CardinalDirections;
using MarsRover_Case.ConsoleApp.Movements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Rovers
{
    public class Rover : IRover
    {
        public Position CurrentPosition { get; set; }
        public CardinalDirectionType CardinalDirectionType { get; set; }
        public Plateau plateau { get; set; }

        public void Initialize(Plateau plateau, Position position, CardinalDirectionType directionType)
        {
            if (plateau.IsValid(position))
            {
                this.plateau = plateau;
                CurrentPosition = position;
                CardinalDirectionType = directionType;
                return;
            }

            throw new Exception("Rover position is wrong. Because it is outside of plateau");
        }

        public void Move(IEnumerable<IMovement> movements)
        {
            foreach (var item in movements)
            {
                item.Execute(this);
            }
        }
    }
}
