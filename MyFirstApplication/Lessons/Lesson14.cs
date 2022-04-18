
namespace MyFirstApplication;

// Lesson 14 Arrays
internal class Lesson14
{

    // Single Dimension Array
    public void SingleIntArray()
    {
        int[] intArray = { 2, 5, 34, 56, 28, 32 };

        foreach (int item in intArray)
        {
            Console.WriteLine(item);
        }
    }

    // Single Array House
    public void SingleHouseArray()
    {
        House[] houseArray = new House[3];
        houseArray[0] = new House("concrete", "steel");
        houseArray[1] = new House();
        houseArray[2] = new House("dirt", "bamboo", "green", 33);

        foreach (House house in houseArray)
        {
            Console.WriteLine($"House Roof in collection is {house.RoofType}");
        }
    }

    // MultiDimensional Array
    public void MultiIntArray()
    {
        int[,] sampleInt = new int[2,2];
        sampleInt[0,0] = 2;
        sampleInt[0,1] = 4;
        sampleInt[1,0] = 6;
        sampleInt[1,1] = 8;

        foreach(int item in sampleInt)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    }

    public void MultiStringArray()
    {
        string[,] myStringArray = { { "happy", "coding", "day"},
            { "sad", "deploy", "bugs" } };
        for (int i = 0; i < myStringArray.GetLength(0); i++)
        {
            for (int j = 0; j < myStringArray.GetLength(1); j++)
            {
                Console.WriteLine(myStringArray[i, j]);
            }    
        }
    }

    // Jagged Array is also an array of arrays
    public void JaggedArraySample()
    {
        int[][] sampleArray = new int[3][];
        sampleArray[0] = new int[] { 2, 4 };
        sampleArray[1] = new int[] { 6, 8, 10 };
        sampleArray[2] = new int[] { 12, 13, 16, 18 };

        foreach (int[] items in sampleArray)
        {
            Console.WriteLine();
            foreach(int item in items)
            {
                Console.Write($"{item}, ");
            }
        }
    }

}
