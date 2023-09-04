// Задача 54: Задайте двумерный массив.     
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите колличество строк :");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество  столбцов :");
int colums = int.Parse(Console.ReadLine()!);

Console.Clear();
int[,] array = GetArr(rows, colums, 1, 10);
PrintArr(array);
Console.WriteLine();
Change(array);
PrintArr(array);




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


void Change(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}