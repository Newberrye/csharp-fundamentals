namespace MyFirstApplication;

/*
 * This is my class covering Constant and Static for Lesson 8 exercises.
 */
public class ExerciseEightStatic
{
    /*
     * 1.Write a constants at the class level. The constant should be Foot
     * with a value of 12 to represent the number of inches in a foot. Write a
     * method that takes 1 int parameter and a void return type. This method 
     * will convert feet to inches. The formula that you would use will be the
     * parameter * Foot. Your parameter will represent the number of feet to  
     * convert to inches. Using a Console WriteLine statement, print the 
     * results. Test your method using the number 3 to see if you get 36
     */
    public const int Foot = 12; // inches in a foot

    public void ConvertFeetToInches(int footInput)
    {
        Console.WriteLine(footInput * Foot);
    }

    /*
     * 2.Write a static method that take 2 int parameters and a void return 
     * type. This method will be used to calculate the length and width of a 
     * rectangle/square. This formula is length x width. The first parameter 
     * should represent the length and the second parameter should be the 
     * width. Using a Console WriteLine statement, print the results. Test 
     * your method and add what you used to test as a comment either before 
     * the method or after.
     */

    public static void CalcRectArea(int length, int width)
    {
        Console.WriteLine($"{length * width:N0}");
    }
    /*
     * ExerciseEightStatic.CalcRectArea(20, 20); => 400
     * ExerciseEightStatic.CalcRectArea(34, 3); => 102
     * ExerciseEightStatic.CalcRectArea(1_000, 1_000); => 1,000,000
     */


} // end class