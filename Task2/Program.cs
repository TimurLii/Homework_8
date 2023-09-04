// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите колличество строк :");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество  столбцов :");
int colums = int.Parse(Console.ReadLine()!);

Console.Clear();
int[,] array = GetArr(rows, colums, 1, 10);
PrintArr(array);
Console.WriteLine();
Sum(array);

int[,] GetArr(int m, int n, int min, int max)
{
    int[,] res = new int[rows, colums];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(min, max);
        }
    }
    return res;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void Sum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }

    int min = sum[0];
    int index = 0;
    {
        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[i] < min)
            {
                min = sum[i];
                index = i;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {index}, сумма которых равна {min}");
}
