using System;
using System.Collections;

namespace GenericsAssignment
{
    class Generics<T> where T:IComparable 
    {
        
        private T[] Value;
        // constructor
        public Generics (T [] value)
        {
            this.Value  = value;
        }
        public T [] Sort1(T [] values)
        {
            Array.Sort(values);
            Console.WriteLine("the sorted array is : ");
            foreach (var element in values )
            {
                Console.WriteLine(element);
            }
            return values;
        }

        public T FindMaxNumber( params T [] values )
        {
            var sorted_values = Sort1(values);
            return sorted_values[^1];
        }
       public void PrintMaxNumber()
        {
            var max = FindMaxNumber(this.Value);
            Console.WriteLine("Maximum value is : " + max);
        }

    }
}
