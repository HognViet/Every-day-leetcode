namespace Bai14_Longest_common_prefix;

class Program
{
    public static string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0 || strs == null) return "";
        String ss = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(ss))
            {
                ss = ss.Substring(0,ss.Length-1);
                if( ss == "") return "";
            }
        }
        return ss;
    }
    static void Main(string[] args)
    {
        String[] strs = {"flo", "flower", "flyy"};
        String ss = LongestCommonPrefix(strs);
        System.Console.WriteLine(ss);

    }
}
