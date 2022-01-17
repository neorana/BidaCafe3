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
            initialSelection = Convert.ToInt32(Console.ReadLine());

            switch (initialSelection)
            {
                case 1:
                    Console.WriteLine("Do add item logic");
                    
                    //list available items or orders first before pass to additem logic
                    //AddItem(string order);
                    break;

                case 2:
                    Console.WriteLine("Do add item logic");
                    break;
                case 3:
                    Console.WriteLine("Do add item logic");
                    break;
                case 4:
                    Console.WriteLine("Do add item logic");
                    break;
                case 5:
                    Console.WriteLine("Do add item logic");
                    break;

                case 6:
                    Console.WriteLine("Do add item logic");
                    break;
                case 7:
                    Console.WriteLine("Do add item logic");
                    break;

                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.ReadKey();

        }

        private static void AddItem(string v, object order)
        {
            throw new NotImplementedException();
        }
    }
}
