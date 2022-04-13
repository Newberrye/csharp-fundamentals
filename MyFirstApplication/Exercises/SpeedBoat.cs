using static System.Console;

namespace MyFirstApplication;

/*
 * 2.Create a child class based on your Boat object. You will follow the same 
 * instructions as exercise 1 except for the following. Include 1 child attribute 
 * as Expression Body Definition Properties.
 */

/*
 * This is my derived class for Exercise 11 Inheritance for problem 2.
 */
public class SpeedBoat : BoatClass
{
    public int numberOfEngines;

    public int NumberOfEngines
    {
        get => numberOfEngines;
        set => numberOfEngines = value;
    }

    public SpeedBoat(string boatColor, int boatSize, int maxSpeed, int numberOfEngines)
        :base(boatColor, boatSize, maxSpeed)
    {
        this.numberOfEngines = numberOfEngines;
    }

    public SpeedBoat(string boatColor, int boatSize, int numberofEngines)
        : this(boatColor, boatSize, 30, numberofEngines) { }

    public SpeedBoat()
        : this("black", 5, 2) { }

    public void IntimidateBoaters()
    {
        WriteLine("You intimidate other boaters by revving your engine and speeding off.");
    }
}
