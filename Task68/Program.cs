// Задача 68: Напишите программу реализующую метод вычисления 
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

WriteLine(GetNumbers(2,3));
WriteLine(GetNumbers(3,2));


int GetNumbers(int numA, int numB)
{
    if (numA == 0) return numB + 1;
    else if (numB == 0) return GetNumbers(numA - 1, 1);
    else return GetNumbers(numA - 1, GetNumbers(numA, numB - 1));

}
