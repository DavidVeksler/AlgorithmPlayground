using System;
namespace AlgorithmPlayground
{
    public class CountNumbers
    {
        public int CountNumbersInString(string s)
        {
            int total = 0;
            string cn = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Convert.ToInt32(s[i]) > 0)
                {
                    cn += s[i];
                }
                else
                {
                    total += Convert.ToInt32(cn);
                    cn = "";
                }
            }
            return total;
        }
    }
}

