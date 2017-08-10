using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Temperatures.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] temp = new double[5];
            double sum=0, avg, sqr_diff=0, variance, std_dev;
            
            //Reading Temperatures into the arrray
            for(int i=0; i<temp.Length;i++)
            {
              temp[i]= Convert.ToDouble( Console.ReadLine());
            }

            //Printing Temperatures 
            foreach (var t in temp)
                {
                Console.Write(t+ "°F.  ");
                }

            //Calculating Average
            foreach (var t in temp)
            {
                sum = t + sum;
            }
            Console.WriteLine();
            
            avg = sum / temp.Length;

            Console.WriteLine("Average of temperatures " + avg + "°F.  ");
           
            //Calculating Variance

            foreach (var t in temp)//sum of difference squares
            {
                sqr_diff = (avg - t)* (avg - t) + sqr_diff;
            }

            variance = sqr_diff / temp.Length;

            Console.WriteLine("Variance of temperatures " + variance + "°F.  ");

            //Calculating Standard Deviation

            std_dev = Math.Sqrt(variance);

            Console.WriteLine("Standard Deviation of temperatures " + std_dev + "°F.  ");
            Console.ReadLine();
        }
    }
}
