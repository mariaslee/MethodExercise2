using System;

namespace MethodExercise2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(20, 25));
            Console.WriteLine(Subtract(30, 15));
            Console.WriteLine(Multiply (5,10));
            Console.WriteLine(Divide (75, 5));
        }

        public static int Add(int x, int y)
        {
            return (x + y);
        }

        public static int Subtract(int x, int y)
        {
            return (x - y);
        }
        public static int Multiply(int x,int y)
        {
            return (x * y);
        }
        public static int Divide(int x, int y)
        {
            return x / y;

        }
        
    }
        

        
}
