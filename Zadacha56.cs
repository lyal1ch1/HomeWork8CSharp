﻿//Zadacha 56
//Найти номер строчки, где суммма минимальная
Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
int[] arraySumMatrixLine = new int[m];
int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            arraySumMatrixLine[i] += matrix[i, j];
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
CreateMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine();

void PrintArray()
{
    Console.WriteLine("Сумма строчек массива получилась:");
    for (int i = 0; i < arraySumMatrixLine.Length; i++)
    {
        Console.Write(arraySumMatrixLine[i] + " ");
    }
}




PrintArray();
Console.WriteLine();
void MinValueOfArray(int[] array)
{
    int index = 1;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index++;
        }
    }
    Console.WriteLine("Минимальная сумма в строчке: " + index);
}
MinValueOfArray(arraySumMatrixLine);
//////////////////////////////////////////////////////////////////////////////////