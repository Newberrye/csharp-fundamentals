namespace MyFirstApplication;

/*
This is my class for Exercise 6 covering Constructors, Methods, and Delegates.
 */
public class ExerciseSixConstructors
{

    /*
    1.Write a constructor for your exercise file that takes 2 parameters.
    The first parameter should have an int type and a variable name of
    showSize. The second parameter should have a string type and a variable
    name of shoeType. Create private class variables for these types and use
    and underscore when defining them. Inside the constructor associate the
    class variables with the constructor parameters.
     */

    private int _showSize;
    private string _shoeType;
    public ExerciseSixConstructors(int showSize, string shoeType)
    {
        _showSize = showSize;
        _shoeType = shoeType;
    }

    /*
    2.Write the properties for the class variables defined in exercise 1.
    Ensure they are labeled as public and are spelled using a capital
    letter.
     */
    public int ShowSize
    {
        get { return _showSize; }
        set { _showSize = value; }
    }
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }

    /*
    3.Write a delegate that takes a string parameter. This delegate should
    be named TryOn. Write a method that takes a string argument and void
    return type. In the method body include a Console WriteLine statement
    that will print the message. Test your delegate in Program.cs to ensure
    everything works properly. Using a mult-line comment on your
    Exercise6.cs file, provide the information you used to test the
    delegate.
     */
    public delegate void TryOn(string hatName);

    public void printMessage(string message)
    {
        Console.WriteLine(message);
    }

    /*
     Delegate Test done:

    ExerciseSixConstructors exerciseSix = new ExerciseSixConstructors(7,
        "Adidas");

    ExerciseSixConstructors.TryOn shoes = exerciseSix.printMessage;
    
    shoes($"I tried on the shoes {exerciseSix.ShoeType} of size
        {exerciseSix.ShowSize}");


    The code above is what I used to test the delegate, by assigning it to
    the printMessage method of the object exerciseSix. The output I got was:
    
    I tried on the shoes Adidas of size 8
     */


} // end class
