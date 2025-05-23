using System;
using System.Collections.Generic;

class Array
{
    // Task 0: Create and print an array of integers of a given size
    public static int?[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int?[] arr = new int?[size];
        for (int i = 0; i < size; i++)
            arr[i] = i;

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]);
                if (i < size - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        else
        {
            // For size = 0 print blank line
            Console.WriteLine();
        }

        return arr;
    }

    // Task 1: Retrieve element at index
    public static int elementAt(int[] array, int index)
    {
        if (array == null || index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return array[index];
    }

    // Task 2: Replace element at index
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (array == null || index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        array[index] = n;
        return array;
    }

    // Task 3: Print array in reverse order
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i > 0)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

class List
{
    // Task 4: Create and print a list of integers of a given size
    public static List<int>? CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> list = new List<int>();
        for (int i = 0; i < size; i++)
            list.Add(i);

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(list[i]);
                if (i < size - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
        }

        return list;
    }

    // Task 5: Find max integer in list
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int max = myList[0];
        foreach (int val in myList)
        {
            if (val > max)
                max = val;
        }

        return max;
    }

    // Task 6: Find all multiples of 2 in a list
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();
        if (myList == null)
            return result;

        foreach (int val in myList)
        {
            result.Add(val % 2 == 0);
        }

        return result;
    }
}

// Example Main to test all the above
class Program
{
    static void Main()
    {
        // Task 0
        var arr0 = Array.CreatePrint(10);
        Console.WriteLine("Array Length: " + (arr0 == null ? 0 : arr0.Length));
        Console.WriteLine("----------------");
        arr0 = Array.CreatePrint(16);
        Console.WriteLine("Array Length: " + (arr0 == null ? 0 : arr0.Length));
        Console.WriteLine("----------------");
        arr0 = Array.CreatePrint(0);
        Console.WriteLine("Array Length: " + (arr0 == null ? 0 : arr0.Length));
        Console.WriteLine("----------------");
        arr0 = Array.CreatePrint(-10);

        // Task 1
        int[] arr1 = { 10, 17, -8, 4, -12, 7, 0, 1, -1, -9 };
        Console.WriteLine("Element at index {0} is {1}", 4, Array.elementAt(arr1, 4));
        Console.WriteLine("Element at index {0} is {1}", 9, Array.elementAt(arr1, 9));
        Console.WriteLine("Element at index {0} is {1}", 0, Array.elementAt(arr1, 0));
        Array.elementAt(arr1, -7);

        // Task 2
        int[] arr2 = { 0, 1, 2, 3, 4, 5, 6 };
        PrintArray(arr2);
        Array.ReplaceElement(arr2, 1, 98);
        PrintArray(arr2);

        // Task 3
        int[] arr3a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] arr3b = null;
        int[] arr3c = new int[0];
        int[] arr3d = { 98, -10, 0, 972, -42 };

        Array.Reverse(arr3a);
        Array.Reverse(arr3b);
        Array.Reverse(arr3c);
        Array.Reverse(arr3d);

        // Task 4
        var list4 = List.CreatePrint(10);
        Console.WriteLine("List Length: " + (list4 == null ? 0 : list4.Count));
        Console.WriteLine("----------------");
        list4 = List.CreatePrint(16);
        Console.WriteLine("List Length: " + (list4 == null ? 0 : list4.Count));
        Console.WriteLine("----------------");
        list4 = List.CreatePrint(0);
        Console.WriteLine("List Length: " + (list4 == null ? 0 : list4.Count));
        Console.WriteLine("----------------");
        list4 = List.CreatePrint(1);
        Console.WriteLine("List Length: " + (list4 == null ? 0 : list4.Count));

        // Task 5
        List<int> myList1 = new List<int>() { 98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8 };
        List<int> myList2 = new List<int>() { 98, 972, 971, -32, 972, 972, -727 };
        Console.WriteLine("Max: " + List.MaxInteger(myList1));
        Console.WriteLine("Max: " + List.MaxInteger(myList2));

        // Task 6
        var divBy2 = List.DivisibleBy2(myList1);
        foreach (bool b in divBy2)
            Console.Write(b + " ");
        Console.WriteLine();
    }

    static void PrintArray(int[] array)
    {
        if (array == null)
            return;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
