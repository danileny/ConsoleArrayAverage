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
        
        static void Main(string[] args)
        {
            Int64[] myArray; //Deaclare an array
            int t = 1;
            
            myArray = new Int64[t]; //Initialize an array

            for (int i = 0; i < t; i++ )
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
    }
}
