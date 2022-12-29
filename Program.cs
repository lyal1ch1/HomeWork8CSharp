//Zadacha 54
// Упорядочить по убыванию строчки массива
// Console.WriteLine("Введите m:");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n:");
// int n = int.Parse(Console.ReadLine()!);
// int[,] matrix = new int[m, n];
// int[] arraySumMatrixLine = new int[m];
// int[,] CreateMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11);
//             arraySumMatrixLine[i] += matrix[i, j];
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// CreateMatrix(matrix);
// PrintMatrix(matrix);

// Console.WriteLine();
// int[] array = new int[m * n];
// int[] MatrixToArray()
// {



//     int x = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[x] = matrix[i, j];
//             x++;
//         }


//     }


//     return array;
// }

// array = MatrixToArray();

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// //PrintArray(array);
// int[] newArray = new int[matrix.GetLength(1)];
// void razbivkaMassiva()
// {
//     int i = 0;
//     while (i < array.Length)

//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newArray[j] = 0;
//             newArray[j] = array[i];
//             i++;



//         }
//         Array.Sort(newArray);
//         Array.Reverse(newArray);
//         PrintArray(newArray);
//         Console.WriteLine();


//     }
// }
// Console.WriteLine();
// razbivkaMassiva();


// //Zadacha 56
// //Найти номер строчки, где суммма минимальная
// Console.WriteLine("Введите m:");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n:");
// int n = int.Parse(Console.ReadLine()!);

// int[,] matrix = new int[m, n];
// int[] arraySumMatrixLine = new int[m];
// int[,] CreateMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11);
//             arraySumMatrixLine[i] += matrix[i, j];
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// CreateMatrix(matrix);
// PrintMatrix(matrix);

// Console.WriteLine();

// void PrintArray()
// {
//     Console.WriteLine("Сумма строчек массива получилась:");
//     for (int i = 0; i < arraySumMatrixLine.Length; i++)
//     {
//         Console.Write(arraySumMatrixLine[i] + " ");
//     }
// }




// PrintArray();
// Console.WriteLine();
// void MinValueOfArray(int[] array)
// {
//     int index = 1;
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//             index++;
//         }
//     }
//     Console.WriteLine("Минимальная сумма в строчке: " + index);
// }
// MinValueOfArray(arraySumMatrixLine);
////////////////////////////////////////////////////////////////////////////////////
//Zadacga 58
//Перемножить две матрицы
// Console.WriteLine("Введите m первой матрицы:");
// int m1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n первой матрицы:");
// int n1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите m первой матрицы:");
// int m2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n первой матрицы:");
// int n2 = int.Parse(Console.ReadLine()!);

// int[,] matrix1 = new int[m1, n1];
// int[,] matrix2 = new int[m2, n2];

// int[,] CreateMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// matrix1 = CreateMatrix(matrix1);
// matrix2 = CreateMatrix(matrix2);

// PrintMatrix(matrix1);
// Console.WriteLine(" *");
// PrintMatrix(matrix2);
// int[,] resutMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
// Console.WriteLine(" =");

// int[,] MultiplyMatrix()
// {
// for (int i = 0; i < matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix2.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix1.GetLength(1); k++)
//         {
//             resutMatrix[i,j] +=matrix1[i,k] *matrix2[k,j];
//             int x = resutMatrix[i,j];
//         }
//     }
// }
// return resutMatrix;
// }

// MultiplyMatrix();
// PrintMatrix(resutMatrix);

// Zadacha 60
// Трехмерный массив
Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z:");
int z = int.Parse(Console.ReadLine()!);

int arraySize = m * n * z;
if (arraySize > 90) 
{
    Console.WriteLine($"Невозможно создать массив из неповотряющихся двухзачных чисел!");
}
else
{
    //int[] uniqArray2D = UniqRandomValues();
    int[,,] Matrix3D = Generator3DMatrix(m, n, z, 10, 99); 
    PrintElemetsOfArray(Matrix3D);
}

int[] UniqTwoDigitRandomValues()
{
    int[] maskForArrayIndex = new int[90];
    int[] uniqRandomArray = new int[90];

    for (int i = 0; i < maskForArrayIndex.Length; i++)
    {
        maskForArrayIndex[i] = new Random().Next(10, 100);
    }

    for (int i = 10; i < 100; i++)
    {
        uniqRandomArray[i-10] = i;
    }

    int temp1 = 0;
    int temp2 = 0;
    for (int i = 0; i < maskForArrayIndex.Length-1; i++)
    {
        for (int j = i + 1; j < uniqRandomArray.Length; j++)
        {
            if (maskForArrayIndex[i] > maskForArrayIndex[j])
            {
                temp1 = maskForArrayIndex[i];
                temp2 = uniqRandomArray[i];
                maskForArrayIndex[i] = maskForArrayIndex[j];
                uniqRandomArray[i] = uniqRandomArray[j];
                maskForArrayIndex[j] = temp1;
                uniqRandomArray[j] = temp2;
            }
        }
    }
    return uniqRandomArray;
}

int[,,] Generator3DMatrix(int x, int y, int z, int min, int max)
{
    int row = x;
    int col = y;
    int deep = z;
    int arrayIndex = 0;
    int[] maskForArrayFilling = UniqTwoDigitRandomValues();
    int[,,] array3D = new int[row,col,deep];
      
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i,j,k] = maskForArrayFilling[arrayIndex];
                arrayIndex++;
            }            
        }        
    }
    return array3D;
}

void PrintElemetsOfArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {    
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine("");
        } 
        Console.WriteLine();        
    }
}
// //Zadacha62
// //Спиральная матрица


// Console.WriteLine("Введит m:");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите n:");
// int n = int.Parse(Console.ReadLine()!);

// int[,] matrix = new int[m,n];
// int[,] array2D = SpiralFillingOfMatrix(matrix, 0, 1);
// PrintMatrix(array2D);

// int[,] SpiralFillingOfMatrix(int[,] matrix, int startPoint, int cellValue)
// {
//     int value = cellValue;
//     int sizeY = matrix.GetLength(0);
//     int sizeX = matrix.GetLength(1);
//     int size = 0;
//     if (sizeY < sizeX) size = sizeY;
//     else size = sizeX;

//     for (startPoint = 0; startPoint <= (size+1)/2 - 1; startPoint++)
//     {
//         bool nextX = false;
//         bool nextY = false;
//         for (int x = startPoint; x < sizeX-startPoint; x++) 
//         {
//             matrix[startPoint,x] = value;
//             value++;
//         }
//         for (int y = startPoint+1; y < sizeY-startPoint; y++)  
//         {                                                      
//             matrix[y,sizeX-startPoint-1] = value;
//             value++;
//             nextX = true; 
//         }
//         if (nextX)
//         {
//             for (int x = sizeX-startPoint-2; x >= startPoint; x--) 
//             {
//                 matrix[sizeY-startPoint-1,x] = value;
//                 value++;
//                 nextY = true; 
//             }
//         }
//         if (nextY)
//         {
//             for (int y = sizeY-startPoint-2; y >= startPoint+1; y--) 
//             {
//                 matrix[y,startPoint] = value;
//                 value++;
//             }
//         }
//     }
    
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         } 
//         Console.WriteLine();               
//     }
// }
