// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using static System.Console;
Clear();

int [,] array1=GetRandom();
int [,] array2=GetRandom();

PrintMatrix(array1);
WriteLine();
PrintMatrix(array2);
WriteLine();

PrintMatrix(GetMatrix(array1, array2));


int[,] GetMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}


int [,] GetRandom()
{
  int [,] result = new int [2,2];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j <result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 5);
        }
    }
    return result;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Write($"{matrix[i, j],1}|");
            else Write($"{matrix[i, j],1}");
        }
        WriteLine("|");
    }
}
