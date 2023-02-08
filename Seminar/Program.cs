Console.Clear();
// Task46
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
void InputAndPrintMatrix(int[,] matrix) // заполнение массива и его вывод
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t"); // \t добавляет табуляцию и выравнивает вывод массива
        }
        Console.WriteLine();
    }
}



Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();  // Ввод значений в 1 строку через пробел.Split разделяет элементы Select берет каждый элемент и делает из него int. а после преобразовывает в array
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);

*/

// Task 48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
void InputAndPrintMatrix(int[,] matrix) // заполнение массива и его вывод
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} \t"); // \t добавляет табуляцию и выравнивает вывод массива
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();  // Ввод значений в 1 строку через пробел.Split разделяет элементы Select берет каждый элемент и делает из него int. а после преобразовывает в array
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
*/
// Task49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
/*
void InputAndPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void PowIndexElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j % 2 == 1 && j % 2 == 1) 
                matrix[i, j] *= matrix[i, j];
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
Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
Console.WriteLine();
PowIndexElement(matrix);
PrintMatrix(matrix);
*/

// Task 51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void InputAndPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int SummaDiagonali(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j) sum = sum + matrix[i, j];
            }
        }
    }
    return sum;
}

Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputAndPrintMatrix(matrix);
Console.WriteLine($"Сумма элементов главной диаганали : {SummaDiagonali(matrix)}");
