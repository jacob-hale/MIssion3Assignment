using MIssion3Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string[]> foodItems = new List<string[]>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1: Add Food Items");
            Console.WriteLine("2: Delete Food Items");
            Console.WriteLine("3: Print List of Current Food Items");
            Console.WriteLine("4: Exit the Program");
            Console.WriteLine("=====================================");
            Console.Write("Enter the number of the function you want to do: ");
            string choice = Console.ReadLine();
            Console.WriteLine("=====================================");
            switch (choice)
            {
                case "1":
                    // Add Food Logic
                    Console.Write("Enter the name of the food item: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the category of " + name + ": ");
                    string category = Console.ReadLine();
                    Console.Write("Enter the quantity of " + name + ": ");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Write("Enter the expiration date of " + name + ": ");
                    string expirationDate = Console.ReadLine();

                    FoodItem item = new FoodItem(name, category, quantity, expirationDate);
                    foodItems = item.AddFoodItem(foodItems);
                    Console.WriteLine(name + " has been added to the list.");

                    break;
                case "2":
                    // Delete Food Logic
                    break;
                case "3":
                    // Print list of current food items
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Exiting the program now. Have a great day!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        

    }

    //public Array PrintList()
    //{
    //    // code to print list of food items
    //    return foodItems;

    //}
}