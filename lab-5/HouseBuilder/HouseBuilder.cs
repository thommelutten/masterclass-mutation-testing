using HouseBuilder.Enums;
namespace HouseBuilder
{
    public class HouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            _house = new House();
        }

        public HouseBuilder AddWall(WallType material)
        {
            _house.Walls.Add(material);
            return this;
        }

        public HouseBuilder AddWindow(WindowType windowType)
        {
            _house.Windows.Add(windowType);
            return this;
        }

        public HouseBuilder AddDoor(DoorType doorType)
        {
            _house.Doors.Add(doorType);
            return this;
        }

        public HouseBuilder WithChimney()
        {
            _house.HasChimney = true;
            return this;
        }

        public House Build()
        {
            if (_house.Walls.Count < 4)
            {
                throw new InvalidOperationException("A house must have at least 4 walls.");
            }
            House house = _house;

            this.Reset();

            return house;
        }

        private void Reset()
        {
            _house = new House();
        }
    }
}
