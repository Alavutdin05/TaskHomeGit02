// Задача 52. Напишите программу реализующую методы, 
//формирования двумерного массива и 
//массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
Write("Введите размер строки: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Write("Введите размер столбца: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int [,] array=new int [number1,number2];
GetRandom (array);
PrintMatrix(array);       // Сами вводим размер столбца и строки массива и вызываем метод Random();
WriteLine();
GetFormula (array);       // Вызываем второй void метод решения задачи


void GetFormula (int [,] arr) 
{
float []sum=new float [arr.GetLength(1)];
for (int i=0; i<arr.GetLength(1); i++)
{
    for(int j=0; j<arr.GetLength(0); j++)
    {
        sum[i] += arr[j,i];
    }
    //Write(sum[i]+"  ");  Узнаем ответ полученный с помощью формулы
}
Write("Среднее арифметическое каждого столбца: ");
for (int i=0; i<arr.GetLength(1); i++)
{
    Write($"{(sum[i] / arr.GetLength(0)):f2}"  + " "); // Выводим формулу среднее арифметическое значение
}                // Согласно второй практики с помощью :f2 округляем полученный ответ  
}


void GetRandom(int [,] arr)
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