namespace MyFirstApplication;

public enum FavoriteMovies { Troy, Lord_of_the_Rings, Tucker_and_Dale_vs_Evil }

/*
 * This is my class for Lesson 15 exercises covering Enums and Tuples.
 */
public class ExerciseFifteenEnumsTuples
{

    /*
     * 1.Above the class, write an enum called Favorite Movies. Add your own
     * favorite movies to the enum. Write a method that has a string return type 
     * and an enum parameter. This enum parameter will be your favorite movie enum.
     * Write a switch expression that takes the enum and prints out a string 
     * return. Use string interpolation in your return message that includes the 
     * name of the movie chosen.
     */
    public string ProblemOneMovies(FavoriteMovies movie)
    {
        string message = movie switch
        {
            FavoriteMovies.Troy => $"My favorite movie is {FavoriteMovies.Troy}",
            FavoriteMovies.Lord_of_the_Rings => $"My favorite movie is {FavoriteMovies.Lord_of_the_Rings}",
            _ => $"My favorite movie is {FavoriteMovies.Tucker_and_Dale_vs_Evil}"
        };
        return message;
    }

    /*
     * 2.Write a method that takes an enum parameter. This enum will be your 
     * favorite movie enum. The method will have a tuple return type (int num, 
     * string movie). Using an explicit int cast on one of your enum, assign the 
     * value to an int variable. Create a second variable of type string. Assign 
     * the same enum value you used and use the ToString() at the end of it. Return
     * both variables as a tuple. See example below for clarity. 
     * 
     * a.int value = (int)Enum.Value;
     * b.string something = Enum.Value.ToString()
     */
    public (int num, string movie) ProblemTwoTuples(FavoriteMovies movie)
    {
        int number = (int)movie;
        string title = movie.ToString();

        return (number, title);
    }

} // end class
