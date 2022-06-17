using System;

namespace FizzBuzz
{
    public class Generator
    {
        public string GenerateFizzBuzzFor(int input)
        {
            return input % 3 == 0 && input % 5 == 0 ? "FizzBuzz"
                : input % 3 == 0 ? "Fizz"
                : input % 5 == 0 ? "Buzz"
                : $"{input}";
        }
    }
}