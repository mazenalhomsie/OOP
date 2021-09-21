using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    class Program
    {

        static void Main(string[] args)
        {
            // Create a list of car.
            List<Car> carsList = new List<Car>();
           
            carsList.Add(new Car("Daimler", "Mercedes", "Sport", 320));
            carsList.Add(new Car("BMW AG", "BMW", "Sport", 320));
            carsList.Add(new Car("Volkswagen AG", "Audi", "Sport", 320));
            carsList.Add(new Car() { manufacturer = "Daimler", color = "Red", maxSpeed =240});
           

            Console.WriteLine("Car List:" + '\n');

            for (int i = 0; i < carsList.Count; i++)
            {
                Console.WriteLine(carsList[i].manufacturer + " " + carsList[i].marke + " " + carsList[i].variant+" "+ carsList[i].maxSpeed+" "+carsList[i].color );
            }

            Console.ReadKey();
        }
    }
}
