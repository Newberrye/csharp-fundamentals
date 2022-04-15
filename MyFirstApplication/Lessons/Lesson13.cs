
namespace MyFirstApplication;

/*
 * This will be about Abstract modifier and Interfaces
 */
public interface ILesson13
{
    int Miles { get; }
    int ConvertMilesToYards();
}


internal abstract class Lesson13Base : ILesson13
{

    protected int num;

    // Abstract Properties
    protected abstract int Inches { get; }
    protected abstract int Feet { get; }

    // Implemented from Interface
    public abstract int Miles { get; }

    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    // Abstract Methods
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardsToFeet();

    // Implemented from Interface
    public abstract int ConvertMilesToYards();
}

/*
 * Our derived class will implement our Abstract class members
 */
internal class Lesson13Derived : Lesson13Base
{
    // implementing abstract properties
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;
    public override int Miles { get; } = 1760;

    public Lesson13Derived(int value)
        :base(value) { }

    // implemented abstract methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    }
    public override int ConvertYardsToFeet()
    {
        return num * Feet;
    }
    public override int ConvertMilesToYards()
    {
        return num * Miles;
    }

}
