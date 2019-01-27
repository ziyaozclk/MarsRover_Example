using MarsRover_Case.ConsoleApp.CardinalDirections;
using MarsRover_Case.ConsoleApp.Movements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MarsRover_Case.ConsoleApp.Rovers
{
    public class RoverManager
    {
        private readonly Dictionary<string, IMovement> movementDictionary;
        private readonly Dictionary<string, CardinalDirectionType> cardinalDirectionDictionary;

        private Plateau plateau = null;
        private List<Rover> roverList = null;

        public RoverManager()
        {
            movementDictionary = new Dictionary<string, IMovement>
            {
                { "L", new LeftMovement() },
                { "R", new RightMovement() },
                { "M", new ForwardMovement() },
            };

            cardinalDirectionDictionary = new Dictionary<string, CardinalDirectionType>
            {
                { "E", CardinalDirectionType.East },
                { "N", CardinalDirectionType.North },
                { "W", CardinalDirectionType.West },
                { "S", CardinalDirectionType.South },
            };

            roverList = new List<Rover>();
        }

        public List<Rover> CommadExecute(string command)
        {
            var commands = command.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToList();

            var position = commands.First().Split(' ').Select(a => int.Parse(a)).ToList();

            plateau = new Plateau(position[0], position[1]);

            for (int i = 1; i < commands.Count; i += 2)
            {
                var roverParameters = commands[i].Split(' ');
                List<char> roverMovementParameters = commands[i + 1].ToList();

                var roverPosition = new Position(int.Parse(roverParameters[0]), int.Parse(roverParameters[1]));

                Rover rover = new Rover();
                rover.Initialize(plateau, roverPosition, cardinalDirectionDictionary[roverParameters[2]]);

                var movementList = roverMovementParameters.Select(a => movementDictionary[a.ToString()]);
                rover.Move(movementList);

                roverList.Add(rover);
            }

            return roverList;
        }
    }
}
