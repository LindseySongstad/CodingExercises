using System;
using System.Collections.Generic;

namespace FirstUniqueCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string str = "letcode";

            Console.WriteLine(s.FirstUniqChar1(str));


        }
        
        
        public class Solution
        {
            // exceeded time limit
            public int FirstUniqChar0(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    bool dup = false;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (i == j) continue;
                        if (s[i] == s[j]) dup = true;
                    }
                    if (dup == false) return i;
                }
                return -1;
            }

            public int FirstUniqChar1(string s)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i])) dict[s[i]] += 1;
                    else dict.Add(s[i], 1);
                }

                foreach(KeyValuePair<char, int> kvp in dict)
                {
                    if(kvp.Value == 1)
                    {
                        return s.IndexOf(kvp.Key);
                    }
                }
                return -1;
            }
        }
    }
}
