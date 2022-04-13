using static System.Console;

namespace MyFirstApplication;

/*
 * 1.Create a child class based on your Horse object. Include one child attribute
 * as an auto property. Create 3 constructors. The first constructor should have 5 
 * parameters with 4 of them from Horse and your child property. Using the 
 * keyword :base(), you will put the four horse parameters in the parenthesis. In 
 * the body of the constructor you will assign your child parameter to your 
 * property. 
 * 
 * The second constructor should have 3 parameters, 2 based onthe horse and 1 from 
 * your child. Using the :this() keyword, you will pass 2 of the parent attributes 
 * and your child attribute information to the first constructor. Include default 
 * values to represent the 2 remaining horse parameters. 
 * 
 * For the last constructor, you will create the default constructor. Using 
 * the :this() keyword, you will pass 3 default values in that will pass to the 2nd
 * constructor. Also include in the class, your method for your child class
 */

/*
 * This is my derived class for Exercise 11 Inheritance for problem 1.
 */
public class Pony : Horse
{
    public int Age { get; set; }

    public Pony(bool horseShoed, int horseSize, string horseColor, int age)
        :base(horseShoed, horseSize, horseColor)
    {
        Age = age;
    }

    public Pony(bool horseShoed, int horseSize, int age)
        :this(horseShoed, horseSize, "blue", age) { }

    public Pony()
        :this(true, 4, 3) { }

    public void FeedPony()
    {
        WriteLine("The pony was fed and lived happily ever after.");
    }
}
