using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  You are given a 0-indexed string s and a 0-indexed integer array spaces that describes the indices in the original string where spaces will be added. Each space should be inserted before the character at the given index.

    For example, given s = "EnjoyYourCoffee" and spaces = [5, 9], we place spaces before 'Y' and 'C', which are at indices 5 and 9 respectively. Thus, we obtain "Enjoy Your Coffee".
    Return the modified string after the spaces have been added.

 

    Example 1:

    Input: s = "LeetcodeHelpsMeLearn", spaces = [8,13,15]
    Output: "Leetcode Helps Me Learn"
    Explanation: 
    The indices 8, 13, and 15 correspond to the underlined characters in "LeetcodeHelpsMeLearn".
    We then place spaces before those characters. 
 */

namespace LeetcodeSoultions.app.December
{
    public static class _3rd_december
    {
        public static class Solution
        {
            public static string AddSpaces(string s, int[] spaces)
            {
                StringBuilder result = new StringBuilder();
                int m = s.Length;
                int n = spaces.Length;
                int j = 0;

                for(int i = 0; i<m; i++)
                {
                    if(j < n && i == spaces[j])
                    {
                        result.Append(" ");
                        j++;
                    }

                    result.Append(s[i]);
                }

                return result.ToString();
            }
        }
    }
}
