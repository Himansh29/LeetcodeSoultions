namespace LeetcodeSoultions.app.November
{
    public class Nov_2nd_String
    {
        public class Solution
        {
            public static bool IsCircularSentence(string sentence)
            {
                if (string.IsNullOrEmpty(sentence)) return false;

                string[] words = sentence.Split(' ');
                int n = words.Length;

                // handle case for single word
                if (n == 1 && sentence[0] == sentence[sentence.Length - 1])
                {
                    return true;
                }
                else if (n == 1 && sentence[0] != sentence[sentence.Length - 1]) return false;

                for (int i = 1; i < n; i++)
                {
                    if (words[i - 1][words[i - 1].Length - 1] != words[i][0]) return false;
                }

                return true;
            }
        }
    }
}