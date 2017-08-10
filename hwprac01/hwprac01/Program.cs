using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwprac01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            Console.WriteLine("enter time in secs");
            sec = Int32.Parse(Console.ReadLine());
            calsec(sec);
           
            Console.ReadLine();

        }
        public static void calsec(int sec)
        {
            int min, hr=0;
            min = sec / 60;
            sec = sec % 60;
            if (min > 60)
            {
                hr = min / 60;
                min = min % 60;
            }
            Console.WriteLine("");
            Console.WriteLine(" " + hr + " " +"hours " + min + " " + "mins" +  " "+ sec+" " + "secs");
            return;
        }
    }
}
