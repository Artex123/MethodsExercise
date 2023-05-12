using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Story();
            Console.WriteLine(Sum(2, 5));
            Console.WriteLine(Subtract(7, 3));
            Console.WriteLine(Divide(10, 2));
            Console.WriteLine(Multiply(8, 5));
            Console.WriteLine(Modulus(24, 2));
        }
        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"I met someone who is named {name}, that their favorite color is {color}.  They really like the {animal} and like to listen to {band}.");

        }

        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static int Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            return sum;
        }
        public static int Divide(int num1, int num2)
        {
            int sum = num1 / num2;
            return sum;
        }
        public static int Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }
        public static int Modulus(int num1, int num2)
        {
            int sum = num1 % num2;
            return sum;
        }
    }
}
