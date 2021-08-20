using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car_Model : Car
    {
        public string title { get; private set; }
        public string marke { get; private set; }
        public string Variant { get; private set; }
        public Car_Model()
        {
                
        }

        public Car_Model(string title, string marke, string variant)
        {
            this.title = title;
            this.marke = marke;
            this.Variant = variant;
            Car car = new Car();
            car.SetYear(DateTime.Now);
        }
        public void SetTitle( string _title)
        {
            title = _title;
        }
    }
}
