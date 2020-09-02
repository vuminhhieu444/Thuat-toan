using System;
using System.Collections.Generic;

namespace thietkethuattoan
{
    class Program
    {
        public static int[] bai1()
        {
            int n;
            bool ok;
            Random r = new Random();
            do
            {
                Console.Write("\nnhap so phan tu cua mang: ");
                ok = int.TryParse(Console.ReadLine(), out n);
            } while (ok == false);
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.WriteLine(array[i]);
            }
            return array;
        }
        static void Main(string[] args)
        {
            bai1();
            Console.WriteLine("Bai 2");
            int[] array = bai1();
            Console.WriteLine("mang sau khi da sap xep");
            Quick_Sort(array, 0, array.Length-1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
