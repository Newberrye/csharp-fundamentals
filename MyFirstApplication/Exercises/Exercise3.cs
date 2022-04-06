namespace MyFirstApplication;

/*
This class covers exercise 3 operators and overflow checking from Lesson 3.
 */
public class ExerciseThreeOperatorsOverflow
{

    /*
    1.Write amethod that takes 1 int argument and an int return type. Utilize the
    modulus operator to complete this task. Assign the data values below to their
    own variables. Use the Console WriteLine statement on the first 4 variables
    listed below and calculate the modulus with the passed in argument parameter.
    Using the last variable below, calculate the modulus with the passed in
    argument parameter and return it. 
    a.15
    b.456
    c.23
    d.89
    e.245
     */
    public int OneModulusMethod(int arg)
    {
        byte numA = 15;
        short numB = 456;
        byte numC = 23;
        byte numD = 89;
        byte numE = 245;

        Console.WriteLine(numA % arg);
        Console.WriteLine(numB % arg);
        Console.WriteLine(numC % arg);
        Console.WriteLine(numD % arg);
        return numE % arg;
    }

    public int ExerciseOne(int arg)
    {
        int numA = 15;
        int numB = 456;
        int numC = 23;
        int numD = 89;
        int numE = 245;

        Console.WriteLine(numA % arg);
        Console.WriteLine(numB % arg);
        Console.WriteLine(numC % arg);
        Console.WriteLine(numD % arg);
        return numE % arg;
    }


    /*
    2.Write a method that takes no arguments and a void return type. Utilizing
    the math problem in this task, fill in any missing pieces to get the output. 
    10 + 32 * 12 / 3. Write a Console WriteLine to solve each output.
    a.Output: 138
    b.Output: 168
    c.Output: 131
    */
    public void TwoMathProblem()
    {
        int outputA = 10 + 32 * 12 / 3;
        int outputB = (10 + 32) * 12 / 3;
        int outputC = (10 + 32 * 12) / 3;

        Console.WriteLine(outputA);
        Console.WriteLine(outputB);
        Console.WriteLine(outputC);
    }


    /*
    3.Write a method that takes two short type arguments and a void return type.
    Using the Compound Assignment operators below, use the first argument
    parameter as the left operand to get the result. Print each one using the
    Console WriteLine statement.
    a.+=
    b./=
    c.*=
    d.%=
    */
    public void ThreeCompoundOperators(short arg1, short arg2)
    {
        arg1 += arg2;
        Console.WriteLine(arg1);
        arg1 -= arg2;
        Console.WriteLine(arg1);
        arg1 *= arg2;
        Console.WriteLine(arg1);
        arg1 /= arg2;
        Console.WriteLine(arg1);
    }


    /*
    4.Write a method that takes two bool type arguments and a void return type.
    Using Boolean Logical operators &, |, ^, and || to complete this task. Use a
    Console WriteLine statement to calculate each result using the operators. The
    second argument is the left operand. Use the below values when testing your
    method. Using comments, provide your output results inside the method after
    your statements.
    a.Argument1= true, Argument2 = false
    b.Argument1= false, Argument2 = false
    c.Argument1= true, Argument2 = true
    d.Argument1= false, Argument2 = true
    */
    public void FourBoolStatements(bool arg1, bool arg2)
    {
        Console.WriteLine(arg2 & arg1);
        Console.WriteLine(arg2 | arg1);
        Console.WriteLine(arg2 ^ arg1);
        Console.WriteLine(arg2 || arg1);

        /*
        a.Argument1= true, Argument2 = false
            False
            True
            True
            True
        b.Argument1= false, Argument2 = false
            False
            False
            False
            False
        c.Argument1= true, Argument2 = true
            True
            True
            False
            True
        d.Argument1= false, Argument2 = true
            False
            True
            True
            True
        */
    }

} // end class
