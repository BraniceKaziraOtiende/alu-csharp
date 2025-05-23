﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5];

        // Initialize index [2,2] to 1
        matrix[2, 2] = 1;

        // Print the 2D array
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matrix[i, j]);
                if (j < 4)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
