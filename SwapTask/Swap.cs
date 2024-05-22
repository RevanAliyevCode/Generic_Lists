using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTask
{
    public static class Swap
    {
        public static void SwapValues<T>(ref T value, ref T value1)
        {
            (value1, value) = (value, value1);
            Console.WriteLine($"Value 1: {value}, Value 2: {value1}");
        }
    }
}
