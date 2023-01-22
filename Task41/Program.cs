/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
using static System.Console;
Clear();
Write("Введите размер массива: ");
int array = int.Parse(ReadLine()!);

WriteLine("Введите числа:");
int [] number = GetNumbers(array);
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i]>0)count++;
    }
    
WriteLine($"Сумма чисел больше нуля {count}");

int [] GetNumbers (int size)
{
    int [] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = int.Parse(ReadLine()!);
    }
    return res;
}