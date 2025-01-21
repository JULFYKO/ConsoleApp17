﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp17
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = rnd.Next(-100, 101);

            int min = matrix[0, 0], max = matrix[0, 0], minIndex = 0, maxIndex = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minIndex = i * 5 + j;
                    }
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxIndex = i * 5 + j;
                    }
                }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);
            int sum = 0;
            for (int i = start + 1; i < end; i++)
                sum += matrix[i / 5, i % 5];

            Console.WriteLine($"Sum between min and max: {sum}");
        }
    }
}