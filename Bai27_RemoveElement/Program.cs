namespace Bai27_RemoveElement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int x = RemoveElement(new int[] { 2,3,2,3 }, 3);
        Console.WriteLine(x);
    }
    static int RemoveElement(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int duplicates = 0;
        while (right > left)
        {
            if (nums[right] == target)
            {
                right--;
                duplicates++;
            }
            else if (nums[left] != target)
            {
                left++;
            }
            else
            {
                nums[left] = nums[right];
                left++;
                right--;
                duplicates++;
            }
        }
        return nums.Length - duplicates;
    }
}
