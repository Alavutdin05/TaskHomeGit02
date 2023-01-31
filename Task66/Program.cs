// Задача 66: Напишите программу, которая реализует рекурсивный метод 
// нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using static System.Console;
Clear();


WriteLine(GetNumbers(1,15));
WriteLine(GetNumbers(4,8));

int GetNumbers(int numA, int numB)
{
    if(numA==numB) return numA;
    else
    {
        return GetNumbers(numA, numB-1)+numB;
        
    }
}