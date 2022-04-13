using static System.Console;

namespace MyFirstApplication;
/*
 * Exercise 10
 * 1.Create a class based on your Horse object. Include your
 * attributes as auto properties. Create 3 constructors. The first 
 * constructor should have parameters equal to your properties. 
 * Assign each parameter to your properties. The second constructor 
 * should have 2 parameters. Using the :this()keyword, you will pass 
 * your information to the first constructor. This includes the 2 
 * parameters and default values. For the last constructor, you will 
 * create the default constructor. Using the :this() keyword, you 
 * will pass 2 default values in that will pass to the 2nd 
 * constructor. Also include in the class, your method for Horse.
 */

/*
 * This is my Class for Exercise 10  Encapsulation & Exercise 12 Polymorphism.
 */
public class Horse
{
    public bool horseShoed { get; init; }
    public int horseSize { get; init; }
    public string horseColor { get; init; }

    public Horse(bool horseShoed, int horseSize, string horseColor)
    {
        this.horseShoed = horseShoed;
        this.horseSize = horseSize;
        this.horseColor = horseColor;
    }

    public Horse(bool horseShoed, int horseSize)
        :this(horseShoed, horseSize, "brown") { }

    public Horse()
        :this(true, 5) { }

    /*
     * Exercise 12
     * 1.In your Horse class, add the virtual keyword to your method created in
     * Lesson 10. Create a second version of the same method and add a parameter. 
     * Include a Console WriteLine method in the new method that uses the 
     * parameter. This parameter needs to be based on one of your properties.
     */
    public virtual void gallop()
    {
        WriteLine($"The {this.horseColor} horse gallops.");
    }

    public void gallop(int horseSpeed)
    {
        WriteLine($"The horse gallops {horseSpeed} mph.");
    }
}
