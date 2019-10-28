using System;
using System.Collections.Specialized;
using AlgorithmPlayground;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        private int[] unsortedNumbers = { 1, 2, 3, 4, 5, 2, 2, 2, 2 };

        private string helloWorld = "hello world";

        [Fact]
        public void Test1()
        {
           var result= Algorithms2.FindMajorityNumberInUnsortedArray(unsortedNumbers);
           Xunit.Assert.Equal(2,result);

        }

        [Fact]
        public void Test2()
        {
            var result = Algorithms2.FindMajorityNumberInUnsortedArrayV2(unsortedNumbers);
            Xunit.Assert.Equal(2, result);

        }

        [Fact]
        public void Test3()
        {
            var result = Algorithms2.FindMajorityNumberInUnsortedArrayV3(unsortedNumbers);
            Xunit.Assert.Equal(2, result);

        }

        [Fact]
        public void Test4()
        {
            var result = Algorithms2.FindMajorityNumberInUnsortedArrayV4(unsortedNumbers);
            Xunit.Assert.Equal(2, result);

        }

        [Fact]
        public void Test5()
        {
            var result = StringReverse.ReverseString(helloWorld);
            Xunit.Assert.Equal(result, "dlrow olleh");

        }

        [Fact]
        public void Test6()
        {
            var result = StringReverse.ReverseStringV2(helloWorld);
            Xunit.Assert.Equal(result, "dlrow olleh");

        }
    }
}
