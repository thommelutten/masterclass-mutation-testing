using HouseBuilder.Enums;

namespace HouseBuilder
{
    public class House
    {
        public List<WallType> Walls { get; private set; }
        public List<WindowType> Windows { get; private set; }
        public List<DoorType> Doors { get; private set; }
        public bool HasChimney { get; set; }

        internal House()
        {
            Walls = new List<WallType>();
            Windows = new List<WindowType>();
            Doors = new List<DoorType>();
            HasChimney = false;
        }

        public static HouseBuilder CreateBuilder()
        {
            return new HouseBuilder();
        }
    }
}