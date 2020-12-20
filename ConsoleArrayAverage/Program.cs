using System;
using System.Linq;

namespace ConsoleArrayAverage
{
    class Program
    {
        static void Resize<T>(ref T[] array, int newSize) //Resize array. <T> makes generic method ('T' - type).
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];
            array = newArray;
        }

        static void AverageMethod ()
        {
            Int64[] myArray; //Deaclare an array
            int t = 1;

            myArray = new Int64[t]; //Initialize an array

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Enter int64 value for the my Array: ");
                myArray[i] = Convert.ToInt64(Console.ReadLine()); //Assigning value to an array element 

                Console.WriteLine("Array length = " + myArray.Length);
                Console.WriteLine("Array average = " + myArray.Average());
                t++;
                foreach (int k in myArray)
                {
                    Console.Write($"{k}\a\t");
                }
                Console.Write("\n");
                Resize(ref myArray, t); //Change array length
            }
        }

        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("Enter int64 value for myArray[] OR Enter x to stop.");
            
            string varToEnter = Console.ReadLine();

            if (varToEnter == "x" || varToEnter == "X")
            {
                Console.Clear();
                Console.Write("Console cleared");               
            }
            else
            {
                try
                {
                    Convert.ToInt64(varToEnter); //Assigning value to an array element                                                                                               
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            /*
                finally
            {
                if varForArray == "x";
            }
            */
            






            //AverageMethod();
        }
    }
}
