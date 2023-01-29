// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();


int [,] array=new int [4,3];       // Сразу вводим размер столбца и строки согласно условии задачи
GetRandom (array);
PrintMatrix(array);               // Сначала выводим метод Random(); на консоль
WriteLine();
GetFormula (array);               // Выводим метод
PrintMatrix(array);

void GetFormula (int [,] inArray) // Метод сортировки по убыванию
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(1)-1; k++)
            {
                if (inArray[i,k]<inArray[i,k+1])
                {
                    int temp= inArray[i,k+1];
                    inArray[i,k+1]=inArray[i,k];
                    inArray[i,k]=temp;
                }
            }
        }
    }
}

void GetRandom (int [,] arr)      // void метод Random();
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=rnd.Next(0,10);
        }
    }
    
}

void PrintMatrix(int [,] inArray)     // Метовы вывода Random();
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],3}");
        }
        WriteLine();
    }
}
