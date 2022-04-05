using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace MarsRovers.Steps
{
    [Binding]
    public class MoveRoverSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Rover rover;


        public MoveRoverSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        //        Given Rover is in plateau at (<X>,<Y>) co-ordinates and facing <Direction>
        //[Given(@"Rover is in plateau at \((\d+),(\d+)\) co-ordinates and facing ([NEWS]{1})")]
        //public void GivenRoverIsInPlateauAtCo_OrdinatesAndFacing(int x, int y, string direction)
        //{
        //    rover = new Rover();
        //    Point point = new Point(x, y);
        //    rover.Position = point;
        //    rover.Direction = direction;
        //}

        [When(@"the rover moves")]
        public void WhenTheRoverMoves()
        {
            rover = new Rover();
            rover.Move();
        }

        [Then(@"the rover reaches new position ([NEWS]{1}) in the same \((\d+),(\d+)\).")]
        public void ThenTheRoverReachesNewPositionInTheSame(string direction, int x, int y)
        {
            rover.Direction.Should().Be(direction);
            rover.Position.Should().Be(new Point(x, y));
        }
    }
}
