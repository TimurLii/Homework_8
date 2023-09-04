// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите колличество строк :");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов :");
int colums = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите глубину массива :");
int dep = int.Parse(Console.ReadLine()!);


int[,,] array = GetArr(rows, colums, dep);
PrintArr(array);

void PrintArr(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
// int[,,] GetArr(int m, int n, int b)
// {
//     int[,,] res = new int[rows, colums, dep];
//     int c = new Random().Next(10, 99);
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < b; k++)
//             {
//                 res[i, j, k] = c++;

//             }
//         }
//     }
//     return res;
// }

int[,,] GetArr(int m, int n, int b)
{
    int[,,] res = new int[rows, colums, dep];
    int c = new Random().Next(10, 30);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < b; k++)
            {
                while (true)
                {
                    int randomnumber = new Random().Next(10, 30);
                    if (!Find(res, randomnumber))
                    {
                        res[i, j, k] = randomnumber;
                        break;
                    }
                }
            }
        }
    }
    return res;
}

bool Find(int[,,] array, int num)
{
    bool check = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num)
                {
                    check = true;
                    break;
                }
            }
        }
    }
    return check;
}