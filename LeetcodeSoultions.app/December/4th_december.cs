﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    2825. Make String a Subsequence Using Cyclic Increments
    Medium

    You are given two 0-indexed strings str1 and str2.

    In an operation, you select a set of indices in str1, and for each index i in the set, increment str1[i] to the next character cyclically. That is 'a' becomes 'b', 'b' becomes 'c', and so on, and 'z' becomes 'a'.

    Return true if it is possible to make str2 a subsequence of str1 by performing the operation at most once, and false otherwise.

    Note: A subsequence of a string is a new string that is formed from the original string by deleting some (possibly none) of the characters without disturbing the relative positions of the remaining characters.

    Example 1:

    Input: str1 = "abc", str2 = "ad"
    Output: true
    Explanation: Select index 2 in str1.
    Increment str1[2] to become 'd'. 
    Hence, str1 becomes "abd" and str2 is now a subsequence. Therefore, true is returned.
 */
namespace LeetcodeSoultions.app.December
{
    public static class _4th_december
    {
        public static class Solution
        {
            public static bool CanMakeSubsequence(string str1, string str2)
            {
                int m = str1.Length;
                int n = str2.Length;
                if (n > m) return false;

                int i = 0; int j = 0;
                while (i < m && j < n)
                {
                    if ((str1[i] % 26 == str2[j] % 26)
                        ||
                        ((str1[i] + 1) % 26 == str2[j] % 26))
                    {
                        j++;
                    }
                    i++;
                }
                return j == n;
            }
        }
    }
}
