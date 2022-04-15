using MyFirstApplication;

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
// Lesson1Example();
// Lesson2Example();
// Lesson3Example();
// Lesson4Example();
// Lesson5Example();
// Lesson6Example();
// Lesson7Example();
// Lesson8Example();
// Lesson9Example();
// Lesson10Example();
// HouseUpdated();
// Lesson11Example();
// Lesson12Example();
// CondoExample();
Lesson13Example();

void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();

    Console.WriteLine($"Converting feet to inches {total1}");
    Console.WriteLine($"Converting yards to feet {total2}");

    // These are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting miles to yards {total3}");
}

void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}

void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    myFruit.EatFruit(3);

    Apple myApple = new Apple();
    myApple.EatFruit();

}

void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine(total2);
}

void HouseUpdated()
{
    // Calling default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling Constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(myHouse.WindowSize);
    mySecond.DoorOpenClose();

    // Calling Constructor with four parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myHouse.Foundation);
    myThird.DoorOpenClose();
}

void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();

    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);

    // Normal property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // Calling auto properties
    // myLesson10.LastName = "Smith"; // can only be set in constructor
    Console.WriteLine(myLesson10.Id);
    myLesson10.Id = 8;
    Console.WriteLine(myLesson10.Id);

    // Expression Body Property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // Second constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.ZipCode);
}

void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers; Can't see Private, Protected, and Private Protected
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
    
}

void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling constant directly
    Console.WriteLine(Lesson8.DaysPeMonth);

    // Calculate temperature with static class
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times.");

    myLesson8.CalculateHoursV2();

}


void Lesson7Example()
{
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // Readonly Struct
    Student myStudent = new Student(10, "Roger");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);
}


// Lesson 6 Constructors
void Lesson6Example()
{
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");


    Console.WriteLine();
    Lesson6 myOtherLesson6 = new Lesson6(22);

    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize);
    myHats.HatSize = 6;
    Console.WriteLine(myHats.HatSize);

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    //Multi-cast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");
}


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
    myLesson4.BasicWhileStatement();
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

    // Exercise 6 Constructor Example
    ExerciseSixConstructors exerciseSix = new ExerciseSixConstructors(7, "Adidas");
    Console.WriteLine(exerciseSix.ShowSize);
    exerciseSix.ShowSize = 8;
    Console.WriteLine(exerciseSix.ShowSize);

    ExerciseSixConstructors.TryOn shoes = exerciseSix.printMessage;
    shoes($"I tried on the shoes {exerciseSix.ShoeType} of size {exerciseSix.ShowSize}");

    // Exercise 7 Struct and Record Example
    Employee employee = new Employee(789, "Robert");
    Console.WriteLine(employee.EmployeeName);
    employee.EmployeeName = "Kyle";
    Console.WriteLine(employee.EmployeeName);

    Boat boatyMcBoatFace = new Boat("blue", 78, 25);
    Console.WriteLine(boatyMcBoatFace.paintColor);
    boatyMcBoatFace.turnEngineOn();

    // Exercise 8 Constant and Static
    ExerciseEightStatic exerciseEight = new ExerciseEightStatic();
    exerciseEight.ConvertFeetToInches(3);
    ExerciseEightStatic.CalcRectArea(20, 20);
    ExerciseEightStatic.CalcRectArea(34, 3);
    ExerciseEightStatic.CalcRectArea(1_000, 1_000);

    // Exercise 10 Encapsulation
    Horse horse = new Horse();
    Horse horse2 = new Horse(false, 6);
    Horse horse3 = new Horse(false, 8, "Black");

    Console.WriteLine(horse.horseSize);
    Console.WriteLine(horse2.horseSize);
    Console.WriteLine(horse3.horseSize);
    horse.gallop();

    BoatClass boat = new BoatClass();
    BoatClass boat2 = new BoatClass("blue", 12);
    BoatClass boat3 = new BoatClass("black", 12, 25);

    Console.WriteLine(boat.BoatColor);
    Console.WriteLine(boat.BoatSize);
    Console.WriteLine(boat.MaxSpeed);
    Console.WriteLine(boat2.BoatColor);
    Console.WriteLine(boat2.BoatSize);
    Console.WriteLine(boat2.MaxSpeed);
    Console.WriteLine(boat3.BoatColor);
    Console.WriteLine(boat3.BoatSize);
    Console.WriteLine(boat3.MaxSpeed);

    boat.turnOnEngine();


    // Exercise 11 Inheritance
    Pony pony = new Pony();
    Pony pony2 = new Pony(false, 3, 2);
    Pony pony3 = new Pony(false, 2, "black", 1);

    Console.WriteLine(pony.horseShoed);
    Console.WriteLine(pony.horseSize);
    Console.WriteLine(pony.horseColor);
    Console.WriteLine(pony.Age);
    Console.WriteLine(pony2.horseShoed);
    Console.WriteLine(pony2.horseSize);
    Console.WriteLine(pony2.horseColor);
    Console.WriteLine(pony2.Age);
    Console.WriteLine(pony3.horseShoed);
    Console.WriteLine(pony3.horseSize);
    Console.WriteLine(pony3.horseColor);
    Console.WriteLine(pony3.Age);

    pony.FeedPony();

    //Exercise 12 Polymorphism
    horse.gallop(7);
    pony.gallop();
    boat.turnOnEngine(8);
    
    SpeedBoat speedBoat = new SpeedBoat();
    speedBoat.turnOnEngine();


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

// Bottles of beer example
// BottlesOfBeer beerSong = new BottlesOfBeer();
// beerSong.LetsSing();


// ------------C# Overview Exercise-------------

/*
This local function is  for my first exercise lab.
*/

//void MyLocalFunction()
//{
//    Console.WriteLine("This is my first sentence");
//    Console.WriteLine("I am new to CSharp");
//    Console.WriteLine("This CSharp course is cool");
//    Console.WriteLine("I am learning stuff every day.");
//}
