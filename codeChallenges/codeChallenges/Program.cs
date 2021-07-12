using System;

namespace codeChallenges
{
    class Program
    {
        static int ArrayMax(int[] arr, int num)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    max += num;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = {6, 4, 4, 1, 3};
            int num = 4;
            ArrayMax(arr, num);
        }
    }
}
