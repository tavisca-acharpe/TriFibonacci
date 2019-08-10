using System;
using Xunit;
using TriFibonacci;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        TriFibonacci1 t = new TriFibonacci1();
        [Fact]
        public void Test1()
        {
            Assert.Equal(6, t.Complete(new int[] { 1, 2, 3, -1 }));
        }

        [Fact]
        public void Test2()
        {

            Assert.Equal(110, t.Complete(new int[] { 10, 20, 30, 60, -1, 200 }));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(-1, t.Complete(new int[] { 1, 2, 3, 5, -1 }));

        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(-1, t.Complete(new int[] { 1, 1, -1, 2, 3 }));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(999985, t.Complete(new int[] { -1, 7, 8, 1000000 }));
        }

    }
}
