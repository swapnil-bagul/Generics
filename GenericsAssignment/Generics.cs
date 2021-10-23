using System;

namespace GenericsAssignment
{
    class Generics
    {
        public static float FindMaxNumber(float first, float second, float third)
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
            float  maxNumber = Generics.FindMaxNumber(10.86f,33.47f,65.28f);
            Console.WriteLine("The Maximun float number is : " + maxNumber);
        }

    }
}
