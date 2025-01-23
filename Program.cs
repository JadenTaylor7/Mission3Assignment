using System;
using Mission3Assignment;

//Welcome user
Console.WriteLine("Welcome to the food bank!\nWhat would you like to do?");


//initialize variables
bool exitProgram = false;
string userInput = "";
int userChoice = 0;

//variables for food item
string name = "";
string category = "";
uint quantity = 1;
string expirationDate = "";
List<FoodItem> foodItems = new List<FoodItem>(); //list to store food objects


//Create a looping menu
while (exitProgram == false)
{
    Console.WriteLine("\nMenu");
    Console.WriteLine("0. Add Food Items");
    Console.WriteLine("1. Delete Food Items");
    Console.WriteLine("2. Print List of Current Food Items");
    Console.WriteLine("3. Exit the Program");
    Console.Write("Type a number 1-3: ");
    userInput = Console.ReadLine();


    //Check to see if user input is a number, then store value
    while (!int.TryParse(userInput, out userChoice))
    {
        Console.WriteLine("\nYou done messed up A-aron. That's not a valid number.");
        Console.WriteLine("\nMenu");
        Console.WriteLine("0. Add Food Items");
        Console.WriteLine("1. Delete Food Items");
        Console.WriteLine("2. Print List of Current Food Items");
        Console.WriteLine("3. Exit the Program");
        Console.Write("Type a number 1-3: ");
        userInput = Console.ReadLine();
    }



    //Execute user choice
    if (userChoice == 0) //add food items
    {
        Console.Write("What is the food item name?: ");
        name = Console.ReadLine();

        Console.Write("What is the food item category?: ");
        category = Console.ReadLine();
        

        Console.Write("What is the food item quantity?: ");
        userInput = Console.ReadLine();
        while (!uint.TryParse(userInput, out quantity))
        {
            Console.Write("\nBruh, that's not a valid input.\n");
            Console.Write("What is the food item quantity?: ");
            userInput = Console.ReadLine();
        }

        Console.Write("What is the food item expiration date (i.e. 01-07-2025)?: ");
        expirationDate = Console.ReadLine();


        // Add Person objects to the list
        if (name != "" && category != "" && expirationDate != "")
        {
            foodItems.Add(new FoodItem(name, category, quantity, expirationDate));
        } else
        {
            foodItems.Add(new FoodItem()); //If they don't specify, they get alien food
        }

    } else if (userChoice == 1) //Delete Food Items
    {
        bool deleting = true;

        if (foodItems.Count == 0) //don't offer menu if no items in stock
        {
            deleting = false;
        }

        while(deleting == true) { //loopable menu
            Console.WriteLine();
            for (int i = 0; i < foodItems.Count; i++)
            {
                Console.Write($"{i}.\t");
                foodItems[i].PrintForDeleting();
            }
            Console.WriteLine($"{foodItems.Count}.\t(Return to main menu)");

            Console.WriteLine("Which item would you like to delete?");
            Console.Write($"Choose a number from 0 to {foodItems.Count}: ");
            userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out userChoice)) //reject input if not a number
            {
                Console.Write("\nBruh, that's not a valid input.\n");
                Console.WriteLine("Which item would you like to delete?");
                Console.Write($"Choose a number from 0 to {foodItems.Count}: ");
                userInput = Console.ReadLine();
            }

            if (userChoice > foodItems.Count || userChoice < 0) //reject input if number outside of options available
            {
                Console.WriteLine("\n\n\nHaha, you're funny.\n\n\n");


            } else if (userChoice == foodItems.Count) //exit to main menu
            {
                deleting = false;


            } else //delete the item
            {
                if (foodItems[userChoice] is IDisposable disposableItem)
                {
                    disposableItem.Dispose();
                }
                foodItems.RemoveAt(userChoice);
            }
        }


    } else if (userChoice == 2) //Print List of Current Food Items
    {
        for (int i = 0; i < foodItems.Count; i++)
        {
            foodItems[i].PrintItemAttributes();
        }
       
        
    } else if (userChoice == 3) //Exit the Program
    {
        exitProgram = true;
    } else
    {
        Console.WriteLine("\nChoose a number between 0-3 please.");
    }
}