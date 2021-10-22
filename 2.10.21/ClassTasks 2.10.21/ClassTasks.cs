using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClassTasks_2._10._21
{
    class ClassTasks
    {
        static void Main()
        {
            //Console.WriteLine("Task 1");
            //Console.Write("a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //SquareEquation(a, b, c);

            //Console.WriteLine("\nTask 2");
            //int element1, element2, index1, index2, temp;
            //Random rnd = new Random();
            //int[] randomarray = new int[20];
            //for (int i = 0; i < 20; i++)
            //    randomarray[i] = rnd.Next(0, 100);
            //Console.WriteLine(string.Join(", ", randomarray));
            //Console.Write("Введите первый элемент массива: ");
            //element1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите второй элемент массива: ");
            //element2 = Convert.ToInt32(Console.ReadLine());
            //index1 = Array.IndexOf(randomarray, element1);
            //index2 = Array.IndexOf(randomarray, element2);
            //temp = randomarray[index1];
            //randomarray[index1] = randomarray[index2];
            //randomarray[index2] = temp;
            //Console.WriteLine(string.Join(", ", randomarray));

            //Console.WriteLine("\nTask 3");
            //Console.Write("Введите длину массива: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //int[] array2 = new int[n];
            //for (int i = 0; i < n; i++)
            //    array2[i] = rnd.Next(0, 100);
            //Console.WriteLine("массив: " + string.Join(", ", array2));
            //for (int k = 0; k < n; k++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (array2[k] < array2[j])
            //        {
            //            int buffer = array2[k];
            //            array2[k] = array2[j];
            //            array2[j] = buffer;
            //        }
            //    }
            //}
            //Console.WriteLine("отсортированный массив: " + string.Join(", ", array2));

            //Console.WriteLine("\nTask 4");
            //int product = 0, SredArifm;
            //Console.Write("Введите длину массива: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int[] array3 = new int[count];
            //for (int l = 0; l < count; l++)
            //{
            //    Console.Write($"Введите элемент {l + 1}: ");
            //    array3[l] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(string.Join(", ", array3));
            //Console.WriteLine(Arrayy(ref product, out SredArifm, array3));

            Console.WriteLine("\nTask 5");
            try
            {
            start:
                string number = Console.ReadLine();
                Console.Clear();
                if (number == "exit" || number == "закрыть")
                {
                    Environment.Exit(0);
                }
                int intnumber = Convert.ToInt32(number);
                    switch (intnumber)
                    {
                        case 1: Console.WriteLine("\n##\n #\n #\n #\n###"); goto start;
                        case 2: Console.WriteLine("\n###\n  #\n  #\n #\n#\n###"); goto start;
                        case 3: Console.WriteLine("\n ##\n#  #\n   #\n  #\n   #\n#  #\n ##"); goto start;
                        case 4: Console.WriteLine("\n#  #\n#  #\n#  #\n####\n   #\n   #\n   #"); goto start;
                        case 5: Console.WriteLine("\n####\n#\n#\n ##\n   #\n   #\n###"); goto start;
                        case 6: Console.WriteLine("\n ##\n#  #\n#\n###\n#  #\n#  #\n ##"); goto start;
                        case 7: Console.WriteLine("\n####\n   #\n   #\n   #\n  #\n  #\n  #"); goto start;
                        case 8: Console.WriteLine("\n ##\n#  #\n#  #\n ##\n#  #\n#  #\n ##"); goto start;
                        case 9: Console.WriteLine("\n ##\n#  #\n#  #\n ###\n   #\n   #\n ##"); goto start;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.WriteLine("Ошибка: введено неправильное число."); break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка: введены некорректные данные.");
            }


            Console.ReadKey();

        }
        static void SquareEquation(int a, int b, int c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Ошибка: дискриминант < 0.");
            }
            else if (discriminant == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1} (дискриминант = 0)");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
        }
        static int Arrayy(ref int product, out int SredArifm, params int[] integers) 
        {
            int sum = 0;
            for (int i = 0; i < integers.Length; i++) //for - сумма элементов массива
                sum += integers[i];

            product = integers[0];
            for (int i = 1; i < integers.Length; i++) //for - произведение элементов массива
                product *= integers[i];

            SredArifm = sum / integers.Length; //среднее арифметическое элементов массива
                Console.Write("Произведение элементов массива: " + product + "\nСреднее арифметическое элементов" +
                    "массива: " + SredArifm + "\nСумма элементов массива: ");
            return sum;
        }
    }
}
