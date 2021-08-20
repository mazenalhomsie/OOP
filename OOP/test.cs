using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class test
    {
        static Wheel Wheel1 = new Wheel();
        static Wheel Wheel2 = new Wheel();
        static Wheel Wheel3 = new Wheel();
        static Wheel Wheel4 = new Wheel();

        public void fahre()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            if (randomNumber < 5)
            {
                Wheel1.reifenWirdPlatt();
            }
        }
        public Boolean autoFahrbereit()
        {
            Boolean fahrbereit = true;
            if (!Wheel1.istAufgepumpt())
            {
                fahrbereit = false;
            }

            if (!Wheel2.istAufgepumpt())
            {
                fahrbereit = false;
            }

            if (!Wheel3.istAufgepumpt())
            {
                fahrbereit = false;
            }

            if (!Wheel4.istAufgepumpt())
            {
                fahrbereit = false;
            }


            return fahrbereit;
        }


        public static Boolean istFahrbereit()
        {
            Boolean fahrbereit = true;
            if (!Wheel1.istAufgepumpt())
            {
                fahrbereit = false;
            }

            if (!Wheel2.istAufgepumpt())
            {
                fahrbereit = false;
            }

            if (!Wheel3.istAufgepumpt())
            {
                fahrbereit = false;
            }

            if (!Wheel4.istAufgepumpt())
            {
                fahrbereit = false;
            }

            return fahrbereit;
        }
        public static void autoFaehrt()
        {
            Console.WriteLine("Ich fahre!");
        }

    }
}
/*
if (mercedes.autoFahrbereit() == true)
{
    autoFaehrt();
}
else
{
    Console.WriteLine("Sorry, Reifen platt!");
}*/
