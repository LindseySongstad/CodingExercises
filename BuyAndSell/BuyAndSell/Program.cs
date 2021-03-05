using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output: 7

            //Explanation: Buy on day 2(price = 1) and sell on day 3(price = 5), profit = 5 - 1 = 4.
            //Then buy on day 4(price = 3) and sell on day 5(price = 6), profit = 6 - 3 = 3.

            Console.WriteLine("Hello World!");
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

            var allTrans = getAllPosTransactions(prices);
            foreach (KeyValuePair<int[], int> kvp in allTrans)
            {
                Console.WriteLine($"kvp.Key[0], kvp.Key[1], kvp.Value");
            }



            static int MaxProfit(int[] prices)
            {
                int maxProfit = 0;
                var allTrans = getAllPosTransactions(prices);
                for (int i = 0; i < allTrans.Count; i++)
                {
                    // allTrans.Keys.ElementAt(i)
                }

                return maxProfit;
            }

            //public static List<int[]> allTransCombos

            static bool notOverlapping(int[] set1, int[] set2)
            {
                if (set1[0] > set2[1] || set2[0] > set2[1]) return true;
                else return false;
            }

            static Dictionary<int[], int> getAllPosTransactions(int[] prices)
            {
                Dictionary<int[], int> allTransactions = new Dictionary<int[], int>();
                // key [index bought, index sold] value profit
                for (int i = 0; i < prices.Length; i++) // i index day bought
                {
                    for (int j = i + 1; j < prices.Length; j++)  // j index day sold
                    {
                        int profit = prices[j] - prices[i];
                        if (profit > 0)
                        {
                            int[] days = new int[] { i, j };
                            allTransactions.Add(days, profit);
                        }
                    }
                }
                return allTransactions;
            }
        }
    }

}
