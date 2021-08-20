using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Wheel : Suspension
    {
        Boolean luftDrin = true;
        int durchmesser = 45;
        String farbe = "schwarz";

        public Boolean istAufgepumpt()
        {
            return luftDrin;
        }

        public void reifenWirdPlatt()
        {
            this.luftDrin = false;
        }

        public void reifenAufpumpen()
        {
            this.luftDrin = true;
        }
    }
}
