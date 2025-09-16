namespace Bai88_MergeSortedArray;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
	int[] nums1 = {1,2,3,0,0,0};
	int m =3;
	int[] nums2 = { 2, 5, 6 };
	int n =3;
	Merge(nums1, m, nums2,n);
    }
//     public static void Merge(int[] nums1, int m, int[] nums2, int n) {
// 	
//      	Array.Resize(ref nums1,m +n);
// 	for(int i =0; i< nums2.Length; i++)
// 	{
// 		nums1[m] = nums2[i];
// 		m++;
// 	}
// 	Array.Sort(nums1);
// 	foreach(var i in nums1)
// 	{
// 		System.Console.Write(i+ " ");
// 	}
//     }
 //   public static void Merge(int[] nums1, int m, int[] nums2, int n)
 //   {
	//Array.Resize(ref nums1,m +n);
	//for (int i = nums1.Length -1; i >= m; i--)
	//{
	//	nums1[i] = nums2[n-1];
	//	n--;
	//}
	//foreach (var item in  nums1)
	//{
	//	System.Console.Write(item + " ");	
	//}
 //   }
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // Copy phần còn lại của nums2 (nếu có)
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }
}
