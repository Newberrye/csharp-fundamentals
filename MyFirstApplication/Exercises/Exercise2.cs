namespace MyFirstApplication;

/*
This class has my Lesson 2 exercises covering strings.
 */
public class ExerciseTwoStrings
{

    /*
    1.Write a method that takes a string argument parameter and void return type.
    Using string concatenation and the below string methods, write a Console
    WriteLine statement for each of them. Inside the string concatenation will be
    the name of each string method. When testing this method use the following
    string “EXERCISE two Lab “. Do not copy and paste this in Visual Studio. It
    will not paste correctly.
    a.Trim()
    b.ToLower()
    c.Contains(“tow”)
    d.Length()
    e.IndexOf(‘C’)
     */
    public void OneStringMethods(string strValue)
    {
        Console.WriteLine("Trim: " + strValue.Trim());
        Console.WriteLine("ToLower: " + strValue.ToLower());
        Console.WriteLine("Contains: " + strValue.Contains("tow"));
        Console.WriteLine("Length: " + strValue.Length);
        Console.WriteLine("IndexOf: " + strValue.IndexOf('C'));

    }


    /*
    2.Write a method that takes no arguments and a void return type. Using the
    Unicode table resource link, assign the Unicode value of the Pilcrow Sign to
    a variable. Use the Console WriteLine to print that variable. This variable
    should utilize the type that takes 1 character.
    */
    public void TwoUnicode()
    {
        char pilcrow = '\u00B6';
        Console.WriteLine(pilcrow);
    }


    /*
    3.Write a method that takes no arguments and a void return type. Use1 string
    variable and 1 Console WriteLine to complete this task. Use escape sequences
    to achieve the below results.
    */
    public void ThreeEscapeSequences()
    {
        string output = "Jack and Jill\nwent up the hill\nto fetch a pail of" +
            " water.\nJack fell down and broke his crown\nand Jill came tumbling"
            + " after.";
        Console.WriteLine(output);
    }


    /*
    4.Write a method that takes no arguments but does have a string return type.
    You will utilize Interpolation to complete this task. Create variables for
    each provided data below. Using Interpolation return a string that includes
    the variables in a sentence.
    a.Name
    b.Favorite movie
    c.Favorite movie snack
    d.Favorite movie drink
    */
    public string FourInterpolation()
    {
        string name = "Ethan";
        string movie = "Troy";
        string snack = "Crunch";
        string drink = "Dr Pepper";
        string interpolated = $"I'm {name}, my favourite movie is {movie} and I"
            + $" love having {snack} and {drink} at the movies!";
        
        return interpolated;
    }

} // end class