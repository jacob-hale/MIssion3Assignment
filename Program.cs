using MIssion3Assignment;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<FoodItem> foodItems = new List<FoodItem>();
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
                    // *** with basic error handling ***
                    string name = "";
                    while (true)
                    {
                        Console.Write("Enter the name of the food item: ");
                        name = Console.ReadLine();
                        // make sure name is not empty or already in the list
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Error: Name cannot be empty.");
                        }
                        else if (foodItems.Any(item => item.name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                        {
                            Console.WriteLine("Error: This food item already exists in the list.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    string category = "";
                    while (string.IsNullOrWhiteSpace(category)) 
                    {
                        Console.Write("Enter the category of " + name + ": ");
                        category = Console.ReadLine();
                        // make sure category is not empty
                        if (string.IsNullOrWhiteSpace(category)) Console.WriteLine("Error: Category cannot be empty.");
                    }

                    int quantity;
                    while (true)
                    {
                        Console.Write("Enter the quantity of " + name + ": ");
                        // make sure quantity is a positive integer
                        if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                        {
                            break;
                        }
                        Console.WriteLine("Error: Please enter a valid positive number.");
                    }

                    string expirationDate = "";

                    while (string.IsNullOrWhiteSpace(expirationDate))
                    {
                        Console.Write("Enter the expiration date of " + name + ": ");
                        expirationDate = Console.ReadLine()?.Trim();
                        // make sure expiration date is not empty
                        if (string.IsNullOrWhiteSpace(expirationDate)) Console.WriteLine("Error: Date cannot be empty.");
                    }

                    FoodItem item = new FoodItem(name, category, quantity, expirationDate);
                    foodItems = item.AddFoodItem(foodItems);
                    Console.WriteLine("\n" + name + " has been added to the list.\n");

                    break;
                case "2":
                    // Delete Food Logic
                    Console.Write("Enter the name of the food item you want to delete: ");
                    string delName = Console.ReadLine();
                    // loop though the list of food items by index 0 of each array (lowercase) to see if delName in list
                    // if found, call delete method
                    if (foodItems.Any(item => item.name.Equals(delName, StringComparison.OrdinalIgnoreCase)))
                    {
                        FoodItem tempItem = new FoodItem("", "", 0, "");
                        foodItems = tempItem.DeleteFoodItem(foodItems, delName);
                        Console.WriteLine("\n" + delName + " has been deleted from the list.\n");
                    }
                    //if not, break back to main menu
                    else
                    {
                        Console.WriteLine("\n" + delName + " was not found in the list.\n");
                    }

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

    public static void PrintList(List<FoodItem> list)
    {
        // code to print list of food items
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("\nFood Item " + (i + 1) + ":");
            Console.WriteLine("Name: " + list[i].name);
            Console.WriteLine("Category: " + list[i].category);
            Console.WriteLine("Quantity: " + list[i].quantity);
            Console.WriteLine("Expiration Date: " + list[i].expirationDate);
            Console.WriteLine("------------------------------------- \n");
        }

    }
}