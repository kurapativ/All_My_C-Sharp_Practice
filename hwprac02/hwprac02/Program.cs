using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwprac02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            Console.WriteLine("enter three numbers");
             for(int i=0;i<num.Length;i++)
            {
                num[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("unsorted array:");
            foreach (int p in num)
                Console.WriteLine(p);
            sortarray(num);
            Console.ReadLine();

        }
        public static void sortarray(int[] sortnum)
        {
            int temp;
            for (int i = 0; i < sortnum.Length; i++)
            {
                for (int j = i+1; j < sortnum.Length; j++)
                {
                    if (sortnum[i] > sortnum[j])
                    {
                        temp = sortnum[i];
                        sortnum[i] = sortnum[j];
                        sortnum[j] = temp;
                    }
                }
            }
            //Array.Sort(sortnum);
            Console.WriteLine("sorted array :");

            foreach (int k in sortnum)
                {
                Console.WriteLine(k);
            }
            return;
        }
    }
}
