using System;
using System.Collections.Generic;

namespace LeetCodeQuestions
{
    class TwoSum
    {
        public static void Process()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };

            var result = BruteForceApproach(nums, 9);
            Console.WriteLine("[" + result[0] + "," + result[1] + "]");
        }

        public static int[] BruteForceApproach(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return Array.Empty<int>();
        }

        public static int[] TwoSumLogic(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    return new int[] { map[diff], i };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            return Array.Empty<int>();
        }
    }
}
