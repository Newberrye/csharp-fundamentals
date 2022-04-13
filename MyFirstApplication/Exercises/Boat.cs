using static System.Console;

namespace MyFirstApplication;

/*
 * Exercise 10
 * 2.Create a class based on your Boat object. You will follow the
 * same instructions as exercise 1 except for the following. Include 
 * your attributes as Expression Body Definition Properties.
 */

/*
 * This is my class for Exercise 10 Encapsulation and Exercise 12 Polymorphism.
 * BoatClass was used rather than Boat cause Boat was already used
 * in the assembly.
 */
public class BoatClass
{
    public string boatColor;
    public int boatSize;
    public int maxSpeed;

    public string BoatColor
    {
        get => boatColor;
        set => boatColor = value;
    }
    public int BoatSize
    {
        get => boatSize;
        set => boatSize = value;
    }
    public int MaxSpeed
    {
        get => maxSpeed;
        set => maxSpeed = value;
    }

    public BoatClass(string boatColor, int boatSize, int maxSpeed)
    {
        this.boatColor = boatColor;
        this.boatSize = boatSize;
        this.maxSpeed = maxSpeed;
    }

    public BoatClass(string boatColor, int boatSize)
        : this(boatColor, boatSize, 20) { }

    public BoatClass()
        : this("white", 10) { }

    /*
     * Exercise 12
     * 3.In your Boat class, add the virtual keyword to your method created in
     * Lesson 10. Create a second version of the same method and add a parameter. 
     * Include a Console WriteLine method in the new method that uses the 
     * parameter. This parameter needs to be based on one of your properties.
     */
    public virtual void turnOnEngine()
    {
        WriteLine($"The {BoatColor} boat's engine was turned on");
    }

    public void turnOnEnginer(int numberOfTries)
    {
        WriteLine($"You turn on engine after {numberOfTries} tries.");
    }


}
