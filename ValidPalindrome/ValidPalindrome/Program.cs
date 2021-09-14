using System;
using System.Text;

namespace ValidPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "`l;`` 1o1 ??;l`";
            Solution sol = new Solution();
            Console.WriteLine(sol.IsPalindrome(s));
        }
        public class Solution
        {
            public bool IsPalindrome(string s)
            {
                s = s.ToLower();
                StringBuilder sb = new StringBuilder();
                foreach(char c in s)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        sb.Append(c);
                    }
                }
                for (int i = 0; i < sb.Length/2; i++)
                {
                    int j = sb.Length -1 - i;
                    if (sb[i] != sb[j]) return false; 
                }
                return true;
            }
        }
    }
}
