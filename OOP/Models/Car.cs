using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car : Car_Model
    {
        public string manufacturer { get; set; } //Daimler AG
        public string marke { get; set; } //Mercedes
        public string variant { get; set; } //Sport
        public string color { get; set; }
        public int maxSpeed { get; set; }
        public int registrationNum { get; set; }
        public DateTime year { get; set; }
        public string licenseNumber { get; set; }
        public int horsePower { get; set; }
        public Engine engine { get; set; }


        public Car()
        {

        }
        public Car(string manufacturer, string marke, string variant, int maxSpeed)
        {
            this.manufacturer = manufacturer;
            this.marke = marke;
            this.variant = variant;
            this.maxSpeed = maxSpeed;
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

        public DateTime SetYear(DateTime year)
        {
            return this.year = year;
        }
    }
}
