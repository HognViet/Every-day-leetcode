namespace Bai42_TrappingRainWater;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int k = Trap(  new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        Console.WriteLine(k);
    }

    //c1
    //static int Trap( int[] height)
    //{
    //    int waterTrapped = 0;
    //    for( int i = 0; i <= height.Length -2; i++)
    //    {
    //        int left = 0, right = height.Length - 1;
    //        int leftMax = 0, rightMax = 0;
    //        {
    //            while (left <i)
    //            {
    //                leftMax = Math.Max(leftMax, height[left]); left++;
    //            }
    //            while (right > i)
    //            {
    //                rightMax = Math.Max(rightMax, height[right]); right--;
    //            }
    //            waterTrapped += Math.Max(0, Math.Min(leftMax, rightMax) - height[i]);
    //        }
    //    }
    //    return waterTrapped;
    //}

    //c2
    //static int Trap(int[] height)
    //{
    //    int waeterTrapped = 0;
    //    int[] leftMax = new int[height.Length];
    //    for (int i = 1; i < height.Length; i++)
    //    {
    //        leftMax[0] = 0;
    //        leftMax[i] = Math.Max(leftMax[i - 1], height[i - 1]);
    //    }
    //    int[] rigthMax = new int[height.Length];
    //    for (int i = height.Length - 2; i >= 0; i--)
    //    {
    //        rigthMax[height.Length - 1] = 0;
    //        rigthMax[i] = Math.Max(rigthMax[i + 1], height[i + 1]);
    //    }
    //    for (int i = 0; i < height.Length; i++)
    //    {
    //        waeterTrapped += Math.Max(0, Math.Min(leftMax[i], rigthMax[i]) - height[i]);
    //    }


    //    return waeterTrapped;
    //}
    static int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int leftMax = 0, rightMax = 0;
        int waterTrapped = 0;
        while (right > left)
        {
            if (height[left] < height[right])
            {
                if (height[left] > leftMax )
                {
                    leftMax = height[left];
                }
                else
                {
                     waterTrapped += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] > rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    waterTrapped += rightMax - height[right];
                }
                right--;
            }
        }
        return waterTrapped;
    }
}

