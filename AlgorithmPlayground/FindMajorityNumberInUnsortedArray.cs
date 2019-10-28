using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPlayground
{
    public static class Algorithms2
    {


        public static int FindMajorityNumberInUnsortedArray(int[] array)
        {
            var dict = new Dictionary<int, int>();
            int majority = array.Length / 2;

            foreach (int i in array)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            int max = dict.Max(x => x.Value);

            if (max >= majority)
            {
                // get key of max value
                return dict.FirstOrDefault(m => m.Value == max).Key;
            }

            throw new Exception("no majority element");





        }


        public static int FindMajorityNumberInUnsortedArrayV2(int[] array)
        {
            var dict = new Dictionary<int, int>();
            int majority = array.Length / 2;

            foreach (int i in array)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                    if (dict[i] > majority)
                    {
                        return i;
                    }
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            throw new Exception("no majority element");
        }

        // try functional
        public static int FindMajorityNumberInUnsortedArrayV3(int[] array)
        {
            int majority = array.Length / 2;
            var majorityPair = array.GroupBy(x => x).FirstOrDefault(x => x.Count() > majority);

            if (majorityPair != null) return majorityPair.Key;

            throw new Exception("no majority element");
        }

        public static int FindMajorityNumberInUnsortedArrayV4(int[] array)
        {
            try
            {
                return array.GroupBy(x => x)
                    .FirstOrDefault(x => x.Count() >= array.Length / 2).Key;
            }
            catch
            {
                throw new Exception("no majority element");
            }
        }
    }
}
