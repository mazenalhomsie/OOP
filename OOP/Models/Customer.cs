using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Customer
    {
        Guid GudID = new Guid();
        public readonly List<Order> OrdersList = new List<Order>();
        public string ID
        {
            get => ID;
            set => GetHashCode();

        }
        public string name { get; set; }
        public string address { get; set; }
        public int mobile
        {
            get => mobile;
        }
        public void Introduce(string _name)
        {
            Console.WriteLine("Hi {0}, I am {1}", _name, name);
        }
       /* override int GetHashCode()
        {
            if (ID != null)
                return ID.GetHashCode();

            return DBNull.Value.GetHashCode();
        }*/
    }
}
