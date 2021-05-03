using System;
using System.Linq;

namespace ConsoleArrayAverage
{
    class Program
    {

        static void Main()
        {            
            InfoMessage();
            AverageMethod(Console.ReadLine());
        }
        static void InfoMessage()
        {
            Console.WriteLine("---------------------------------------------------------------------"
                          + "\n----------------------Simple array average calc----------------------"
                          + "\n---------------------------------------------------------------------"
                          + "\nEnter int64 value for myArray[]");
                    }
        static void HelpMessage()
        {
            Console.WriteLine("\nYou can use the following commands:"
                          + "\n\t- \"help\"\tList all availiable commands"
                          + "\n\t- \"reset\"\tClean the array"
                          + "\n\t- \"quit\"\tQuit program\n"
                          + "\n---------------------------------------------------------------------"
                          + "\nEnter int64 value for myArray[]");
        }

        static void Resize<T>(ref T[] array, int newSize) //Resize array. <T> makes generic method ('T' - type).
        {
            T[] newArray = new T[newSize];
            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];
            array = newArray;
        }
        static void AverageMethod(string st) //new created
        {
            long[] myArray; //Deaclare an array for something
            int t = 1;
            int i;
            myArray = new long[t]; //Initialize an array

            for (i = 0; i < t; i++)
            {
                myArray[i] = Convert.ToInt64(InputCheck(st));

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
                st = InputCheck(Convert.ToString(Console.ReadLine()));
            }
        }
        static string InputCheck(string st)
        {
            if (st.ToLower() == "quit")
            {
                Console.Clear();
                Console.WriteLine("Program stopped. Console cleared. Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (st.ToLower() == "help")
            {
                HelpMessage();
                st = InputCheck(Console.ReadLine());
            }
            else if (st == "reset")
            {
                Console.Clear();
                Console.WriteLine("Array cleaned");
                System.Threading.Thread.Sleep(800);
                Console.Clear();                
                Main();
            }
            else
            {
                try
                {
                    Convert.ToInt64(st);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Program execution stopped due to error above. Enter int64 value to continue.");
                    st = InputCheck(Console.ReadLine());
                    //Environment.Exit(0);                    
                }
            }
            return st;
        }
    }
}
