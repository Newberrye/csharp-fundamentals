namespace MyFirstApplication;

/*
 This class covers Value types for numbers from Lesson 1.
 */
public class ExerciseOneValueTypes
{

    /*
    1.Write out a method with no arguments and a void return type that
    will print the output of the number 35 based on the number systems
    below. The values should be assigned to a variable inside the method
    prior to printing them using Console WriteLine. Utilize the
    conversion document from your resources.
    a.Decimal
    b.Hexadecimal
    c.Binary
     */
    public void OneNumberSystems()
    {
        int decimalValue = 35;
        int hexadecimalValue = 0x23;
        int binaryValue = 0b00100011;

        Console.WriteLine(decimalValue);
        Console.WriteLine(hexadecimalValue);
        Console.WriteLine(binaryValue);
    }


    /*
    2.Write a method that will accept 3 argument parameters and a void
    return type. The first argument should be of type byte. The second
    argument should be of type short. The third argument should be of
    type int. Using Implicit conversion, create variables to convert to
    usingthe below information. Use the argument parameters as the
    values to convert from. Print each converted variable using Console
    WriteLine.
    a.From byte to int
    b.From short to long
    c.From int to float
    */
    public void TwoImplicitConversion(byte num1, short num2, int num3)
    {
        int fromByteInt = num1;
        long fromShortLong = num2;
        float fromIntFloat = num3;

        Console.WriteLine(fromByteInt);
        Console.WriteLine(fromShortLong);
        Console.WriteLine(fromIntFloat);
    }


    /*
    3.Write a method that will accept 3 argument parameters and a void
    return type. The first argument should be of type double. The second
    argument should be of type float. The third argument should be of
    type long. Using Explicit conversion, create variables to convert
    tousing the below information. Use the argument parameters as the
    values to convert from. Print each converted variable using Console
    WriteLine. 
    a.From double to long
    b.From float to int
    c.From long to short
    */
    public void ThreeExplicitConversion(double num1, float num2, long num3)
    {
        long fromDoubleLong = (long)num1;
        int fromFloatInt = (int)num2;
        short fromLongShort = (short)num3;

        Console.WriteLine(fromDoubleLong);
        Console.WriteLine(fromFloatInt);
        Console.WriteLine(fromLongShort);
    }


    /*
    4.Write a method with no argument sand a void return type. Using the
    values below, assign them to a variable that best suits their value
    type. Utilize the digit separator when assigning them to your variables.
    Once you have defined your variables, print out each one using Console
    WriteLine. Do not use the same value type more than once.
    a.123456.987
    b.-9516248
    c.3500
    d.988562486
    e.-19733.14895
    */
    public void FourTypeAssignment()
    {
        float letterA = 123_456.987F;
        int letterB = -95_162_248;
        short letterC = 3_500;
        long letterD = 988_562_486L;
        double letterE = -19_733.14895D;

        Console.WriteLine(letterA);
        Console.WriteLine(letterB);
        Console.WriteLine(letterC);
        Console.WriteLine(letterD);
        Console.WriteLine(letterE);
    }

} // end class