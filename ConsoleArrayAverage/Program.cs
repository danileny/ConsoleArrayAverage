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

        static void AverageMethod(string enteredVar)
        {
            Int64[] myArray; //Deaclare an array
            int t = 1;
            int i;
            myArray = new Int64[t]; //Initialize an array
            
            for (i = 0; i < t; i++)
            {
                myArray[i] = Convert.ToInt64(enteredVar);

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
                Console.WriteLine("Program stopped. Console cleared. Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (metArg == "help")
            {
                Console.WriteLine("You can use the following commands:");                
                Console.WriteLine("\t- quit \tUse it to quit the program");
            //    Console.WriteLine("\t- reset \tUse it to ckean the array");
                Console.ReadLine();                
            }
            //else if (metArg == "clear")
            //{
            //    myArray[0] = new Int64[0];
            //}
            else
            {
                try
                {
                    Convert.ToInt64(metArg);                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Program execution stopped due to error above. Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);                    
                }
                
            }
            return metArg;
        }
        static void Main()
        {            
            IntroMessage();
            string enteredVar = Console.ReadLine();
            InputCheck(enteredVar);
            AverageMethod(enteredVar);
        }
    }
}
