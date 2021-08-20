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
            carsList.Add(new Car_Model("Mercedes","Daimler","Sport"));
            carsList.Add(new Car_Model("BMW", "BMW AG", "Sport"));
            carsList.Add(new Car_Model("Audi", "VW", "Sport"));
            Console.WriteLine("Car List:" + '\n');
           
            for (int i = 0; i < carsList.Count; i++)
            {
                Console.WriteLine(carsList[i]);
            }
            
            Console.ReadKey();
        }
    }
}
