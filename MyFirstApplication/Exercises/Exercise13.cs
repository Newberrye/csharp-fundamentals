namespace MyFirstApplication;

/*
 * This Exercise will cover Abstraction and Interfaces from Lesson 13
 */


/*
 * This Interface was created for problem 1 of Exercise 13 and will be inherited
 * from by an abstract class and implemented in a derived class of the abstract
 * class.
 */
internal interface IMovement
{
    /*
    * 1.In your Exercise13.cs file, change your class to an Interface and name it
    * IMovement.This interface will have 1 property. The property will an int and 
    * called Speed. It will have a get and init.
    */
    int Speed { get; init; }
}

/*
 * This Abstract Class inherits from the Interface.
 */
internal abstract class WaterBirds : IMovement
{
    /*
     * 2.Under the interface you will create an Abstract class called WaterBirds
     * . This abstract class will implement the IMovement interface. The interface 
     * property should be implemented in the Abstract class as an abstract 
     * property. Create two abstract methods for the abstract class that is related
     * to WaterBirds. Create a constructor that will take an int parameter and be 
     * assigned to the Speed property
     */
    public abstract int Speed { get; init; }

    public WaterBirds(int speed)
    {
        this.Speed = speed;
    }

    public abstract void Fish();
    public abstract void StealFood();
}

/*
 * This Derived Class inherits from the Abstract Class
 */
internal class Seagull : WaterBirds
{
    /*
     * 3.Under the Abstract class Waterbirds, create a derived class that will
     * extend the WaterBirds class. Implement the abstract methods and property. 
     * Use Console Writeline statements in your methods that provide information 
     * related to the methods. One of them should use an Interpolation string and 
     * consume the Speed property. Create a constructor that will take an int 
     * parameter and use the :base()to pass that int value back to the base 
     * Abstract class
     */
    public override int Speed { get; init; } = 22;

    public Seagull(int speed)
        :base(speed) { }

    public override void Fish()
    {
        Console.WriteLine("This majestic creature catches a fish.");
    }

    public override void StealFood()
    {
        Console.WriteLine($"Flying at {Speed} mph, the rat with wings steals " +
            $"your chili cheese dog.");
    }
}
