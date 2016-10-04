using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Sequence : List<Stage>
    {
        public Sequence()
        {
            Stage redAmber = new Stage(LightColour.Red, 1);
            redAmber.Lights.Add(new Light(LightColour.Amber));

            this.Add(new Stage(LightColour.Red, 4));
            this.Add(redAmber);
            this.Add(new Stage(LightColour.Green, 4));
            this.Add(new Stage(LightColour.Amber, 2));
        }
    }
}
