namespace Bai283_MoveZeroes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] nums = args.Select(int.Parse).ToArray();
        MoveZeroes(nums);
        Console.WriteLine(String.Join(", ", nums));
    }
    public static void MoveZeroes(int[] nums)
    {
        int a = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                nums[a] = nums[i];
                a++;
            }
        }

        for (int i = a; i < nums.Length; ++i)
        {
            nums[i] = 0;
        }
    }
}
