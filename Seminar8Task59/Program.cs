// Задача 59:
// Задайте двумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMinElm(int[,] matrix, ref int x, ref int y)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                x = i;
                y = j;
            }
        }

    }
}

int[,] DeleteCross(int[,] matrix, int x, int y)
{
    int[,] res = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != x)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != y)
                {
                    res[m, n] = matrix[i, j];
                    n++;
                }
            }
            m++;
        }
        n = 0;
    }
    return res;
}
Console.Clear();
int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество столбцов");
int[,] arr2D = Fill2DArray(m, n, 10, -10);
Print2DArray(arr2D);
int x = 0; int y = 0;
FindMinElm(arr2D, ref x, ref y);
Console.WriteLine("///////////////////////////");
Console.WriteLine($"x : {x}, y : {y}, {arr2D[x, y]}");
Console.WriteLine("///////////////////////////");
var arr2Dnew = DeleteCross(arr2D, x, y);
Print2DArray(arr2Dnew);