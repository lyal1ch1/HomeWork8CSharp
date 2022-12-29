﻿//Zadacha 54
//Упорядочить по убыванию строчки массива
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
int[] array = new int[m * n];
int[] MatrixToArray()
{



    int x = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[x] = matrix[i, j];
            x++;
        }


    }


    return array;
}

array = MatrixToArray();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
//PrintArray(array);
int[] newArray = new int[matrix.GetLength(1)];
void razbivkaMassiva()
{
    int i = 0;
    while (i < array.Length)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[j] = 0;
            newArray[j] = array[i];
            i++;



        }
        Array.Sort(newArray);
        Array.Reverse(newArray);
        PrintArray(newArray);
        Console.WriteLine();


    }
}
Console.WriteLine();
razbivkaMassiva();