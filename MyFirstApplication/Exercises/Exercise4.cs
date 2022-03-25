namespace MyFirstApplication;

/*
This class covers Control Flow statements from Lesson 4.
 */
public class ExerciseFourControlFlow
{

    /*
    1.Write a method that takes 2 string arguments and a void return type. Using an
    if-else statement, compare the two strings to each other. Using a Console
    WriteLine statement, print out the results of whether the strings are equal.
    Provide a comment inside the method that says what strings you used during
    testing.
     */
    public void OneIfElse(string arg, string arg2)
    {
        /*
        Strings used for testing:
        - arg = "Hello", arg2 = "World", result was else running
        - arg = "Racecar" arg2 = "Racecar", result was if running
        */
        if(arg == arg2)
        {
            Console.WriteLine($"{arg} is equal to {arg2}");
        }
        else
        {
            Console.WriteLine($"{arg} is not equal to {arg2}");
        }

    }


    /*
    2.Write a method that will take 1 char argument and a string return type. Using
    a switch and the table below, return the description. If the value does not
    match the grade, return the default message, “Not a valid grade”.
    Grade-Description
    E-Excellent
    V-Very Good
    G-Good
    A-Average
    F-Fail
    */
    public string TwoSwitch(char arg)
    {
        switch(arg)
        {
            case 'E':
                return "Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'A':
                return "Average";
            case 'F':
                return "Fail";
            default:
                return "Not a valid grade";

        }

    }


    /*
    3.Write a method that takes no arguments and a void return type. Using an  
    iteration statement, display all the numbers divisible by 3 from 0 to 30. 
    Utilize a modulus to obtain your results.
    */
    public void ThreeIteration()
    {
        for(int i = 0; i < 31; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

    }

} // end class
