using HouseBuilder.Enums;

namespace HouseBuilder
{
    public class House
    {
        public List<WallMaterial> Walls { get; private set; }
        public List<WindowType> Windows { get; private set; }

        internal House()
        {
            Walls = new List<WallMaterial>();
            Windows = new List<WindowType>();
        }

        public static HouseBuilder CreateBuilder()
        {
            return new HouseBuilder();
        }
    }
}