using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class Star : SpaceObject
    {
        public string StartType { get; set; }
        public double Temperature { get; set; }
        public List<Planet> PlanetList { get; set; }

        enum PlanetType
        {
            Terrestial,
            Giant,
            Dwarf,
            Gas_Giant
        }
    }
}
