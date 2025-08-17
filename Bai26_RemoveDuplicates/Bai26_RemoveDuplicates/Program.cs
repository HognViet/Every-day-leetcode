namespace Bai26_RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 3 };
            
            int k = RemoveDuplicates(a);
            Console.WriteLine(k); ;
            Console.WriteLine("Hello, World!");
        }
     static int RemoveDuplicates(int[] nums)
        {
            int sau = 0;
            int trc = 1;
            while (trc <= nums.Length - 1)
            {
                if (nums[sau] != nums[trc])
                {
                    sau++;
                    nums[sau] = nums[trc];
                }
                else trc++;
            }
            return sau + 1;
        }
    }
}   
