using System;

namespace codeChallenges
{
    class Program
    {
        static void ArrayMax()
        {
            int max = 0;
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
                    max += scoreNumber;
                }
            }
            Console.WriteLine("Your number score is {0}!", max);
        }

        static void LeapYear()
        {
            Console.Write("Choose a year and I'll tell you if it's a leap year: ");
            string yearString = Console.ReadLine();
            int yearInt = Convert.ToInt32(yearString);
            if (yearInt % 4 == 0 && (yearInt % 100 != 0 || yearInt % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year!", yearString);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year...", yearString);
            }
        }

        static void PerfectSequence(int[] arr)
        {
            int sum = 0;
            int product = 1;
            bool hasNegative = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    foreach(int item in arr)
                    {
                        Console.Write("{0} ", item);
                    }
                    Console.WriteLine("No");
                    hasNegative = true;
                    break;
                }
                else
                {
                    sum += arr[i];
                    product *= arr[i];
                }
            }
            if(sum == product && hasNegative == false)
            {
                foreach (int item in arr)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine("Yes");
            }
            else if (sum != product && hasNegative == false)
            {
                foreach (int item in arr)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            //ArrayMax();
            //LeapYear();
            PerfectSequence(new int[] { 1, 3, 2});
        }
    }
}
