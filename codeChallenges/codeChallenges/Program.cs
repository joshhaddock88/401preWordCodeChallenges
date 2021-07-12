using System;

namespace codeChallenges
{
    class Program
    {
        static void ArrayMax()
        {
            int max = 1;
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Choose a number between 1 and 10: ");
                string request = Console.ReadLine();
                numbers[i] = Convert.ToInt32(request);
            }
            foreach(var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Write("Choose one more number: ");
            string scoreString = Console.ReadLine();
            int scoreNumber = Convert.ToInt32(scoreString);
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == scoreNumber)
                {
                    max *= scoreNumber;
                }
            }
            Console.WriteLine("Your number score is {0}!", max);
        }
        static void Main(string[] args)
        {
            ArrayMax();
        }
    }
}
