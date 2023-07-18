// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int minRandom = 0;
int maxRandom = 10;
int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
PrintMatrix(array2D);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sumColumns = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumColumns += matrix[j, i];
        }
        
        Console.Write(Math.Round(sumColumns / matrix.GetLength(0), 2));
        Console.Write("; ");
    }
}
