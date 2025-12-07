namespace Bai50_Pow;

class Program
{
    static double Pow(double x, int n)
    {
        if( n == 0 || x ==1 ) return 1;
        if(x == -1 && n == int.MinValue) 
        {
            if( Math.Abs((long)n) % 2 == 0) return -x;
            else return x;
        }
        if( n == int.MinValue) return 0;
        if(x == -1 || (x == -1 && n == int.MinValue) )
        {
            if( Math.Abs((long)n) % 2 == 0) return -x;
            else return x;
        }
        double temp = x;
        int temp1 =n;
        if( n < 0)
        {
            temp1 = -n;
        }
        for (int i = 1; i < temp1; i++)
        {
            x = x *temp;
        }
        if( n < 0)
        {
            x = 1 /x;
        }
        return x;
    }
    static void Main(string[] args)
    {
        double result = Pow(-1, -2147483648);
        System.Console.WriteLine(result);
        Console.WriteLine("Hello, World!");
        System.Console.WriteLine(int.MaxValue);
        System.Console.WriteLine(int.MinValue);
    }
}
