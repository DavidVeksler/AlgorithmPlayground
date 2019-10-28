using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPlayground
{
    public class StringReverse
    {
        public static string ReverseString(string a)
        {
            var b = new char[a.Length];

            int j = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b[j] = a[i];
                j++;
            }
            return  new string(b);
        }

        public static string ReverseStringV2(string a)
        {
            // cheating
            return new string(a.Reverse().ToArray());
        }


    }
}
