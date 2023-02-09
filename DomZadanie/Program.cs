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
/*
void DiagInp(int[,] matrix)
{
    int i, j, row = 0, col = 0, n = 0;
    while (row <= matrix.GetLength(0) - 1)
    {
        i = row;
        j = col;
        while (i < matrix.GetLength(0) && j >= 0)
        {
            matrix[i++, j--] = n++;
        }
        if( col < matrix.GetLength(1) - 1) col++;
        else row++;
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int r = size[0] * size[1];
DiagInp(matrix);
PrintMatrix(matrix);

*/

// Task 1236

// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.
/*
void InputAndPrintMatrix(int[,] matrix) // заполнение массива и его вывод
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

void TransponirMatrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            temp = matrix[i, j];
            matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
            matrix[matrix.GetLength(0) - 1, j] = temp;

        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
Console.WriteLine();
TransponirMatrix(matrix);
PrintMatrix(matrix);

*/

// Task 715

// Миша негатив. найти различия в оригинале и негативе

void InputPrintPhoto(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j == 0 || i % 2 == 0 && j == 3 ) matrix[i, j] = "W";
            else matrix[i, j] = "B";
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void MakeNegativ(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j == 0 || i >= 1 && j == 3) matrix[i, j] = "B";
            else matrix[i, j] = "W";
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int ChekNegotive(string[,] matrix1, string[,] matrix2)
{
    int fault = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if( matrix1[i, j] == matrix2[i, j]) fault++;
        }
     }
     return fault;
}
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();  
string[,] Photo = new string[size[0], size[1]];
string[,] Negativ = new string[size[0], size[1]];
InputPrintPhoto(Photo);
Console.WriteLine();
MakeNegativ(Negativ);
Console.WriteLine($"Количество ошибок : {ChekNegotive(Photo, Negativ)}");
