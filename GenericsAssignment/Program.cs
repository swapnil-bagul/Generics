using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //create object and passed parameter in constructor
            Generics<int> intMax = new Generics<int>(23, 45, 62);
            Console.WriteLine("The Maximum Integer is : " + intMax.FindMaxNumber());

            Generics<float> floatMax = new Generics<float>(48.7f,86.29f,84.67f);
            Console.WriteLine("The Maximum float is : " + floatMax.FindMaxNumber());

            Generics<string> stringMax = new Generics<string>("Apple","Banana","Peach");
            Console.WriteLine("The Maximum Integer is : "+stringMax.FindMaxNumber());

        }
    }
}
