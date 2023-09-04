// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите колличество строк :");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество  столбцов :");
int colums = int.Parse(Console.ReadLine()!);

Console.Clear();
int[,] matrix1 = GetArr(rows, colums, 1, 7);
Console.WriteLine("Матрица №1");
PrintArr(matrix1);
Console.WriteLine();
int[,] matrix2 = GetArr(rows, colums, 1, 7);
Console.WriteLine("Матрица №2");
PrintArr(matrix2);
Console.WriteLine();
int [,] Summa = Sum(matrix1,matrix2);
PrintArr(Summa);





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

void PrintArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Sum(int[,] matrix1, int[,] matrix2)
{
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int k = 0; k < matrix1.GetLength(1);k++)
            {
                res[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return res;
}





