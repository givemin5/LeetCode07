using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode07.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode07.Console.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void Reverse_123_ShouldBe_321()
        {
            Solution soluction = new Solution();

            var input = 123;

            var expected = 321;

            var actual = soluction.Reverse(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ReverseTest_n123_ShouldBe_n32145r()
        {
            Solution soluction = new Solution();

            var input = -123;

            var expected = -321;

            var actual = soluction.Reverse(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ReverseTest_1534236469_ShoudBe_zero()
        {
            Solution soluction = new Solution();

            var input = 1534236469;

            var expected = 0;

            var actual = soluction.Reverse(input);

            Assert.AreEqual(expected, actual);

        }
    }
}