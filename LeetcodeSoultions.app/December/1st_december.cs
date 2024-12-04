using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
    Given an array arr of integers, check if there exist two indices i and j such that :

    i != j
    0 <= i, j < arr.length
    arr[i] == 2 * arr[j]
 

    Example 1:

    Input: arr = [10,2,5,3]
    Output: true
    Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
 */
namespace LeetcodeSoultions.app.December
{
    public class _1st_december
    {
        public class Solution
        {
            public bool CheckIfExist(int[] arr)
            {
                arr = arr.OrderByDescending(x => x).ToArray();
                int n = arr.Length;
                for(int i = 0; i<n; i++)
                {
                    for(int j = i +1; j < n; j++)
                    {
                        if (arr[i] == 2 * arr[j]) return true;
                    }
                }
                return false;
            }
        }
    }
}
