namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            foreach (int x in result)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("Hello, World!");
        }

        static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return new int[] { };
            }
            int left = 0;
            int right = nums.Length - 1;
            while (right >= left)
            {
                if (nums[left] + nums[right] == target)
                {
                    return new int[] { left, right };
                }

                if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else
                    left++;     
            }
            return new int[] { };
        }
    }
}
