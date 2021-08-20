using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        public int registrationNum { get; private set; }
        public DateTime year { get; private set; }
        public string licenseNumber { get; private set; }


        public Car()
        {

        }
        public void MoveForward()
        {

        }

        public void MoveBackward()
        {

        }

        public void Stop()
        {

        }
        public void TurnRight()
        {

        }
        public void TurnLeft()
        {

        }

        public DateTime SetYear( DateTime year)
        {
            return this.year = year;
        }
    }
}
