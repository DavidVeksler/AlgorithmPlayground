using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPlayground
{
    public class StringSort
    {

        public int[] SortNumbersV1(int[] numbers)
        {
            return numbers.OrderBy(n => n).ToArray();
        }

        public int[] SortNumbersV2(int[] numbers)
        {
            throw new Exception("todo");
        }

    }
}
