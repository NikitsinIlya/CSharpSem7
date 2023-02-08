Console.Clear();

// Task 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void InputAndPrintMatrix(double[,] matrix) // заполнение массива и его вывод
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-99, 100 ) / 10.0); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray(); 
double[,] matrix = new double[size[0], size[1]];
InputAndPrintMatrix(matrix);
*/

// Task 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void InputAndPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
Console.Write("Введите номер строки и столбца через пробел: ");
int[] numb = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

if ( numb[0] > size[0] || numb[1] > size[1] || numb[0] <= 0 || numb[1] <= 0)
    Console.WriteLine("Такой позиции нет в массиве");
else
    Console.WriteLine($"{matrix[(numb[0 ] - 1), (numb[1] - 1)]}");
*/

// Task 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void InputAndPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void SredArifmetStolb(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int count = 0;
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j, i]; 
            count++;      
        }
        Console.Write($"{Math.Round(sum / count, 2)} \t");
    }
}
Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
Console.WriteLine();
SredArifmetStolb(matrix);
*/

// Task 364 
// Даны числа n и m. Создайте массив А[n][m] и заполните его по диагонали.

void DiagonInputAndPrintMatrix(int[,] matrix, int r)
{
    for (int k = 0; k < r - 1; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i--)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] ++;
                Console.Write($"{matrix[j, i]} \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int r = size[0]*size[1];