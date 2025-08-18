namespace Bai977__Squares_of_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -7, -3, 2, 3, 11 };
            int [] result = SortedSquares(a);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        //c1
        //public static int[] SortedSquares(int[] nums)
        //{
        //    int left = 0;
        //    int right = nums.Length - 1;
        //    while (right >= left)
        //    {
        //        nums[left] = nums[left] * nums[left];
        //        nums[right] = nums[right] * nums[right];
        //        left++;
        //        right--;
        //        if (right == left)
        //        {
        //            left++;
        //            nums[right] = nums[right] * nums[right];

        //            right--;
        //            //return nums;

        //        }

                    
                
        //    }
        //    Array.Sort(nums);
        //    return nums;
        //}

        //c2
        public static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int pos = nums.Length - 1;
            int left = 0;
            int right = nums.Length - 1;
            while (right >= left)
            {
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    result[pos--] = nums[right] * nums[right];
                    right--;

                }
                else
                {
                    result[pos--] = nums[left] * nums[left];
                    left++;
                }
            }
            return result;
        }
    }
}
