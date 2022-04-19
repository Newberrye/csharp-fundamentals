namespace MyFirstApplication;

/*
 * This class contains my exercise data for Lesson 16 Collections.
 */
public class ExerciseSixteenCollections
{

    /*
     * 1.Write a method that has no parameters and a no return type. Create a 
     * List<T> of your Horse objects. When creating your list, utilize all the 
     * constructors you created with your Horse class. Using a foreach loop, 
     * print out the results of your collection using a Console WriteLine statement
     */
    public void ProblemOneList()
    {
        List<Horse> horseList = new List<Horse>();
        horseList.Add(new Horse());
        horseList.Add(new Horse(true, 33));
        horseList.Add(new Horse(false, 22, "white"));

        foreach (Horse horse in horseList)
        {
            Console.WriteLine(horse);
            Console.WriteLine(horse.horseShoed);
            Console.WriteLine(horse.horseSize);
            Console.WriteLine(horse.horseColor);
            Console.WriteLine();
        }
    }

    /*
     * 2.Write a method that has no parameters and no return type. Using only the
     * data you used when building your favorite movies from exercise 15, create a 
     * Dictionary collection that takes an int key and string value. When adding 
     * Dictionary elements, pick an int value as the key and use the favorite 
     * movies data as the string. Using a foreach loop, print out the results of 
     * your collection using a Console WriteLine statement
     */
    public void ProblemTwoDictionary()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Foreach for adding items to list
        foreach (FavoriteMovies movie in Enum.GetValues(typeof(FavoriteMovies)))
        {
            dictionary.Add((int)movie, movie.ToString());
        }

        // Foreach for printing out dictionary
        foreach(KeyValuePair<int, string> movie in dictionary)
        {
            Console.WriteLine($"Key: {movie.Key}, Value: {movie.Value}");
        }

    }

} // end class
