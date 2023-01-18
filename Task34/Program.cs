/*Задача 34: Напишите программу реализующую 
методы формирования массива, заполненного 
случайными положительными трёхзначными числами, 
и подсчета количества чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

using static System.Console;
Clear();
int [] array = GetArray(3);
PrintArray(array);

int count = 0;

for (int z = 0; z < array.Length; z++)
{
if (array[z] % 2 == 0) count++;
}

WriteLine($"{count}");
int[] GetArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(100, 1000);
        
    }
    return result;
}



void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
    WriteLine($"{array[array.Length - 1]}]");
}


