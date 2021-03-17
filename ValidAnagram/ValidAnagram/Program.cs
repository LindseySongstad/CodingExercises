using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";

            Solution sol = new Solution();
            Console.WriteLine(sol.IsAnagram0(s, t));

        }
        public class Solution
        {
            // aplphabetize both strings the check for equality
            // runtime beats 54.68%  memory usage beats 16.98%
            public bool IsAnagram0(string s, string t)
            {
                if (s.Length != t.Length) return false;
                return Alphabetize(s) == Alphabetize(t);
            }
            static string Alphabetize(string s)
            {
                char[] c = s.ToCharArray();
                Array.Sort(c);
                return new string(c);
            }
        }
    }
}
