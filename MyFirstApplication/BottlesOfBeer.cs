using static System.Console;

namespace MyFirstApplication;

// This class uses loops and if statements to sing a song.
internal class BottlesOfBeer
{

    private int _beerNum = 99;
    private string _word = "bottles";

    public void LetsSing()
    {

        while(_beerNum > 0)
        {
            if(_beerNum == 1)
            {
                _word = "bottle";
            }

            WriteLine($"{_beerNum} {_word} of beer on the wall.");
            WriteLine($"{_beerNum} {_word} of beer.");
            WriteLine("Take one down.");
            WriteLine("Pass it around.");

            _beerNum--;

            if(_beerNum > 0)
            {
                WriteLine($"{_beerNum} {_word} of beer on the wall.");
                WriteLine();
            }
            else
            {
                WriteLine("No more bottles of beer on the wall.");
            }
        }

    }

}
