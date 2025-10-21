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
