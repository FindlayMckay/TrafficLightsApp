using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Stage
    {
        protected Lights lights;
        protected int time;

        public Lights Lights
        {
            get
            {
                return lights;
            }
        }

        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public Stage()
        {
            lights = new Lights();
        }

        public Stage (LightColour colour, int time) : this()
        {
            this.lights.Add(new Light(colour));
            this.time = time;
        }
    }
}
