using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {

        public static bool IsAnagram(string text1, string text2)
        {
            var version1 = text1.ToCharArray();
            var version2 = text2.ToCharArray();
            Array.Sort(version1);
            Array.Sort(version2);
            return version1.ToString() == version2.ToString();
        }

        static void Main(string[] args)
        {
            string text1 = "racecar";
            string text2 = "racecar";

            var isAnagram = IsAnagram(text1, text2);
        }
    }
}
