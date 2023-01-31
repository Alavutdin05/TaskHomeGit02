// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода 
// всех натуральных числел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

string result1 = GetSum1(5);
WriteLine(result1);

string result2 = GetSum2(8);
WriteLine(result2);

PrintNumbers(8);


string GetSum1 (int num)
{
    if (num==1) return num.ToString();
    else return $"{num},{GetSum1(num-1)}";
}

string GetSum2 (int num)                
{
    return (num==1)?num.ToString():$"{num},{GetSum2(num-1)}";
}

void PrintNumbers(int num)
{
    if(num==1) Write(num);
    else
    {
        
        Write($"{num},");
        PrintNumbers(num-1);
    }
}
