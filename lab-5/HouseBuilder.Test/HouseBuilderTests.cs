using HouseBuilder.Enums;

namespace HouseBuilder.Test
{
    [TestFixture]
    public class HouseBuilderTests
    {
        private HouseBuilder _houseBuilder;

        [SetUp]
        public void SetUp()
        {
            _houseBuilder = House.CreateBuilder()
                .AddWall(WallType.Brick)
                .AddWall(WallType.Brick)
                .AddWall(WallType.Stone)
                .AddWall(WallType.Concrete);
        }

        [Test]
        public void HouseBuilder_BuildHouseWithWalls_Success()
        {
            House house = _houseBuilder
                .Build();

            Assert.That(house, Is.Not.Null);
            Assert.That(house.Walls, Has.Count.EqualTo(4));
            Assert.That(house.Walls,
                Has.Exactly(2).EqualTo(WallType.Brick)
                .And.Exactly(1).EqualTo(WallType.Stone)
                .And.Exactly(1).EqualTo(WallType.Concrete));
        }

        [Test]
        public void HouseBuilder_BuildHouseWithInsufficientWalls_ThrowsException()
        {
            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                House house = House.CreateBuilder()
                    .AddWall(WallType.Brick)
                    .Build();
            });

            Assert.That(exception.Message, Is.EqualTo("A house must have at least 4 walls."));
        }

        [Test]
        public void HouseBuilder_BuildHouseWithWallsAndWindow_Success()
        {
            House house = _houseBuilder
                .AddWindow(WindowType.Medium)
                .Build();

            Assert.That(house.Windows, Has.Exactly(1).EqualTo(WindowType.Medium));
        }

        [Test]
        public void HouseBuilder_BuildHouseWithChimney_Success()
        {
            House house = _houseBuilder
                .WithChimney()
                .Build();

            Assert.That(house.HasChimney, Is.True);
        }

        [Test]
        public void HouseBuilder_BuildHouseWithoutChimney_Success()
        {
            House house = _houseBuilder
                .Build();
        }

        [Test]
        public void HouseBuilder_BuildHouseWithSingleDoor_Success()
        {

        }
    }
}