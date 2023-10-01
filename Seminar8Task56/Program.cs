// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

//Поиск ряа с минимальной суммой
int FindRowMinSum(int[,] matrix, ref int minSum)
{
    minSum = 0; // обнуляем сумму
    int rowMinSum = 0; // задаем ряд, для первого сравнения

    for (int j = 0; j < matrix.GetLength(1); j++) // накапливаем сумму его членов в minSum
    {
        minSum += matrix[rowMinSum, j];
    }

    // проходим остальные ряды 
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        //получаем сумму их членов
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        //сравниваем с предыдущей найденой минимальной
        if (rowSum < minSum)
        {
            // если меньше, то берем эту сумму как минимальную
            minSum = rowSum;
            rowMinSum = i;
        }
    }
    return rowMinSum;
}

int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество столбцов");
int[,] matrix = Fill2DArray(n, m, 10, -10); // задаем матрицу
Console.WriteLine("Исходный массив:");
Print2DArray(matrix); // выводим исходный массив
int minSum = 0;
int rowMinSum = FindRowMinSum(matrix, ref minSum); // ищем минимальные ряд и его сумму
Console.WriteLine($"Номер ряда с минимальной суммой: {rowMinSum}. Сама сумма равна {minSum}");


