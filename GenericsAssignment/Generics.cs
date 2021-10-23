using System;

namespace GenericsAssignment
{
    class Generics
    {
        public static string FindMaxNumber(string first, string second, string third)
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
                return default;
            }
        }
        static void Main(string[] args)
        {
            string maxValue = Generics.FindMaxNumber("Apple","Banana","Peach");
            Console.WriteLine("The Maximun String is : " + maxValue);
        }

    }
}
