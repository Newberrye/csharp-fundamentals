

namespace MyFirstApplication;
/* Access Modifiers */
internal class Lesson9
{
    private int _value = 10;

    /*
     * Private access modifier can only be seen within the class, struct, or 
     * nested type
     */
    private void SamplePrivate()
    {
        Console.WriteLine("This method is private");
    }

    /*
     * Protected access modifier can only be seen within type or child
     */
    protected void SampleProtected()
    {
        Console.WriteLine("This method is protected.");
    }

    /*
     * Internal access modifier can be seen within the assembly
     */
    internal void SampleInternal()
    {
        Console.WriteLine("This method is internal");
    }

    /*
     * Protected interanl can be seen within the assembly or derived class from
     * another assembly
     */
    protected internal void SampleProtectedInternal()
    {
        Console.WriteLine("This method is protected internal.");
    }

    /*
     * Private Protected can be seen only within the class and derived class
     * from within the assembly
     */
    private protected void SamplePrivateProtected()
    {
        Console.WriteLine("This method is private protected.");
    }


    public class Nested
    {
        public Nested(Lesson9 parent)
        {
            Console.WriteLine($"The value is {parent._value}");
        }

    } // end nested class

}// end class
