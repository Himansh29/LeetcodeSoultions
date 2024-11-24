using System.Text;

namespace LeetcodeSoultions.app.November
{
    public class Nov_1st_String
    {
        public class Solution
        {
            public static string MakeFancyString(string s)
            {
                StringBuilder output = new StringBuilder();
                output.Append(s[0]);

                int freq = 1;
                int n = s.Length;

                for (int i = 1; i < n; i++)
                {
                    // happy case
                    if (s[i] == output[output.Length - 1])
                    {
                        output.Append(s[i]);
                        freq++;
                    }
                    // if a new char comes in
                    else
                    {
                        output.Append(s[i]);
                        freq = 1;
                    }

                    // if the freq == 3
                    if (freq > 2)
                    {
                        output.Remove(output.Length - 1, 1);
                        freq--;
                    }
                }
                s = output.ToString();
                return s;
            }
        }
    }
}