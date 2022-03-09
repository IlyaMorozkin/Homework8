// Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

void PrintArray()
{
    int[,] arr = new int[4, 4] { { 16, 24, 11, 18 }, { 47, 24, 26, 78 }, { 25, 74, 37, 20 }, { 39, 27, 98, 12 } };

    for (int i = 0; i < arr.GetLength(0); i++)
        SortRow(arr, i);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.ReadLine();
}
void SortRow(int[,] massiv, int r)
{
    for (int i = 0; i < massiv.GetLength(1); i++)
        for (int j = i + 1; j < massiv.GetLength(1); j++)
        {
            if (massiv[r, i] < massiv[r, j])
            {
                int tmp = massiv[r, i];
                massiv[r, i] = massiv[r, j];
                massiv[r, j] = tmp;
            }

        Console.WriteLine();
        }
        
}
PrintArray();
