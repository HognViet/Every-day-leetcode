using System.Collections.Generic;
using System;
namespace Bai15__ThreeSumm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = new int[] { -1, -1,0, 1, 2,4};
            IList<IList<int>> result = ThreeSum(nums);
            foreach (var list in result)
            {
                Console.WriteLine(string.Join(", ", list));
            }
            
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList < IList<int> > result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue; 
                }

                while (right > left)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        right--;
                        left++;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                           
                        while (left < right && nums[right] == nums[right + 1]) right--; 
                        
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
