/*Jeremy Martin
* ITSE 1430
* LAB 1
* Pizza Creator
*/

using System;

namespace PizzaCreator
{
    class Program
    {
        static void Main ( string[] args )
        {

            Console.WriteLine("Lab 1: Pizza Creator");
            var done = false;
            do
            {
                switch (DisplayMenu())
                {
                    case MenuOptions.Create: CreatePizza(); break;
                    case MenuOptions.Change: ChangePizza(); break;
                    case MenuOptions.Order: OrderPizza(); break;
                    case MenuOptions.Quit: done = ReadBoolean("Are you sure?"); break;
                }
            } while (!done);
        }
        static double price = 0;
        static string pizzaOrder = "";
        enum MenuOptions
        {
            Quit = 0,
            Create = 1,
            Change = 2,
            Order = 3
        }
        
        private static MenuOptions DisplayMenu ()
        {
            do
            {

                Console.WriteLine("1. Create a pizza");
                Console.WriteLine("2. Change your order");
                Console.WriteLine("3. Confirm your order");
                Console.WriteLine("Q to Quit");
                Console.WriteLine("\n\nOrder Total: " + price.ToString("C"));


                //TODO: readkey
                //var input = Console.ReadLine();
                var input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    {
                        Console.Clear();
                        return MenuOptions.Create;
                    }

                    case ConsoleKey.D2:
                    {
                        Console.Clear();
                        return MenuOptions.Change;
                    }
                    case ConsoleKey.D3:
                    {
                        Console.Clear();
                        return MenuOptions.Order;
                    }
                    case ConsoleKey.Q:
                    {
                        Console.Clear();
                        return MenuOptions.Quit;
                    }

                    default: Console.WriteLine("Invalid option"); break;
                };
            } while (true);
        }
        private static bool ReadBoolean ( string message )
        {
            Console.Write(message + " (Y/N)");
            do
            {
                

                var choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.Y: return true;
                    case ConsoleKey.N: return false;
                };
            } while (true);
        }

        public static string PizzaSize()
        {
            do {

                Console.WriteLine("Select a size");
                Console.WriteLine("1. Small    ($5.00)");
                Console.WriteLine("2. Medium   ($6.25)");
                Console.WriteLine("3. Large    ($8.75)");
                var input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    {
                        price += 5;
                        Console.Clear();
                        return "Small\n";
                    }
                    case ConsoleKey.D2:
                    {
                        price += 6.25;
                        Console.Clear();
                        return "Medium\n";
                    }
                    case ConsoleKey.D3:
                    {
                        price += 8.75;
                        Console.Clear();
                        return "Large\n";
                    }
                    default: Console.WriteLine("Invalid option"); break;
                }

            } while (true);
        }
        public static string PizzaMeats()
        {
            bool bacon = false;
            bool ham = false;
            bool pepperoni = false;
            bool sausage = false;
            int boolCounter = 0;
            do
            {
                Console.WriteLine("Select from the choices below for meats to add. Push Enter to Continue");
                Console.WriteLine("1. Bacon " + bacon);
                Console.WriteLine("2. Ham " + ham);
                Console.WriteLine("3. Pepperoni " + pepperoni);
                Console.WriteLine("4. Sausage " + sausage);
                Console.WriteLine("Enter: Confirm Selection");
                var choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    {
                        if (bacon == false)
                        {
                            bacon = true;
                            boolCounter++;
                            Console.Clear();
                        }
                        else if (bacon == true)
                        {
                            bacon = false;
                            boolCounter--;
                            Console.Clear();

                        }
                        break;
                    }
                    case ConsoleKey.D2:
                    {
                        if (ham == false)
                        {
                            ham = true;
                            boolCounter++;
                            Console.Clear();
                        }
                        else if (ham == true)
                        {
                            ham = false;
                            boolCounter--;
                            Console.Clear();
                        }
                        break;
                    }
                    case ConsoleKey.D3:
                    {
                        if (pepperoni == false)
                        {
                            pepperoni = true;
                            boolCounter++;
                            Console.Clear();
                        }
                        else if (pepperoni == true)
                        {
                            pepperoni = false;
                            boolCounter--;
                            Console.Clear();
                        }
                        break;
                    }
                    case ConsoleKey.D4:
                    {
                        if (sausage == false)
                        {
                            sausage = true;
                            boolCounter++;
                            Console.Clear();
                        }
                        else if (sausage == true)
                        {
                            sausage = false;
                            boolCounter--;
                            Console.Clear();
                        }
                        break;
                    }
                    case ConsoleKey.Enter:
                    {
                        price += boolCounter * 0.75;
                        string pizzaMeats = "Meats\n.".PadLeft(20, '-');
                        if (bacon == true)
                            pizzaMeats +="Bacon\n";
                        if (ham == true)
                            pizzaMeats +="Ham\n";
                        if (pepperoni == true)
                            pizzaMeats += "Pepperoni\n";
                        if (sausage == true)
                            pizzaMeats += "Sausage\n";
                        Console.Clear();
                        return pizzaMeats;
                    }
                }
            } while (true);
        }
        private static void CreatePizza ()
        {
            if (price == 0)
            {
                pizzaOrder = PizzaSize() + PizzaMeats();
                Console.WriteLine(pizzaOrder);
                return;
            }
            if (ReadBoolean("Order in progress, do you want to start over?") == true)
            {
                price = 0;
                pizzaOrder = "";
                Console.Clear();
                CreatePizza();
            }return;

        }
        private static void ChangePizza ()
        {
            //TODO:Edit Pizza
            Console.WriteLine("NYI, push enter to continue");
            Console.ReadLine();
            return;
        }
        static void OrderPizza ()
        {
            Console.WriteLine("NYI, push enter to continue");
            Console.ReadLine();
            return;
            //TODO:Confirm Pizza
        }
    }
}
