using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 11, 9, 34, 87, 26 };
            Generics<int> maxNum = new Generics<int>(arr);
            maxNum.PrintMaxNumber();

        }
    }
}
