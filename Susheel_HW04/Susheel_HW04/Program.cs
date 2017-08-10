using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susheel_HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine(r.GetRectangle());
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimeter());

            Console.WriteLine();

            Rectangle r2 = new Rectangle(5.0, 7.0, "GREEN");
            Console.WriteLine(r2.GetRectangle());
            Console.WriteLine(r2.Area());
            Console.WriteLine(r2.Perimeter());

           
            Console.ReadLine();


        }
    }
}
