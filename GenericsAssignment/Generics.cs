using System;
using System.Collections;

namespace GenericsAssignment
{
    class Generics<T> where T:IComparable 
    {
        //instance variable
        private T first, second, third;
        // constructor
        public Generics (T first,T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public T FindMaxNumber()
        {
            //finding maximum number by using CompareTo() method
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
       

    }
}
