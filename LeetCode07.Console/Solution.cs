using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode07.Console
{
    public class Solution
    {
        public int Reverse(int x)
        {
            List<int> tmp = new List<int>();
            while (x != 0)
            {
                var i = x % 10;
                x = (x - i) / 10;
                tmp.Add(i);
            }

            long p = 0;
            foreach (var item in tmp)
            {
                p = p * 10 + item;
            }

            try
            {
                return checked((int)p);
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
