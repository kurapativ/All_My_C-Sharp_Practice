using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430_TakeHome_KurapatiVidya_1447544
{
    class Program
    {
        static void Main(string[] args)
        {
            int SearchCnt = 0;
            int CharCnt = 0;
            string Line;
            String FindWord = null;
           
            ArrayList AllWords = new ArrayList();

            StreamReader sr1 = new StreamReader(@"..\..\Test.txt");
            String[] WordsCnt = sr1.ReadToEnd().Split();



      
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------Text from Test File----------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            Console.WriteLine();


            //Printing the text from Test.txt file
            StreamReader sr2 = new StreamReader(@"..\..\Test.txt");


            while ((Line = sr2.ReadLine()) != null)
                {
                    Console.WriteLine(Line);

                }
                Console.WriteLine();


            //Calculating Character Count
                for (int i = 0; i < WordsCnt.Length; i++)
                {
                    AllWords.Add(WordsCnt[i]);

                    CharCnt = CharCnt + WordsCnt[i].Length;

                }

           
            Console.WriteLine("-------------------------End Print Text from Test File------------------------------");
            Console.WriteLine();

            //Printing No. of words
            Console.WriteLine("Total Number of words are:" + WordsCnt.Length);
            Console.WriteLine();

            //Printing No. of Characters
            Console.WriteLine("Total Number of characters are:" + CharCnt);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine();

            //Getting user input for search keyword
            Console.WriteLine("Please Enter The Search KeyWord");
            Console.WriteLine();
            Console.Write("KeyWord:");

            FindWord = Console.ReadLine();

                FindWord = FindWord.ToLower();
            Console.WriteLine("--------------------------------------------------------------------------------------");


            //Searching the keyword in the given text file
            foreach (String x in AllWords)
            {
                string Result = new String(x.Where
                                    (ch => !Char.IsPunctuation(ch)).ToArray());
                Result = Result.ToLower();
                if (Result.Equals(FindWord))
                {
                    SearchCnt = SearchCnt + 1;
                }
            }
            
            //Printing the count of the keyword appearance
            Console.WriteLine("The word '"+ FindWord + "' was found " + SearchCnt + " times");
            Console.WriteLine("------------------------------------------------------------------------------------");


            Console.ReadLine();



            



        }
    }
}
