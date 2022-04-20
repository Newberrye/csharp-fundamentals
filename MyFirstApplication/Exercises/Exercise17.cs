﻿namespace MyFirstApplication;

/*
 * This class is used for holding Exercise 17 for Lesson 17 Exception Handling.
 */
public class ExerciseSeventeenExceptions
{

    /*
     * 1.Write a method that has two int parameters and no return type. You will
     * use a try/catch for this method. Create a division problem in the try block.
     * The catch block will utilize the DivideByZeroException. Provide a Console 
     * WriteLine message for both the try block and the catch block. The one in the
     * try block should display the answer to the division problem. The one in the 
     * catch block should have a message using Interpolation along with a variable.
     * Message syntax. Test the method with different numbers, including 0 so you 
     * can ensure the catch executes
     */
    public void ProblemOneTry(int number1, int number2)
    {
        try
        {
            // Used double for decimals, only need to convert one for it to work.
            double answer = (double)number1 / number2;
            Console.WriteLine($"{number1} / {number2} = {answer}");
        }
        catch (DivideByZeroException de)
        {
            Console.WriteLine($"Error: You tried to divide by zero: {de.Message}");
        }
    }

    /*
     * 2.Write a method that has a horse parameter and no return type. Using and if
     * statement, determine if your horse is null. If it is null, use the throw 
     * keyword and a message to indicate it is null. If the horse is not null, use 
     * a Console WriteLine statement to print out one of your horse properties.
     */
    public void ProblemTwoHorse(Horse horsey)
    {
        if(horsey == null)
        {
            throw new NullReferenceException("Horse was null.");
        }
        else
        {
            Console.WriteLine($"Your horse is the color {horsey.horseColor}.");
        }
    }

} // end class
