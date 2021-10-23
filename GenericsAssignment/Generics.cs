using System;

namespace GenericsAssignment
{
    class Generics
    {
        public static int FindMaxNumber(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("Two or More Number are Equal");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int maxNumber = Generics.FindMaxNumber(32, 45, 60);
            Console.WriteLine("The Maximun Integer is : " + maxNumber);
        }

    }
}
