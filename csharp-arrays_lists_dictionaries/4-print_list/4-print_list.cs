using System;
using System.Collections.Generic;

public class List
{
    public static System.Collections.Generic.List<int>? CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();

        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            Console.Write(i);
            if (i < size - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
        return list;
    }
}
