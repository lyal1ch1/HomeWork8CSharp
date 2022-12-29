﻿//Zadacga 58
//Перемножить две матрицы
Console.WriteLine("Введите m первой матрицы:");
int m1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n первой матрицы:");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите m первой матрицы:");
int m2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n первой матрицы:");
int n2 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];

int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
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
matrix1 = CreateMatrix(matrix1);
matrix2 = CreateMatrix(matrix2);

PrintMatrix(matrix1);
Console.WriteLine(" *");
PrintMatrix(matrix2);
int[,] resutMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
Console.WriteLine(" =");

int[,] MultiplyMatrix()
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            resutMatrix[i,j] +=matrix1[i,k] *matrix2[k,j];
            int x = resutMatrix[i,j];
        }
    }
}
return resutMatrix;
}

MultiplyMatrix();
PrintMatrix(resutMatrix);