using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Введите длину массива: ");
            int count = Convert.ToInt32(Console.ReadLine());
            var array = new int[count];
            for (var i = 0; i < array.Length; ++i) //заполнение массива
            {
                Console.Write($"a[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", QuickSort(array)));

            Console.WriteLine("Task 2"); //graph





            Console.ReadKey();
        }
        static void Swap(ref int first, ref int second) //обмен элементов массива
        {
            int buffer = first;
            first = second;
            second = buffer;
        }
        static int indexx(int[] array, int minIndex, int maxIndex) //метод для определения индекса опорного элемента
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        static int[] QuickSort(int[] array) //преобразование для метода ниже
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        static int[] QuickSort(int[] array, int minIndex, int maxIndex) //Quick sort
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = indexx(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }
    }
}
