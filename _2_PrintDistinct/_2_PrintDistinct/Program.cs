using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PrintDistinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];//declaring array for 10 numbers

            Console.WriteLine("Enter 10  integer numbers with some numbers repeated.");


            //Saving numbers into num array
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Int32.Parse(Console.ReadLine());
            }


            //Printing Disticnt Numbers
            Console.WriteLine();
            Console.WriteLine("Disticnt numbers are: ");
            var dis_num = num.Distinct();
            foreach (int d in dis_num)
            {
                Console.Write(d + " ");
            }


            Console.ReadLine();

        }
    }
}
