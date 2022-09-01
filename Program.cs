// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().NextDouble() * 100;
        Console.Write($"{Math.Round(matrix[i, j], 2)} \t");
    }
    Console.WriteLine();
}





// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите позицию элемента по горизонтали: ");
int horizontalPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по вертикали: ");
int verticalPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(-10, 11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
if (horizontalPosition > rows || verticalPosition > columns)
{
    Console.WriteLine("Такого элемента в матрице нет");
}
else
{
    Console.WriteLine($"Элемент с позициями по горизонтали и вертикально {horizontalPosition} и {verticalPosition}, соответственно, равен {matrix[horizontalPosition - 1, verticalPosition - 1]}.");
}





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(-10, 11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int j = 0; j < columns; j++)
{
    double arithmeticMeanColumns = 0;
    for (int i = 0; i < rows; i++)
    {
        arithmeticMeanColumns += matrix[i, j];
    }
    arithmeticMeanColumns = Math.Round(arithmeticMeanColumns / rows, 2);
    Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {arithmeticMeanColumns}");
}