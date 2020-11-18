using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{

    //private varaiable of the class
    class Mobile
    {

        //Read only property
        public string MobileName { get; private set; }
        public string Modelno { get; set; }
        public int Cost { get; set; }

        public Mobile(string MobileName)
        {
            this.MobileName = MobileName;
        }
    }
    class PropertyEg
    {
    }
}
