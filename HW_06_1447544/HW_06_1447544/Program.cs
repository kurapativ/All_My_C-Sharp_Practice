using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06_1447544
{
    class Program
    {
        public static void MySort<T>(T[] arr) where T : IComparable<T>
        {

            // BUBBLE SORT ALGORITHM
            for (int x = 0; x < arr.Length; x++)//LOOP FOR MAKING ITERATIONS
            {
                for (int y = 0; y < arr.Length - 1; y++)//LOOP FOR COMPARING ELEMENTS
                {
                    //AS <,>.== CAN'T BE USED DIRECTLY FOF GENERIC DATATYPES WE USE IComparable and CompareTo();
                    if (arr[y].CompareTo(arr[y + 1])>0)
                    {
                        var temp = arr[y+1];
                        arr[y + 1] = arr[y];
                        arr[y] = temp;
                    }
                }//END OF LOOP FOR COMPARING ELEMENTS
            }//END OF LOOP FOR MAKING ITERATIONS


            //PRINTING SORTED ARRAY
            foreach (var i in arr)
                Console.Write(i+"\t");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            //DECLARING SORTED INT, DOUBLE, FLOAT, STRING ARRAYS..

            int[] arr_int = { 9, 1, 6, 13, 4 };
            double[] arr_double = { 0.4, 1.9, 1.2, 0.3, 1.4 };
            float[] arr_float = { 0.2F, 1.0F, 0.12F, 0.3F, 0.94F };
            string[] arr_string = { "apple", "stuart","banana", "mango","cat" };



            Console.WriteLine("SORTED INT ARRAY:");
            Console.WriteLine("........................................");

            MySort<int>(arr_int);

            Console.WriteLine();

            Console.WriteLine("SORTED DOUBLE ARRAY:");
            Console.WriteLine("........................................");
            MySort<double>(arr_double);
            Console.WriteLine();

            Console.WriteLine("SORTED FLOAT ARRAY:");
            Console.WriteLine("........................................");
            MySort<float>(arr_float);
            Console.WriteLine();


            Console.WriteLine("SORTED STRING ARRAY:");
            Console.WriteLine("........................................");
            MySort<string>(arr_string);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
