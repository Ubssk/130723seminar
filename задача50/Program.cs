// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
}
Console.Write("Введите позицию искомого элемента (номер строки и колонки без пробела): ");
string numberString = Console.ReadLine();
void IndexOutput (int[,] matrix)
{
    int[] array = new int[numberString.Length];
    if (numberString.Length==2)
    {
        for (int i = 0; i < numberString.Length; i++)
        {
            array[i] = int.Parse(numberString[i].ToString());
        }
        int row=array[0];
        int col=array[1];
        if (row>rows || col>columns)
        {
            Console.WriteLine("Числа с данной позицией в массиве нет");
        }
        else
        {
            Console.WriteLine(matrix[row,col]);
        }
    }
    else
    {
        Console.WriteLine("Нужно двузначное число");
        return;
    }
}
IndexOutput (array2D);