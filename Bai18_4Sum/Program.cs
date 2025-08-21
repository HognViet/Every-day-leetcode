namespace Bai18_4Sum;

class Program
{
    static void Main(string[] args)
    {
        IList<IList<int>> result = FourSum(new int[] { 2,2,2,2,2 }, 8);
        foreach (var list in result)
        {
            Console.WriteLine(string.Join(", ", list));
        }
        Console.WriteLine("Hello, World!");
    }
    static IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        for (int i =0; i< nums.Length - 3; ++i)
        {
            if( i > 0 && nums[i] == nums[i - 1]) continue;
            if ((long)nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > (long)target)
            {
                break;
            }
                for (int j =i+1; j< nums.Length - 2;j++)
            {
                if( j > i + 1 && nums[j] == nums[j - 1]) continue;
                int left = j + 1;
                int right = nums.Length - 1;
               
                if ((long)nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > (long)target)
                {
                    break;
                }
                while ( right > left)
                {
                    long sum = nums[i] + nums[j] + nums[left] + nums[right];
                    if( sum == target)
                    {
                        result.Add( new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;
                        while (right > left && nums[left] == nums[left - 1])   left++;
                        while (right > left && nums[right] == nums[right + 1])   right--;
                        
                    }

                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }

                }
            }
        }
        return result;
        
    }
}
