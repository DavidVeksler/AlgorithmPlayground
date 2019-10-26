using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AlgorithmPlayground
{
    public static class StringSortNaive1
    {
        private static string test = "zyxcba";
        public static void Sort1()
        {
            var array = test.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        //swap
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                
            }

            Debug.WriteLine(new string(array));
            Console.WriteLine(new string(array));
          //  Console.ReadKey();


        }

    }
}
