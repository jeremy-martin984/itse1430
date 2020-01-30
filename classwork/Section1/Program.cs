/*
 * ITSE 1430
 * Your Name
 */
using System;

namespace Section1
{
    class Program
    {
        static void Main ( string[] args )
        {
            //
            //PlayingWithVariables();                          
            AddMovie();
        }
        static void AddMovie ()
        {
            string title = ReadString("Enter a title: ", true);

            int releaseYear = ReadInt32("Enter the release year (>= 0): ", 0, 2100);
            int runLength = ReadInt32("Enter the run length (>= 0): ", 0, 86400);

            string description = ReadString("Enter a description: ", false);
            bool isClassic = ReadBoolean("Is this a classic movie?");
        }

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message + " (Y/N)");
            do
            {
                //Check for empty string
                //if value != String.Empty another option
                // if(value.Length == 0)
                // if(!String.IsNullOrEmpty(value)) preferred
               string value = Console.ReadLine();
               // string value = Console.ReadKey(true);

                //if (value !="")
                if (!String.IsNullOrEmpty(value))
                    {
                    //TODO: Do this correctly?
                    if (String.Compare(value, "Y", true) == 0)
                        return true;
                    else if (String.Compare(value, "N", true) == 0)
                        return false;
                    

                    char firstChar = value[0];

                    //value = value.ToLower();
                    //if (value == "y")
                    //    return true;
                    //else if (value == "n")
                    //    return false;
                    //switch (firstChar)
                    //{
                    //  //  case 'A': Console.WriteLine("A"); break;
                    //  //  case 'a': Console.WriteLine("a"); break;
                    //    case 'Y': return true;
                    //    case 'y': return true;
                    //    case 'n': return false;
                    //    case 'N': return false;

                    //};
                    //if (firstChar == 'Y' || firstChar == 'y')
                    //    return true;
                    //else if (firstChar == 'N' || firstChar == 'n')
                    //    return false;
                };
                Console.WriteLine("Enter Y/N");
            } while (true);

        }

        private static string ReadString ( string message, bool required )
        {
            Console.Write(message);
            do
            {
                string value = Console.ReadLine();

                if (!String.IsNullOrEmpty(value) || !required)
                    return value;

                if (required)
                    Console.WriteLine("Value is required");

                return value;
            } while (true);
        }

        private static int ReadInt32 ( string message, int minValue, int maxValue )
        {
            do
            {
                Console.Write(message);

                string temp = Console.ReadLine();
                //int value = Int32.Parse(temp);

                //TODO: Clean this up
                //int value;
                if (Int32.TryParse(temp, out var value))
                {
                    if (value >= minValue && value <= maxValue)
                        return value;
                };

                Console.WriteLine("Value must be between minValue and maxValue");
            } while (true);

        }
    }
}
