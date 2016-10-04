using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    enum LightColour
    {
        Red=1, Amber=2, Green=3
    }

    class Light
    {
        protected LightColour colour;

        public LightColour Colour
        {
            get
            {
                return colour;
            }

            set
            {
                colour = value;
            }
        }

        public Light (LightColour colour)
        {
            this.colour = colour;
        }
    }

    class Lights : List<Light>
    {

    }
}
