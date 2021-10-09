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
            var customer = new Customer();
            customer.name = "Mazen Alhomsi";
            customer.Introduce(customer.name);
            customer.GetHashCode();
            Console.WriteLine(customer.ID);


            carsList.Add(new Car("Daimler", "Mercedes", "Sport", 320));
            carsList.Add(new Car("BMW AG", "BMW", "Sport", 320));
            carsList.Add(new Car("Volkswagen AG", "Audi", "Sport", 320));
            carsList.Add(new Car() { manufacturer = "Daimler", color = "Red", maxSpeed = 240 });

            Console.WriteLine("Car List:" + '\n');

            for (int i = 0; i < carsList.Count; i++)
            {
                int number=0;
                number += number;
                Console.WriteLine(" {0} ------------------------------------------------- \n" +
                                  "Manufacturer: " + carsList[i].manufacturer + "\n" +
                                  "Marke: " + carsList[i].marke + "\n"+
                                  "Variant: " + carsList[i].variant + "\n"+
                                  "Max Speed: " + carsList[i].maxSpeed + "\n"+
                                  "Color: " + carsList[i].color + "\n",number);
            }

            Console.ReadKey();
        }
    }
}
