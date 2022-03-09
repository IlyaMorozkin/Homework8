// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[,] arr = new int[5, 4] { { 16, 79, 99, 18 }, { 47, 24, 26, 78 }, { 25, 74, 37, 20 }, { 39, 27, 98, 12 }, { 35, 46, 73, 23 } };
int sumOneLine = 0;
int sumTwoLine = 1;
int sumThreeLine = 2;
int sumForLine = 3;
int sumFiveLine = 4;
int sum = 0;
void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int SumArray(int r)
{
    sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[r, j];
    }
    return sum;
}


PrintArray();
SumArray(sumOneLine);
sumOneLine = sum;

SumArray(sumTwoLine);
sumTwoLine = sum;

SumArray(sumThreeLine);
sumThreeLine = sum;

SumArray(sumForLine);
sumForLine = sum;

SumArray(sumFiveLine);
sumFiveLine = sum;

Console.WriteLine($"Сумма первой строки = {sumOneLine}");
Console.WriteLine($"Сумма второй строки = {sumTwoLine}");
Console.WriteLine($"Сумма третьей строки = {sumThreeLine}");
Console.WriteLine($"Сумма четвертой строки = {sumForLine}");
Console.WriteLine($"Сумма пятой строки = {sumFiveLine}");

int min = sumOneLine;
if (min > sumTwoLine)
    min = sumTwoLine;
if (min > sumThreeLine)
    min = sumThreeLine;
if (min > sumForLine)
    min = sumForLine;
if (min > sumFiveLine)
    min = sumFiveLine;
Console.WriteLine($"Наименьшая сумма элементов строки в матрице = {min}");
