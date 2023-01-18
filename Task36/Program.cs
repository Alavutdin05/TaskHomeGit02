/*Задача 36: Напишите программу реализующую методы формирования массива, заполненного 
случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0*/
using static System.Console;
Clear();
WriteLine("Вводим размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
ArrayRandom(num);
WriteLine("Наш массив:");
PrintArray(num);
int sum = 0;

for (int z = 0; z < num.Length; z+=2)
    sum = sum + num[z];

    Write($" -> {sum}");

void ArrayRandom(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] number)
{
    Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Write(number[i] + " ");
        }
    Write("]");
    
}
