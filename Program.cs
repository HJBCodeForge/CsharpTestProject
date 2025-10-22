// See https://aka.ms/new-console-template for more information
//dotnet build, build the project for the first time
//dotnet run, run the project
//dotnet new console -o ./CsharpProjects/TestProject
//create a new console project in the specified folder

//---Example of stateful and stateless (static) methods---
//Stateful methods rely on instance data (object state) to perform their operations, 
//Stateless(static) methods do not depend on any instance data and can be called without creating an instance of the class.
// Random dice = new(); //stateful method
// int roll = dice.Next(1, 7); //stateless (static) method
// Console.WriteLine(roll);

//---VOID METHODS---, which do not return a value
//Other methods return a value, the return value is typically the result of an operation. 
//Return value is the primary way for a method to communicate back to the code

//---Overloaded methods---
//Methods can be overloaded by defining multiple methods with the same name but different parameter lists (different types or number of parameters).
//The appropriate method is selected based on the arguments provided during the method call.
// int number = 7;
// string text = "seven";

// Console.WriteLine(number); //int as parameter
// Console.WriteLine(); //zero parameters
// Console.WriteLine(text); //string as parameter

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next(roll3);

//Math class methods challenge
//Implement a method of the Math class that returns the larger of two numbers
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

/*---DECISION MAKING LOGIC---*/
// Random dice = new();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// } else
//     {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;       
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You Win a Car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You Win a new Laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a Trip!");
// }
// else
// {
//     Console.WriteLine("You win a kitten.");
// }

//--Challenge: Improve renewal rate of subscriptions--
// Random random = new();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
// }

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
//     {
//         Console.WriteLine($"Your subscription expires within a day! \nRenew now and save {discountPercentage}%!");
//     }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. \nRenew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

//---Arrays ---
//Declaring the array
//string[] fraudulentOrderIds = new string[3];

//Assigning Values
// fraudulentOrderIds[0] = "A123";
// fraudulentOrderIds[1] = "B456";
// fraudulentOrderIds[2] = "C789";

//Out of bounds Index
//fraudulentOrderIds[3] = "D000";

//Initialize an array
//string[] fraudulentOrderIds = ["A123", "B456", "C789"];

//Retrieve values
// Console.WriteLine($"First: {fraudulentOrderIds[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

//Reassign values
// fraudulentOrderIds[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");

//Lenght Property
// Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

//--foreach in arrays--
// int[] inventory = [200, 450, 700, 175, 250];
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in the inventory.");

// string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// string[] orderStartingWithB;

// foreach (string oder in orderIDs)
// {
//     if (oder.StartsWith("B"))
//     {
//         Console.WriteLine(oder);
//     }
// }

//---Create Readable Code with Conventions, whitespace and comments ---
//1. Variable name conventions
//a. camel case e.g. thisIsCamelCase;
//b. names should be descriptive and meaningful e.g. 
// You should choose a name for your variable that represents 
// the kind of data it will hold (not the data type). 
// bool orderComplete;, NOT bool isComplete;.
//c. names should be one or more entire words appended together. 
// Don't use contractions because the name of the variable may be unclear to others 
// For example: decimal orderAmount;, NOT decimal odrAmt;.
//d. names shouldn't include the data type of the variable
// like string strMyValue;
// Variable name examples:
// char userOption;
// int gameScore;
// float particlesPerMillion;
// bool processedCustomer;

//Create and use code comments
//Block comments
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

//--Use whitespace to make your code easier to read--
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

//Code readability challenge

/*This code takes in a sentance a reverse it. 
It also itterates through all the letters 
and counts the amount of o's in the sentance.
I then writes the reversed sentance and the o count to the terminal*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");