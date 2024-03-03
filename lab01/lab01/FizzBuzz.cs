using System;

namespace lab01
{
    public class FizzBuzz
    {
        private int _limit;
        public FizzBuzz(int limit) => _limit = limit;

        public void Display()
        {
            for (var i = 1; i <= _limit; i++)
            {
                var fizz = i % 3 == 0;
                var buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("Fizz Buzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}