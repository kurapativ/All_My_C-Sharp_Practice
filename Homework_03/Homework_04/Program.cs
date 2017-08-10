using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
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

            Rectangle r2 = new Rectangle(4.0,5.0,"Orange");
            Console.WriteLine(r2.GetRectangle());
            Console.WriteLine(r2.Area());
            Console.WriteLine(r2.Perimeter());

            Console.WriteLine();

            try
            {
                Rectangle r1 = new Rectangle(1.0,2.1);
                r1._Length = 3.2;
                r1._Width = -10.0;
                Console.WriteLine(r1.GetRectangle());
                Console.WriteLine(r1.Area());
                Console.WriteLine(r1.Perimeter());
            }
            catch(CustomException e)
            {
                Console.WriteLine(e.message);
            }

            try
            {
                Rectangle r3 = new Rectangle();
                r3._Length = -3.2;
                r3._Width = 10.0;
                Console.WriteLine(r3.GetRectangle());
                Console.WriteLine(r3.Area());
                Console.WriteLine(r3.Perimeter());
            }
            catch (CustomException e)
            {
                Console.WriteLine(e.message);
            }


            Console.ReadLine();

        }
    }
}
