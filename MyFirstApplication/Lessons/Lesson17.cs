namespace MyFirstApplication;

internal class Lesson17
{
    /*
     * Lesson 17 Exceptions and Testing
     */
    public void MyThrowExample(House house)
    {
        if(house == null)
        {
            throw new NullReferenceException("House object is null");
        }
        else
        {
            Console.WriteLine(house.DoorColor);
        }
    }

    // This example will use a try/catch
    public void MyExceptionExample(House house)
    {
        try
        {
            Console.WriteLine($"The House door color is {house.DoorColor}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Null Reference was thrown: {ex.Message}");
        }
    }

    // This example will use a try/catch and finally
    public void MyArrayException()
    {
        string[] names = { "David", "Matt", "Jody" };
        string[] values = { "257", "425", "385" };

        try
        {
            byte beta = byte.Parse(values[3]);
            Console.WriteLine(beta);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Please provide atleast 1 arguement: {ex.Message}");
        }
        catch (FormatException fe)
        {
            Console.WriteLine($"That is not a number: {fe.Message}");
        }
        catch (OverflowException oe)
        {
            Console.WriteLine($"You have given me more than a byte: {oe.Message}");
        }
        finally
        {
            Console.WriteLine("Finally block is executed");
        }
    }

}
