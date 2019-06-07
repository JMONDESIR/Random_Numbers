using System;
using System.Collections.Generic;

namespace Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};
            for (int i = 0; i < numbers.Count; i++)
                if (numbers.Contains(i))
                {
                    Console.WriteLine("Number list contains " + i);
                }
                else
                {
                    Console.WriteLine("Number list does not contain " + i);
                }
        }
    }
}

