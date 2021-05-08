using System;
using System.Linq;

namespace ConsoleArrayAverage
{
    class Program
    {

        static void Main()
        {            
            InfoMessage();
            AverageMethod(InputCheck(Console.ReadLine()));
        }
        static void InfoMessage() 
        {
            string appVersion = "1.0.0";
            string appAuthor = "Geeno";
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------------------------------------------------" +
                            "\n----------------------Simple array average calc----------------------" +
                            "\n---------------------------------------------------------------------" +
                            "\nVersion: {0}\nAuthor: {1}\n", appVersion, appAuthor);
            
            Console.ResetColor();
            PrintColorMessage(ConsoleColor.Cyan, "\nEnter actual number for myArray:");
        }
        
        static void HelpMessage() {
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
                myArray[i] = Convert.ToInt64(st);

                Console.WriteLine("Array length = {0} \nArray average = {1}", myArray.Length, + myArray.Average()); 
                
                foreach (int k in myArray)
                {
                    Console.Write($"" +
                        $"{k}\a\t");
                }
                Console.Write("\n");

                t++;
                Resize(ref myArray, t); //Change array length
                
                PrintColorMessage(ConsoleColor.Cyan, "Enter another actual number for myArray: ");
                st = InputCheck(Convert.ToString(Console.ReadLine()));
            }
        }
        static string InputCheck(string st)
        {
            while (!int.TryParse(st, out int sta))
            {

                if (st.ToLower() == "help")
                {
                    HelpMessage();
                    st = InputCheck(Console.ReadLine());
                }

                else if (st.ToLower() == "reset")
                {
                    Console.Clear();
                    Console.WriteLine("Array cleaned");
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                    Main();
                }

                else if (st.ToLower() == "quit")
                {
                    Console.Clear();
                    Console.WriteLine("Program stopped. Console cleared. Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                else
                {
                    PrintColorMessage(ConsoleColor.Red, "You have the error input. Use actual number");
                    st = InputCheck(Console.ReadLine());
                }                
            }
            return st;

        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
