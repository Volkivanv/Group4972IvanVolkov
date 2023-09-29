// Задача 55:
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
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

            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void TransponationMatrix(int[,] matrix)
{
    if(matrix.GetLength(0) == matrix.GetLength(1)){
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[j,i];
            matrix[j,i] = matrix[i,j];
            matrix[i,j] = temp;
        }

    }
    } else {
        Console.WriteLine("Эту матрицу нельзя перевернуть");
    }
}

Console.Clear();
int n = ReadData("Количество строк: ");
int m = ReadData("Количество столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] array2D = Fill2DArray(n,m,10,1);
Print2DArray(array2D);
Console.WriteLine("________________");
TransponationMatrix(array2D);
Print2DArray(array2D);