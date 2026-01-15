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
                    // *** Add basic error handling ***
                    Console.Write("Enter the name of the food item: ");
                    string name = Console.ReadLine();
                    // make sure name is not empty or already in the list

                    Console.Write("Enter the category of " + name + ": ");
                    string category = Console.ReadLine();
                    // make sure category is not empty

                    Console.Write("Enter the quantity of " + name + ": ");
                    int quantity = int.Parse(Console.ReadLine());
                    // make sure quantity is a positive integer

                    Console.Write("Enter the expiration date of " + name + ": ");
                    string expirationDate = Console.ReadLine();
                    // make sure expiration date is not empty

                    FoodItem item = new FoodItem(name, category, quantity, expirationDate);
                    foodItems = item.AddFoodItem(foodItems);
                    Console.WriteLine("\n" + name + " has been added to the list.\n");

                    break;
                case "2":
                    // Delete Food Logic
                    Console.Write("Enter the name of the food item you want to delete: ");
                    string delName = Console.ReadLine().ToLower();
                    // loop though the list of food items by index 0 of each array (lowercase) to see if delName in list
                    // if found, call delete method

                    //if not, break back to main menu
                    break;
                case "3":
                    // Print list of current food items
                    PrintList(foodItems);
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

    public static void PrintList(List<string[]> list)
    {
        // code to print list of food items
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Food Item " + (i + 1) + ":");
            Console.WriteLine("Name: " + list[i][0]);
            Console.WriteLine("Category: " + list[i][1]);
            Console.WriteLine("Quantity: " + list[i][2]);
            Console.WriteLine("Expiration Date: " + list[i][3]);
            Console.WriteLine("-------------------------------------");
        }

    }
}