using System;

namespace BidaCafe3
{
    class Program
    {
        static void Main(string[] args)
        {

            //main page
            string[] mainpage = new string[] { "1. AddItem", "2. RemoveItem",
                                   "3. Add Tip", "4. Display Bill",
                                "5. Clear All", "6. Save to File",
                                "7. Load From File", "0. Exit"};
            Console.WriteLine(String.Join("\n", mainpage));

            Console.WriteLine("Please enter your choice");

            int initialSelection;

            //1st criteria selection of user
            initialSelection = Convert.ToInt32(Console.ReadLine());
            CallSwitch(initialSelection);

            //2nd criteria selection of user
            initialSelection = Convert.ToInt32(Console.ReadLine());
            CallSwitch(initialSelection);

            //3rd criteria selection of user
            initialSelection = Convert.ToInt32(Console.ReadLine());
            CallSwitch(initialSelection);

            Console.ReadKey();

        }

        private static void AddItem(string v, object order)
        {
            throw new NotImplementedException();
        }

        private static void CallSwitch(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("You are trying to add an item");
                    break;

                case 2:
                    Console.WriteLine("You are trying to do numbe 2");
                    break;
                case 3:
                    Console.WriteLine("You are trying to do numbe 3");
                    break;
                case 4:
                    Console.WriteLine("You are trying to do numbe 4");
                    break;
                case 5:
                    Console.WriteLine("You are trying to do numbe 5");
                    break;

                case 6:
                    Console.WriteLine("You are trying to do numbe 6");
                    break;
                case 7:
                    Console.WriteLine("You are trying to do numbe 7");
                    break;

                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nPlease enter your next choice");



        }
    }
}
