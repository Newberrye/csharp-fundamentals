using static System.Console;

namespace MyFirstApplication;

/*
 * 2.Create a class based on your Boat object. You will follow the
 * same instructions as exercise 1 except for the following. Include 
 * your attributes as Expression Body Definition Properties.
 */

/*
 * This is my class for Exercise 10 Encapsulation for problem 2.
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

    public void turnOnEngine()
    {
        WriteLine($"The {BoatColor} boat's engine was turned on");
    }


}
