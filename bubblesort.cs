using System;

class Program
{
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                int temp = array[j];
                if (array[j] > array[j+1])
                {
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }

            }
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(" ", array));

        BubbleSort(array);

        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(" ", array));
    }
}
