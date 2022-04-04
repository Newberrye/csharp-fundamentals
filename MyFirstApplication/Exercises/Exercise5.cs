namespace MyFirstApplication;

/*
This class contains my Exercise 5 lab for Expressions and Patterns
 */
public class ExerciseFiveExpressions
{

    /*
    1.Write a method that takes 2 int parameters and an int return
    type. Using the formula below from Ohm’s law, determine the
    voltage. The first method parameter will represent current and the
    second parameter will represent resistance. Using the 
    Func<int, int, int> and a lambda expression, determine the voltage
    calculation and return the value.
    a.Voltage = Current x Resistance
     */
    public int OneCalcVoltage(int current, int resistance)
    {
        Func<int, int, int> formula = (cur, res) => cur * res;

        int voltage = formula(current, resistance);

        return voltage;
    }

    /*
    2.Write a method that will take 1 char parameter and a string
    return type. Using a switch expression and the table below, return
    the description. If the value does not match the grade, return the
    default message, “Not a valid grade”
    - Grade - Description
    - E - Excellent
    - V - Very Good
    - G - Good
    - A - Average
    - F - Fail
    - _ - Not a valid grade
    */
    public string TwoSwitchGrade(char grade)
    {
        string description = grade switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Fail",
            _ => "Not a valid grade."
        };
        return description;
    }

    /*
    3.Write a method that takes 1 argument and a void return type.
    Using a Relational Pattern and switch expression determine a size
    of popcorn based on the table below and using a Console WriteLine,
    print the popcorn size.
    - Size - Size Value
    - <= 3 - Microwave bag
    - <= 16 - Movie sack
    - <= 32 - Movie cup
    - <= 64 - Movie tub
    - _ - We don't have that size
    */
    public void ThreeRelationalSizing(byte size)
    {
        string sizeValue = size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don't have that size."
        };
        Console.WriteLine(sizeValue);
    }

} // end class
