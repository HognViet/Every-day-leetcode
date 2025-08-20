namespace Bai16_3Sumcloset;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        int target = 1;
        int result = ThreeSumClosest(nums, target);
        Console.WriteLine($"The closest sum to {target} is: {result}");
    }
    static int ThreeSumClosest(int[] nums, int target)
    {
        int Sumcloset = int.MaxValue;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; ++i)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (right > left)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (Math.Abs(sum - target) < Math.Abs(Sumcloset - target))
                {
                    Sumcloset = sum;
                    
                }
                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else return sum;
            }
        }
        return Sumcloset;
    }
}
