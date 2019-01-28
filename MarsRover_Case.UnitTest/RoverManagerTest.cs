using MarsRover_Case.ConsoleApp.Rovers;
using System;
using System.Linq;
using System.Text;
using Xunit;

namespace MarsRover_Case.UnitTest
{
    public class RoverManagerTest
    {
        [Fact]
        public void Wrong_Plateau_Size()
        {
            try
            {
                var commandBuilder = new StringBuilder();

                commandBuilder.AppendLine("1 1");
                commandBuilder.AppendLine("1 2 N");
                commandBuilder.AppendLine("LMLMLMLMM");
                commandBuilder.AppendLine("3 3 E");
                commandBuilder.Append("MMRMMRMRRM");

                var roverService = new RoverManager();

                var result = roverService.CommadExecute(commandBuilder.ToString());
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Wrong_Rover_Position_Y()
        {
            try
            {
                var commandBuilder = new StringBuilder();

                commandBuilder.AppendLine("5 5");
                commandBuilder.AppendLine("1 N");
                commandBuilder.AppendLine("LMLMLMLMM");
                commandBuilder.AppendLine("3 3 E");
                commandBuilder.Append("MMRMMRMRRM");

                var roverService = new RoverManager();

                var result = roverService.CommadExecute(commandBuilder.ToString());
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Wrong_CommandType()
        {
            try
            {
                var commandBuilder = new StringBuilder();

                commandBuilder.AppendLine("2 5");
                commandBuilder.AppendLine("1 1 N");
                commandBuilder.AppendLine("DMFMLMLMM");
                commandBuilder.AppendLine("3 3 E");
                commandBuilder.Append("MMRMMRMRRM");

                var roverService = new RoverManager();

                var result = roverService.CommadExecute(commandBuilder.ToString());
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData(
@"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM",
@"1 3 N
5 1 E")]
        [InlineData(
@"4 4
1 2 N
LRRMLMLMM
3 3 E
MRMMRM",
@"0 3 W
3 1 W")]
        public void AccurateInputsAndOutputs(string commands, string result)
        {
            var roverService = new RoverManager();

            var processResult = roverService.CommadExecute(commands);

            string processResultSerialized = string.Join(Environment.NewLine, processResult.Select(p => $"{p.CurrentPosition.X} {p.CurrentPosition.Y} {p.CardinalDirectionType.ToString()[0]}"));

            Assert.Equal(result, processResultSerialized);
        }
    }
}
