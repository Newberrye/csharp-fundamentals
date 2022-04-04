﻿using MyFirstApplication;

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
HouseExample();
// Lesson1Example();
// Lesson2Example();
// Lesson3Example();
// Lesson4Example();
// Lesson5Example();


// Lesson 5 Expressions & Pattern Matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();

    myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    handler("Hello C#");

    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"func delegate = {add(23)}");

    myLesson5.LambdaSquare();
    myLesson5.LambdaGreeting();

    Console.WriteLine(myLesson5.BasicSwitch("green"));
    Console.WriteLine(myLesson5.FavoriteColor("black"));

    myLesson5.DrinkSize(15);

    myLesson5.TemperatureGuide(48.6);
    myLesson5.NumberChoice(3);
}


//Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(12);
    // myLesson4.BasicIfElseStatement(9);
    // myLesson4.BasicIfElseChainStatement(6);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(1);
    // myLesson4.BasicWhileStatement();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicForeachStatement();
    // myLesson4.BasicJumpStatements();
}

// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2();
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    // myLesson3.BasicCompound(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tom");
    // myLesson3.MyIncrDecrExample();
}

// Lesson 2 Srtings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.myStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedSrtings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();


    // Exercise 1 Object Example
    ExerciseOneValueTypes excerciseOne = new ExerciseOneValueTypes();
    excerciseOne.OneNumberSystems();
    excerciseOne.TwoImplicitConversion(254, 3_567, 2_147_483_646);
    excerciseOne.ThreeExplicitConversion(123_456_789D, 786.99F,
                                         9_999_999_999L);
    excerciseOne.FourTypeAssignment();


    // Exercise 2 Object Example
    ExerciseTwoStrings exerciseTwo = new ExerciseTwoStrings();
    exerciseTwo.OneStringMethods(" EXERCISE two Lab ");
    exerciseTwo.TwoUnicode();
    exerciseTwo.ThreeEscapeSequences();
    Console.WriteLine(exerciseTwo.FourInterpolation());


    // Exercise 3 Object Example
    ExerciseThreeOperatorsOverflow exerciseThree = new ExerciseThreeOperatorsOverflow();
    Console.WriteLine(exerciseThree.OneModulusMethod(10));
    exerciseThree.TwoMathProblem();
    exerciseThree.ThreeCompoundOperators(50, 100);
    exerciseThree.FourBoolStatements(true, true);

    // Exercise 4 Object Example
    ExerciseFourControlFlow exerciseFour = new ExerciseFourControlFlow();
    exerciseFour.OneIfElse("Racecar", "Racecar");
    Console.WriteLine(exerciseFour.TwoSwitch('E'));
    exerciseFour.ThreeIteration();

    // Exercise 5 Object Example
    ExerciseFiveExpressions exerciseFive = new ExerciseFiveExpressions();
    Console.WriteLine(exerciseFive.OneCalcVoltage(20, 8));
    Console.WriteLine(exerciseFive.TwoSwitchGrade('Q'));
    exerciseFive.ThreeRelationalSizing(255);

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

// ------------C# Overview Exercise-------------

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
