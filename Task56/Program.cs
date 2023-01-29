// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
//  строки с наименьшей суммой элементов: 1 строка
using static System.Console;
Clear();

int [,] array=new int [4,3];       // Сразу вводим размер столбца и строки согласно условии задачи
GetRandom (array);
PrintMatrix(array);               // Сначала выводим метод Random(); на консоль


int minNumber = 0;
int count = SumNumbers(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumNumbers(array, i);
  if (count > temp)
  {
    count = temp;
    minNumber = i;
  }
}

Console.WriteLine($"\n{minNumber+1} - строкa с наименьшей суммой ({count}) элементов ");
//------------------------------------------------------

int SumNumbers(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

// -----------------------------------------------------

void GetRandom (int [,] arr)     
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

void PrintMatrix(int [,] inArray)     
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
