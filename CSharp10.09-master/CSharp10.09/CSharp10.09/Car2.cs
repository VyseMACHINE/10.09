using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10._09
{
    partial class Car
    {
        partial void Write()
        {
            Console.WriteLine("Год: " + IssueDate);
            Console.WriteLine("Максимальная скорость: " + maxSpeed);
            Console.WriteLine("Вес: " + weight);
            Console.WriteLine("Страна производства: " + IssueCountry);
            Console.WriteLine("Название: " + Name);
        }
        public void CarInfo()
        {
            Write();
        }
    }
}
