// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Заполнение матрицы
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

//Вывод матрицы на экран
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

int rowOnColumn(int[,] matrix1, int[,] matrix2, int row, int column) 
// произведение одной строки на один стоблец
{
    int sum = 0;
    for(int i = 0; i < matrix1.GetLength(1); i++)
    {
        sum += matrix1[row,i]*matrix2[i,column];
    }
    return sum;
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{   //определяем размер результирующей матрицы
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rowOnColumn(matrix1, matrix2, i, j);
        }
    }
    return result;
}

Console.Clear();
int n = ReadData("Введите количество строк первой матрицы");
int m = ReadData("Введите количество столбцов первой матрицы");
int[,] matrix1 = Fill2DArray(n, m, 10, -10); // задаем первую матрицу из n строк и m столбцов
int[,] matrix2 = Fill2DArray(m, n, 10, -10); // задаем вторую матрицу, чтобы не усложнять из m строк и n столбцов
Console.WriteLine("Первая матрица: ");
Print2DArray(matrix1); // выводим первую матрицу
Console.WriteLine("Вторая матрица: ");
Print2DArray(matrix2); // выводим вторую матрицу
int[,] resMatrix = MatrixProduct(matrix1,matrix2);
Console.WriteLine("Матрица произведение: ");
Print2DArray(resMatrix); // выводим матрицу - произведение