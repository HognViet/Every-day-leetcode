namespace Bai11_ContainerWithMostWater;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int k = MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        Console.WriteLine(k);

    }
    public static int MaxArea(int[] height)
    {
        int max = 0;

        int right = height.Length - 1;
        int left = 0;

        while (right > left)
        {

            int temp = (right - left) * Math.Min(height[right], height[left]);
            if (max < temp) max = temp;

            if (height[right] <= height[left]) right--;
            else left++;
        }
        return max;
    }
}
