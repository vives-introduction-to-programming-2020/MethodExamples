using System;

namespace MethodExamples
{
    class Program
    {
        public static int Add(int number1, int number2)
        {
            int sum = (number1 + number2);
            return sum;
        }

        public static int Square(int value)
        {
            int result = (value * value);
            return result;
        }

        public static string RequestUserName()
        {
            Console.WriteLine("Please enter your name: ");
            return Console.ReadLine();
        }

        public static void WelcomeUser(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        static void Main(string[] args)
        {
            int number = Add(15, 55);
            int sum = Add(12, 44);
            int totalSum = Add(number, sum);

            int square = Square(4);

            string username = RequestUserName();
            WelcomeUser(username);
        }
    }
}
