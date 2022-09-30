using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka3
{


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Введіть першу сторону:");
            rectangle.Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону:");
            rectangle.Side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр та Площа:");
            Console.WriteLine($"Периметр:{rectangle.Perimiter}");
            Console.WriteLine($"Площа:{rectangle.Area}");

        }
    }
}
