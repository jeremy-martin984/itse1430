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
                    case MenuOptions.View: ViewPizza(); break;
                    case MenuOptions.Change: ChangePizza(); break;
                    case MenuOptions.Quit: done = ReadBoolean("Are you sure?"); break;
                }
            } while (!done);
        }
        static double price = 0;
        static string pizzaOrder = "";
        static string pizzaSize;
        static string pizzaMeats;
        static string pizzaVeggies;
        static string extraCheese;
        static string pizzaSauce;
        static string delivery;
        static double sizePrice;
        static double meatsPrice;
        static double veggiesPrice;
        static double saucePrice;
        static double cheesePrice;
        static double deliveryFee;
        enum MenuOptions
        {
            Quit = 0,
            Create = 1,
            View = 2,
            Change = 3
        }
        
        private static MenuOptions DisplayMenu ()
        {
            do
            {

                Console.WriteLine("1. Create a pizza");
                Console.WriteLine("2. View your order");
                Console.WriteLine("3. Change your pizza");
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
                        return MenuOptions.View;
                    }
                    case ConsoleKey.D3:
                    {
                        Console.Clear();
                        return MenuOptions.Change;
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
                        sizePrice = 5;
                        Console.Clear();
                        return "Small\n";
                    }
                    case ConsoleKey.D2:
                    {
                        price += 6.25;
                        sizePrice = 6.25;
                        Console.Clear();
                        return "Medium\n";
                    }
                    case ConsoleKey.D3:
                    {
                        price += 8.75;
                        sizePrice = 8.75;
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
                        string pizzaMeats = "Meats\n".PadRight(20, '-') + "\n";
                        if (bacon == true)
                            pizzaMeats +="Bacon\n";
                        if (ham == true)
                            pizzaMeats +="Ham\n";
                        if (pepperoni == true)
                            pizzaMeats += "Pepperoni\n";
                        if (sausage == true)
                            pizzaMeats += "Sausage\n";
                        Console.Clear();
                        meatsPrice = boolCounter * 0.75;
                        return pizzaMeats;
                    }
                }
            } while (true);
        }
        public static string PizzaVeggies ()
        {
            bool blackOlives = false;
            bool mushrooms = false;
            bool onions = false;
            bool peppers = false;
            int boolCounter = 0;
            do
            {
                Console.WriteLine("Select from the choices below for veggies to add. Push Enter to Continue");
                Console.WriteLine("1. Black olives " + blackOlives);
                Console.WriteLine("2. mushrooms " + mushrooms);
                Console.WriteLine("3. onions " + onions);
                Console.WriteLine("4. peppers " + peppers);
                Console.WriteLine("Enter: Confirm Selection");
                var choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    {
                        if (blackOlives == false)
                        {
                            blackOlives = true;
                            boolCounter++;
                            Console.Clear();
                        } else if (blackOlives == true)
                        {
                            blackOlives = false;
                            boolCounter--;
                            Console.Clear();

                        }
                        break;
                    }
                    case ConsoleKey.D2:
                    {
                        if (mushrooms == false)
                        {
                            mushrooms = true;
                            boolCounter++;
                            Console.Clear();
                        } else if (mushrooms == true)
                        {
                            mushrooms = false;
                            boolCounter--;
                            Console.Clear();
                        }
                        break;
                    }
                    case ConsoleKey.D3:
                    {
                        if (onions == false)
                        {
                            onions = true;
                            boolCounter++;
                            Console.Clear();
                        } else if (onions == true)
                        {
                            onions = false;
                            boolCounter--;
                            Console.Clear();
                        }
                        break;
                    }
                    case ConsoleKey.D4:
                    {
                        if (peppers == false)
                        {
                            peppers = true;
                            boolCounter++;
                            Console.Clear();
                        } else if (peppers == true)
                        {
                            peppers = false;
                            boolCounter--;
                            Console.Clear();
                        }
                        break;
                    }
                    case ConsoleKey.Enter:
                    {
                        price += boolCounter * 0.50;
                        veggiesPrice = boolCounter * 0.50;
                        string pizzaVeggies = "\nVeggies\n".PadRight(20, '-') + "\n";
                        if (blackOlives == true)
                            pizzaVeggies +="Black Olives\n";
                        if (mushrooms == true)
                            pizzaVeggies +="Mushrooms\n";
                        if (onions == true)
                            pizzaVeggies += "Onions\n";
                        if (peppers == true)
                            pizzaVeggies += "peppers\n";
                        Console.Clear();
                        return pizzaVeggies;
                    }
                }
            } while (true);
        }
        public static string PizzaSauce ()
        {
            string sauce = "\nSauce:\n".PadRight(20, '-') + "\n";
            do
            {
                Console.WriteLine("Select from the choices below for your sauce");
                Console.WriteLine("1. Traditional ($0)");
                Console.WriteLine("2. Garlic ($1.00)");
                Console.WriteLine("3. Oregano ($1.00)");

                var choice = Console.ReadKey(true);

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    {
                        sauce += "Traditional";
                        Console.Clear();
                        saucePrice = 0;
                        return sauce;
                    }
                    case ConsoleKey.D2:
                    {
                        sauce += "Garlic";
                        saucePrice = 1;
                        price += 1;
                        Console.Clear();
                        return sauce;
                    }
                    case ConsoleKey.D3:
                    {
                        sauce += "Oregano";
                        saucePrice = 1;
                        price += 1;
                        Console.Clear();
                        return sauce;
                    }
                    default: Console.WriteLine("Invalid selection!");break;
                }
            } while (true);
        }
        private static string ExtraCheese ()
        {
            if (ReadBoolean("Would you like extra cheese?") == true)
            {
                price += 1.25;
                cheesePrice = 1.25;
                Console.Clear();
                return "\nExtra Cheese\n";
            } else
            {
                Console.Clear();
                cheesePrice = 0;
                return "\nRegular Cheese\n";
            }
        }
        private static string Delivery ()
        {
            if (ReadBoolean("Would you like your order delivered?") == true)
            {
                price += 2.50;
                deliveryFee=2.50;
                Console.Clear();
                return "\nFor Delivery\nRemember, delivery fee is not a tip.";
            } else
            {
                deliveryFee = 0;
                Console.Clear();
                return "\nFor Pickup\n";
            }
        }

        private static void CreatePizza ()
        {
            if (price == 0)
            {
                pizzaSize = PizzaSize();
                pizzaMeats = PizzaMeats();
                pizzaVeggies = PizzaVeggies();
                pizzaSauce = PizzaSauce();
                extraCheese = ExtraCheese();
                delivery = Delivery();

                pizzaOrder = pizzaSize + pizzaMeats + pizzaVeggies + pizzaSauce + extraCheese + delivery + "\n\nPrice Total: " + price.ToString("C");


                //pizzaOrder = PizzaSize() + PizzaMeats() + PizzaVeggies() + PizzaSauce() + ExtraCheese() + Delivery() + "\n\n Price Total: " + price.ToString("C");
                Console.WriteLine(pizzaOrder + "\n\n");
                Console.WriteLine("Push Any key to continue.");
                Console.ReadKey();
                Console.Clear();
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
        public static void UpdateOrderTotal()
        {
            pizzaOrder = pizzaSize + pizzaMeats + pizzaVeggies + pizzaSauce + extraCheese + delivery + "\n\nPrice Total: " + price.ToString("C");
            return;
        }
        private static void ViewPizza ()
        {

            if(price == 0)
            {
                Console.WriteLine("No order created yet");
                return;
            }
            Console.WriteLine(pizzaOrder);
            Console.WriteLine("Push any key to continue");
            Console.ReadKey();
            return;
        }
        static void ChangePizza ()
        {
            if(price == 0)
            {
                Console.WriteLine("No order yet!");
                return;
            }
            do
            {
                Console.Clear();
                Console.WriteLine("Here is your current order:");
                Console.WriteLine(pizzaOrder);
                Console.WriteLine("Please choose which option you would like to change:");
                Console.WriteLine("1. Size");
                Console.WriteLine("2. Meats");
                Console.WriteLine("3. Veggies");
                Console.WriteLine("4. Sauce");
                Console.WriteLine("5. Cheese");
                Console.WriteLine("6. Delivery options");
                Console.WriteLine("Press Enter to return to the previous Menu.");
                var choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    {
                        Console.Clear();
                        Console.WriteLine("Current Option:");
                        Console.WriteLine(pizzaSize);
                        price -=sizePrice;
                        pizzaSize = PizzaSize();
                        UpdateOrderTotal();
                        break;
                    }
                    case ConsoleKey.D2:
                    {
                        Console.Clear();
                        Console.WriteLine("Current Options:");
                        Console.WriteLine(pizzaMeats);
                        price -=meatsPrice;
                        pizzaMeats = PizzaMeats();
                        UpdateOrderTotal();
                        break;
                    }
                    case ConsoleKey.D3:
                    {
                        Console.Clear();
                        Console.WriteLine("Current Options:");
                        Console.WriteLine(pizzaVeggies);
                        price -=veggiesPrice;
                        pizzaVeggies = PizzaVeggies();
                        UpdateOrderTotal();
                        break;
                    }
                    case ConsoleKey.D4:
                    {
                        Console.Clear();
                        Console.WriteLine("Current Options:");
                        Console.WriteLine(pizzaSauce);
                        price -=saucePrice;
                        pizzaSauce = PizzaSauce();
                        UpdateOrderTotal();
                        break;
                    }
                    case ConsoleKey.D5:
                    {
                        Console.Clear();
                        Console.WriteLine("Current Options:");
                        Console.WriteLine(extraCheese);
                        price -= cheesePrice;
                        extraCheese = ExtraCheese();
                        UpdateOrderTotal();
                        break;
                    }
                    case ConsoleKey.D6:
                    {
                        Console.Clear();
                        Console.WriteLine("Current Options:");
                        Console.WriteLine(delivery);
                        price -= deliveryFee;
                        delivery = Delivery();
                        UpdateOrderTotal();
                        break;
                    }
                    case ConsoleKey.Enter:
                    {
                        Console.Clear();
                        return;
                    }
                    default: Console.WriteLine("Invalid Selection"); break;
                }
            } while (true);

        }
    }
}
