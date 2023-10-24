using HouseBuilder.Enums;

namespace HouseBuilder.Test
{
    [TestFixture]
    public class HouseBuilderTests
    {
        [Test]
        public void HouseBuilder_BuildHouseWithWalls_Success()
        {
            House house = House.CreateBuilder()
                .AddWall(WallMaterial.Brick)
                .AddWall(WallMaterial.Brick)
                .AddWall(WallMaterial.Stone)
                .AddWall(WallMaterial.Concrete)
                .Build();

            Assert.That(house, Is.Not.Null);
            Assert.That(house.Walls, Has.Count.EqualTo(4));
            Assert.That(house.Walls,
                Has.Exactly(2).EqualTo(WallMaterial.Brick)
                .And.Exactly(1).EqualTo(WallMaterial.Stone)
                .And.Exactly(1).EqualTo(WallMaterial.Concrete));
        }

        [Test]
        public void HouseBuilder_BuildHouseWithInsufficientWalls_ThrowsException()
        {
            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                House house = House.CreateBuilder()
                    .AddWall(WallMaterial.Brick)
                    .Build();
            });

            Assert.That(exception.Message, Is.EqualTo("A house must have at least 4 walls."));
        }
    }
}