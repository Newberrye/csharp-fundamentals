namespace MyFirstApplication;

/*
 * This is my class for Lesson 14 exercises covering Arrays
 */
public class ExerciseFourteenArrays
{

    /*
     * 1.Write a method with no parameters and no return type. Write a single
     * dimensional string array of ice cream flavors. Using a foreach loop in your 
     * method, print out the results of your array using a Console WriteLine 
     * statement.
     */
    public void ProblemOneIceCream()
    {
        string[] flavorsArray = new string[3];
        flavorsArray[0] = "chocolate";
        flavorsArray[1] = "vanilla";
        flavorsArray[2] = "cookies and cream";

        foreach (string flavor in flavorsArray)
        {
            Console.WriteLine(flavor);
        }
    }

    /*
     * 2.Write a method with no parameters and no return type. Write a two-
     * dimensional array using the int data type. Using the link below, fill in 
     * each dimension with the KC Chiefs Regular season scores. The first dimension
     * will be the home team, while the second dimension will be the away team. 
     * Using a foreach loop, print out the results of your array using a Console 
     * WriteLine statement. To determine which team is home and away, the website 
     * includes the link to the box score. The link label shows both teams. The 
     * first team in the label is the away team. 
     * 
     * a.https://www.footballdb.com/teams/nfl/kansas-city-chiefs/results/2020
     */

    public void ProblemTwoScores()
    {
        // Chiefs vs Texans
        int[,] scoresArray = { { 0, 17, 7, 10, 34 }, { 7, 0, 0, 13, 20 } };
        int loopCounter = 0;

        // Using if statement and loopcounter to format since using foreach.
        foreach (int score in scoresArray)
        {
            if (loopCounter == 0)
            {
                Console.Write($"Chiefs Scores: {score}");
            }
            else if (loopCounter == 6)
            {
                Console.WriteLine();
                Console.Write($"Houston Scores: {score}");
            }
            else
            {
                Console.Write($", {score}");
            }

            ++loopCounter;
        }
    }

} // end class