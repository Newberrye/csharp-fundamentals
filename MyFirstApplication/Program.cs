using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment

/*
 Multi-line comment
The below statement is a local function. Local functions are inside of 
members and are private by default. this means they are specific to 
that member and can only be called inside that member.
 */

// Lesson Examples
// HouseExample();
Lesson1Example();

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();

}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}

// ------------C# Exercise-------------

/*
This local function is  for my first exercise lab.
*/

void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day.");
}
