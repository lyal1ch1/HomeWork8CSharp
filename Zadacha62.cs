﻿//Zadacha62
//Спиральная матрица


Console.WriteLine("Введит m:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m,n];
int[,] array2D = SpiralFillingOfMatrix(matrix, 0, 1);
PrintMatrix(array2D);

int[,] SpiralFillingOfMatrix(int[,] matrix, int startPoint, int cellValue)
{
    int value = cellValue;
    int sizeY = matrix.GetLength(0);
    int sizeX = matrix.GetLength(1);
    int size = 0;
    if (sizeY < sizeX) size = sizeY;
    else size = sizeX;

    for (startPoint = 0; startPoint <= (size+1)/2 - 1; startPoint++)
    {
        bool nextX = false;
        bool nextY = false;
        for (int x = startPoint; x < sizeX-startPoint; x++) 
        {
            matrix[startPoint,x] = value;
            value++;
        }
        for (int y = startPoint+1; y < sizeY-startPoint; y++)  
        {                                                      
            matrix[y,sizeX-startPoint-1] = value;
            value++;
            nextX = true; 
        }
        if (nextX)
        {
            for (int x = sizeX-startPoint-2; x >= startPoint; x--) 
            {
                matrix[sizeY-startPoint-1,x] = value;
                value++;
                nextY = true; 
            }
        }
        if (nextY)
        {
            for (int y = sizeY-startPoint-2; y >= startPoint+1; y--) 
            {
                matrix[y,startPoint] = value;
                value++;
            }
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
            Console.Write($"{matrix[i,j]} ");
        } 
        Console.WriteLine();               
    }
}