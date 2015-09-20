using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sorts
{
    public class Program
    {
        public void Main(string[] args)
        {
            int[] arr = GetUnsortedArray();

            StupidSort(arr);

            PrintArr(arr);
            Console.Read();
        }


        // 1
        static void SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int minPosition = i;
                for (int j = i; j < data.Length; j++)
                {
                    if (data[minPosition] > data[j])
                    {
                        minPosition = j;
                    }
                }
                if (minPosition != i)
                {
                    int t = data[minPosition];
                    data[minPosition] = data[i];
                    data[i] = t;
                }
            }
        }

        // 2
        static void InsertionSort(int[] data)
        {
            for (var i = 1; i < data.Length; i++)
            {
                var j = i;
                var last = data[i];
                for (; j > 0 && last < data[j - 1]; j--)
                {
                    data[j] = data[j - 1];
                }
                data[j] = last;
            }
        }

        // 3
        static void BubleSort(int[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                for (var j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        Swap(data, j, j + 1);
                    }
                }
            }
         }

        // 4
        static void QuickSort(int[] data, int start, int end)
        {
            int temp;
            int x = data[end];

            int i = start;
            int j = end;

            while (i <= j)
            {
                while (data[i] < x) i++;
                while (data[j] > x) j--;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < end)
                QuickSort(data, i, end);

            if (start < j)
                QuickSort(data, start, j);
        }

        // 5 
        static int[] StupidSort(int[] data)
        {
            int i = 0;
            while(i < data.Length - 1)
            {
                if(data[i] > data[i + 1])
                {
                    Swap(data, i, i + 1);
                    i = 0;   
                }
                i++;
            }
            return data;
        }






        static int[] GetUnsortedArray()
        {
            int min = -10;
            int max = 10;
            int[] arr = new int[10];
            Random generator = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = generator.Next(min, max);
            }
            return arr;
        }

        static void PrintArr(int[] data)
        {
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static void Swap(int[] data, int i, int j)
        {
            int c = data[i];
            data[i] = data[j];
            data[j] = c;
        }
    }
}
