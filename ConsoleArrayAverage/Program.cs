using System;
using System.Linq;

namespace ConsoleArrayAverage
{
    class Program
    {
        static void IntroMessage()
        {
            Console.Beep();
            Console.WriteLine("Enter int64 value for myArray[] OR Enter \"quit\" to stop.");
            Console.WriteLine("-----------------------------------------------------------");
            
    }

        static void Resize<T>(ref T[] array, int newSize) //Resize array. <T> makes generic method ('T' - type).
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];
            array = newArray;
        }

        static void AverageMethod(string enteredVar)
        {
            Int64[] myArray; //Deaclare an array
            int t = 1;
            int i = 0;
            myArray = new Int64[t]; //Initialize an array
            
            for (i = 0; i < t; i++)
            {
                myArray[i] = Convert.ToInt64(enteredVar); // обработай exception!!!

                Console.WriteLine("Array length = " + myArray.Length);
                Console.WriteLine("Array average = " + myArray.Average());             
                
                foreach (int k in myArray)
                {
                    Console.Write($"{k}\a\t");
                }
                Console.Write("\n");
                
                t++;
                Resize(ref myArray, t); //Change array length
                Console.WriteLine("Enter another int64 value for myArray: ");
                enteredVar = InputCheck(Convert.ToString(Console.ReadLine()));
            }
        }

        static string InputCheck(string metArg)
        {            
            if (metArg == "quit")
            {
                Console.Clear();
                Console.WriteLine("Program executed. Console cleared.");
                Environment.Exit(0);
            }
            else
            {
                try
                {
                    Convert.ToInt64(metArg);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);                                        
                }
            }
            return metArg;
        }
        static void Main(string[] args)
        {            
            IntroMessage();
            string enteredVar = Console.ReadLine();
            InputCheck(enteredVar);
            AverageMethod(enteredVar);
            

            
        }
    }
}
