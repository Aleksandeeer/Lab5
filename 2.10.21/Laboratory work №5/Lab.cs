using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work__5
{
    class Lab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5.1");
            Console.Write("1 число: ");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 число: ");
            int digit2 = Convert.ToInt32(Console.ReadLine());
            thegreaterofthetwo(digit1, digit2);

            Console.WriteLine("\nTask 5.2");
            try
            {
                Console.Write("a = ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int second = Convert.ToInt32(Console.ReadLine());
                swipe(ref first, ref second);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введена строка.");
            }

            Console.WriteLine("\nTask 5.3");
            Console.Write("Введите число: !");
            int factorial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factor(ref factorial));

            Console.WriteLine("\nTask 5.4");
            Console.Write("Введите число: !");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал вычислен: " + recursivefactorial(number));

            Console.WriteLine("\nHomeTask 5.1");
            Console.Write("Введите 1 число: ");
            int firstchsilo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1 число: ");
            int secondchsilo = Convert.ToInt32(Console.ReadLine());
            Console.Write("НОД = " + NOD(firstchsilo, secondchsilo));

            Console.WriteLine("\nHomeTask 5.2");
            Console.Write("Введите номер числа Фибоначии: ");
            int numberFib = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначчи: " + Fib(numberFib - 1));

            Console.ReadKey();
        }
        static void thegreaterofthetwo(int x, int y)
        {
            if (x > y)
                Console.WriteLine($"{x} > {y}");
            else if (x == y)
                Console.WriteLine($"{y} = {x}");
            else
                Console.WriteLine($"{y} < {x}");
        }
        static void swipe(ref int a, ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;
            Console.WriteLine($"a = {a}, b = {b}");
        }
        static bool factor(ref int n)
        {
            try
            {
                int proizved = 1;
                for (int i = 1; i < (n + 1); i++)
                {
                    checked
                    {
                        proizved *= i;
                    }
                }
                Console.WriteLine("Факториал вычислен: " + proizved);
                return true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: переполнение стека.");
                return false;
            }
        }
        static int recursivefactorial(int number)
        {
            if (number == 0) 
                return 1;
            return number * recursivefactorial(number - 1);
        }
        static int NOD(int smallestfirst, int smallestsecond)
        {
            while ((smallestfirst != 0) && (smallestsecond != 0))
            {
                if (smallestfirst > smallestsecond)
                    smallestfirst -= smallestsecond;
                else
                    smallestsecond -= smallestfirst;
            }
            return Math.Max(smallestfirst, smallestsecond);
        }
        public static int Fib(int n)
        {
            int sum = 0;
            if (n <= 1) return n;
            int[] integers = new int[n];
            sum = Fib(n - 2) + Fib(n-1);
            return sum;
        }

    }

}
