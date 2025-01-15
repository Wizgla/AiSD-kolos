using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static List<int> Quicksort(List<int> list)
    {
        if(list.Count <= 1) {  return list; }

        int pivot = list[0];

        var left = list.Where(x => x < pivot).ToList();
        var right = list.Where(x => x > pivot).ToList();
        var center = list.Where(x => x == pivot).ToList();
        
        return Quicksort(left).Concat(center).Concat(Quicksort(right)).ToList();
    }
    static void Main(string[] args)
    {
        var list = new List<int> { 7, 6, 10, 9, 8, 3, 4, 1 };

        Console.WriteLine("Исходный список:");
        Console.WriteLine(string.Join(", ", list));

        var sortedList = Quicksort(list);

        Console.WriteLine("Отсортированный список:");
        Console.WriteLine(string.Join(", ", sortedList));
    }
}
