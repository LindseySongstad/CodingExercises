﻿using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            var result = TwoSum(nums, target);
            Console.WriteLine("{0}, {1}", result[0], result[1]);


            static int[] TwoSum(int[] nums, int target)
            {
                for(int i = 0; i < nums.Length; i++) 
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        if(nums[i] + nums[j] == target) return new int[] { i,j};
                    }
                }
                return new int[] { 0, 0 };
            }

        }
    }
}
