using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    internal class Planet : SpaceObject
    {
        public string PlanetType { get; set; }
        public int DiameterIM { get; set; }
        public int RPTimer { get; set; }
        public int RPDage { get; set; }

        public List<Moon> MoonList { get; set; }


        public virtual void Distance()
        {

        }
    }
}
