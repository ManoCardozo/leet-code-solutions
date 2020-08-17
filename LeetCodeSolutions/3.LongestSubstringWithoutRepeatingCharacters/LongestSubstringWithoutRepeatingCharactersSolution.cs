using System.Text;
using System.Collections.Generic;

namespace LeetCodeSolutions._3.LongestSubstringWithoutRepeatingCharacters
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var str = new StringBuilder(s);
            var uniqueChars = new HashSet<char>();
            var longestLength = 0;

            while (str.Length > longestLength)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!uniqueChars.Contains(str[i]))
                    {
                        uniqueChars.Add(str[i]);
                    }
                    else
                    {
                        if (uniqueChars.Count > longestLength)
                        {
                            longestLength = uniqueChars.Count;
                        }
                        uniqueChars = new HashSet<char>();
                        str.Remove(0, 1);
                        break;
                    }
                }
            }

            return longestLength;
        }
    }
}
