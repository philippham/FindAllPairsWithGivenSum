using System;
using System.Collections.Generic;

namespace HasPairWithSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfPairsWithSum(new List<int>() { 1, 3, 46, 1, 46, 3, 9, 44, 38, 46, 1, 1}, 47));
            Console.WriteLine(NumberOfPairsWithSum(new List<int>() { 1, 2, 5, 7, 9 }, 8));
            Console.WriteLine(NumberOfPairsWithSum(new List<int>() { 1, 2, 2, 4, 6 }, 8));
            Console.WriteLine(NumberOfPairsWithSum(new List<int>() { 1, 2, 4, 4 }, 8));
            Console.ReadLine();
        }

        static int NumberOfPairsWithSum(List<int> roktCoupons, long sum)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < roktCoupons.Count; i++)
            {
                if (hash.Contains(roktCoupons[i]))
                {
                    if (!dict.TryGetValue((int)(sum - roktCoupons[i]), out int existing)
                        && !dict.TryGetValue(roktCoupons[i], out int existing1))
                    {
                        dict.Add(roktCoupons[i], (int)(sum - roktCoupons[i]));
                    }
                }

                hash.Add((int)(sum - roktCoupons[i]));
            }

            return dict.Count;
        }
    }
}
