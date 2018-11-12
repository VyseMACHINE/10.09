using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            cars[0] = new Car(2012,200,1500, "Россия", "Lada");
            cars[1] = new Car(2015,260,2500, "Germany", "BMW");
            cars[2] = new Car(2014,240,1700, "Japan", "Subaru");
            cars[3] = new Car(2010,220,2000, "Germany", "BMW");
            cars[4] = new Car(2018,220,1500, "England", "Tesla");
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].CarInfo();
            }
            Console.Read();
        }
    }
}
