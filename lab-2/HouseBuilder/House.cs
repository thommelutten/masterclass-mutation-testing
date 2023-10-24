using HouseBuilder.Enums;

namespace HouseBuilder
{
    public class House
    {
        public List<WallMaterial> Walls { get; private set; }

        internal House()
        {
            Walls = new List<WallMaterial>();
        }

        public static HouseBuilder CreateBuilder()
        {
            return new HouseBuilder();
        }
    }
}