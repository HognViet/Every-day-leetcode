namespace Bai1295;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
	// 
	// foreach (var s in args)
	// {
	// 	int a = Convert.ToInt32(s);
	// 	if(Check(a) == true)
	// {
	// 		System.Console.WriteLine("0");
	// 	}else System.Console.WriteLine("1");
	// }
	int[] nums = Array.ConvertAll(args,int.Parse);
	int a =nums.Select(n => n.ToString().Length).Where(n => n%2 == 0).Count();
	System.Console.WriteLine(a);
	int left = 0;
	int right = nums.Length -1;
	int check =0;
	while( left <= right )
	{
		if( left == right && Check(nums[left]) == true) 
		{
			check++;
		}else{

		if(Check(nums[left]) == true)	check++;
		if(Check(nums[right]) == true) check++;
		}
			left++;
		right--;

	}

	System.Console.WriteLine(check);
    }
    static bool Check(int a)
    {
	int count = 0;
	while (a > 0)
	{
		a = a /10;
		count++;
	}
	if( count % 2 ==0 )
	{
		return true;
	}
	return false;
    }
}	    
