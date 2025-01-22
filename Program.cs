using Mission3Assignment;

//Welcome user
Console.WriteLine("Welcome to the food bank!\nWhat would you like to do?");


//Create a looping menu
bool exitProgram = false;
string userInput = "";
int userChoice = 0;

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
    if (userChoice == 0)
    {
        continue;
        //TODO: Finish this option
    } else if (userChoice == 1)
    {
        continue;
        //TODO: Finish this option
    } else if (userChoice == 2)
    {
        continue;
        //TODO: Finish this option
    } else if (userChoice == 3)
    {
        exitProgram = true;
    } else
    {
        Console.WriteLine("\nChoose a number between 0-3 please.");
    }
}