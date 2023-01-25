// Задача 50. Напишите программу реализующую метод,принимающий позиции 
// элемента в двумерном массиве, и возвращающий значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();
int [,] array=new int [4,3];       // Сразу вводим размер столбца и строки согласно условии задачи
GetMatrix (array);
PrintMatrix(array);               // Сначала выводим метод Random(); на консоль
Write("Введите размер строки: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Write("Введите размер столбца: ");
int number2 = Convert.ToInt32(Console.ReadLine());
                      // Выполняем второе условие задачи с помощью if & else

if (number1 < array.GetLength(0) && number2 < array.GetLength(1)) WriteLine(array[number1, number2]);
else Console.WriteLine($"{number1}{number2} -> такого числа в массиве нет");



void GetMatrix (int [,] arr)      // void метод Random();
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