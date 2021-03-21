using System;
using System.Linq;

namespace ConsoleArrayAverage
{
    class Program
    {
        static void IntroMessage()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Simple array average calc.");
            Console.WriteLine("Type \"help\" for the list of common commands.");
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

        static void AverageMethod(string inputAverageMethodArgument) //new created
        {
            long[] myArray; //Deaclare an array for something
            int t = 1;
            int i;
            myArray = new long[t]; //Initialize an array
            
            for (i = 0; i < t; i++)
            {
                myArray[i] = Convert.ToInt64(InputCheck(inputAverageMethodArgument));

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
                inputAverageMethodArgument = InputCheck(Convert.ToString(Console.ReadLine()));
            }
        }
        static string InputCheck(string inputCheckArgument)
        {
            if (inputCheckArgument == "quit")
            {
                Console.Clear();
                Console.WriteLine("Program stopped. Console cleared. Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (inputCheckArgument == "help")
            {
                Console.WriteLine("You can use the following commands:");                
                Console.WriteLine("\t- quit\tUse it to quit the program");
                Console.WriteLine("\t- reset\tUse it to clean the array");
                inputCheckArgument = InputCheck(Console.ReadLine());                
            }
            else if (inputCheckArgument == "reset")
            {
                Main();            
            }
            else
            {
                try
                {
                    Convert.ToInt64(inputCheckArgument);                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Program execution stopped due to error above. Enter int64 value to continue.");
                    inputCheckArgument =  InputCheck(Console.ReadLine()); 
                    //Environment.Exit(0);                    
                }                
            }
            return inputCheckArgument;
        }
        static void Main()
        {            
            IntroMessage();
            AverageMethod(Console.ReadLine());
        }
    }
}
