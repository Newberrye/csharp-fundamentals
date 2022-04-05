
namespace MyFirstApplication;

/*
This lesson goes over Expressions & Pattern Matching.
It will also include an intro to delegates.
 */
internal class Lesson5
{

    // Delegate
    public delegate void Del(string message);

    /*
     The is operator checks if the result of an expression is
    compatible with another type
     */
    public void IsOperatorExample(int able)
    {
        object bravo = able;

        Console.WriteLine(bravo is int);
        Console.WriteLine(bravo is long);
    }

    /*
     Create a method for delegate example
     */
    public void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    /*
     Method for Func Delegate
     */
    public int Sum(int beta)
    {
        return beta + 2;
    }

    /*
     Lambda using the Func Delegate
     */
    public void LambdaSquare()
    {
        Func<int, int> square = able => able * able;
        Console.WriteLine(square(4));
    }

    /*
     Lamba using the Action Delegate
     */
    public void LambdaGreeting()
    {
        Action<string> greet = name =>
        {
            string greeting = $"Hello {name}! We are learning.";
            Console.WriteLine(greeting);
        };

        greet("Lambda");
    }

    /* Basic Switch */
    public string BasicSwitch(string able)
    {
        switch(able)
        {
            case "blue":
                return "Favourite color is blue.";
            case "red":
                return "Favourite color is red.";
            case "green":
                return "Favourite color is green.";
            default:
                return $"Favourite color is {able}.";
        }
    }

    /* Switch Expression based on above switch */
    public string FavoriteColor(string charlie)
    {
        string result = charlie switch
        {
            "blue" => "Favourite color is blue.",
            "red" => "Favourite color is red.",
            "green" => "Favourite color is green.",
            _ => $"Favourite color is {charlie}."
        };

        return result;
    }

    /*
     Relation Pattern compares an expression result with a constant.
     */
    public void DrinkSize(int size)
    {
        string result = size switch
        {
            <= 20 => "Can",
            <= 32 => "bottle",
            <= 64 => "Big Gulp",
            _ => "We don't have that size."
        };
        Console.WriteLine(result);
    }

    /*
     Logical pattern And matches an expression when both patterns match
     */
    public void TemperatureGuide(double temp)
    {
        string result = temp switch
        {
            < -10.0 and < 0 => "Negative cold",
            >= 0 and < 32.0 => "Freezing cold",
            >= 32.0 and < 49.0 => "Cold",
            >= 49.0 and < 60.0 => "Warm",
            >= 60.0 and < 90.0 => "Nice",
            >= 90.0 and < 105.0 => "Too hot",
            _ => "Unknown."
        };
        Console.WriteLine(result);
    }

    /*
     Logical Pattern OR matches an expression when either pattern
    matches the expression.
     */
    public void NumberChoice(int able)
    {
        string result = able switch
        {
            1 or 2 => $"{able} is 1 or 2",
            3 or 4 => $"{able} is 3 or 4",
            5 => $"{able} is 5",
            _ => $"{able} was not on the list"

        };
        Console.WriteLine(result);
    }


}
