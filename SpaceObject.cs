using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class SpaceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        enum Startype
        {
            YellowDwarf,
            White,
            BlueNeutron,
            RedGiant
        }
    }
}
