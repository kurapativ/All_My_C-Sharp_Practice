using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           File.WriteAllText(@"..\..\Result.csv", "");// Emptying the Results file if already data exists

            double average =0;
            string grade= "Grade";
            int count = 0;
            string line;

            StreamReader sr = new StreamReader(@"..\..\Score.csv");//Reading an .CSV file
            StreamWriter sw = new StreamWriter(@"..\..\Result.csv");//Writing into an .CSV file

            while ((line = sr.ReadLine()) != null)
            {
                
                 
                string[] columns = line.Split(',');
                Console.WriteLine(columns[0] + " " + columns[1] + " " + columns[2] + " " + columns[3] + " " + columns[4]);

                if (count > 0)
                {
                    //Calculating the averages for the tests 1, 2, 3 scores.
                    double t1 = Convert.ToDouble(columns[2]);
                    double t2 = Convert.ToDouble(columns[3]);
                    double t3 = Convert.ToDouble(columns[4]);

                    average=((t1 + t2 + t3) / 3);


                    //Assigning grades for the respective averages
                    if (average >= 90)
                    { grade = "A"; }
                    else if (average >= 80)
                    {
                        grade = "B";
                    }
                    else if (average >= 70)
                    {
                        grade = "C";
                    }
                    else if (average >= 60)
                    {
                        grade = "D";
                    }
                    else if (average <= 60)
                    {
                        grade = "F";
                    }
                    // writing the scores in Result.csv file
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", columns[0], columns[1], columns[2], columns[3], columns[4], average, grade);
                }
                else
                {
                    //writing the heading in Result.csv file
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", columns[0], columns[1], columns[2], columns[3], columns[4], "Average", grade);
                }

                count++;
            }
           
            sr.Close();
            sw.Close();
            Console.WriteLine();
            Console.WriteLine("Successfully created the grade report for above test scores");
            Console.ReadLine();
        }
    }
}
