/*Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными 
вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
[3,3 7,1 22,5 2,2 78,2] -> 76*/

using static System.Console;
Clear();


Write("Вводим размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
ArrayRandom(array);
Write("Массив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max) max = array[z];
    if (array[z] < min) min = array[z];
}

WriteLine($"Всего {array.Length} чисел. Максимум = {max}; Минимум = {min};");
WriteLine($"Итого: = {max - min}");

void ArrayRandom(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(10,100)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Write(numbers[i] + " ");
        }
    Write("]");
    WriteLine();
}

