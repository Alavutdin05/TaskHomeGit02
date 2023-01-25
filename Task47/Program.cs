// Задача 47. Напишите программу реализующую метод, который возвращает массив 
// размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();
Write("Введите размер столбца: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Write("Введите размер строки: ");
int number2 = Convert.ToInt32(Console.ReadLine());
double [,] array=new double[number1,number2];
GetRandom(array);                                           // Вызываем метод Random(); (double)
PrintMatrix(array);


void GetRandom (double[,] arrayIn)                         // void метод Random();
{
   
   
    for (int i = 0; i < arrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++)
        {
            arrayIn[i,j]=Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
  
}

void PrintMatrix(double [,] inArray)                       // Метод вывода
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],6}");
        }
        WriteLine();
    }
}