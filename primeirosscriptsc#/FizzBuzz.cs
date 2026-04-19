namespace primeirosscriptsc_;


public class FizzBuzz()
{
    public void Main()
    {
        //divisivel por 3 fizz
        //divisivel por 5 buzz
        //divisivel por ambos fizbuzz
        //else: numero

        for (int i = 1; i < 51; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            } else if (i % 3 == 0) {
                Console.WriteLine("Fizz");
            } else if (i % 5 == 0) {
                Console.WriteLine("Buzz");
            } else
            {
                Console.WriteLine(i);
            }
        }
    }

}

