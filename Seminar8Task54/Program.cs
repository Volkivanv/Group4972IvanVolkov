// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

static void QuickRowSort(int[,] matrix, int row, int first, int last) 
//модифицироанный метод быстрой сортировки для одного ряда матрицы
{
    int i = first;
    int j = last;
    int pivot = (first + last) / 2; //выбираем опорный элемент
    while (i < j) // идем по i с начала, по j с конца, находим слева 
    // элемент больше arr[pivot] а справа меньше и обмениваем их
    {
        while (matrix[row, i] > matrix[row, pivot]) //для сортировки по убыванию меняем знак
        {
            i++;
        }
        while (matrix[row, j] < matrix[row, pivot]) //для сортировки по убыванию меняем знак
        {
            j--;
        }
        if (i <= j)
        {
            int temp = matrix[row, i];
            matrix[row, i] = matrix[row, j];
            matrix[row, j] = temp;
            i++;
            j--;
        }
    }
    // рекурсивно применяем к массивам справа и слева от места встречи i и j
    if (first < j) QuickRowSort(matrix, row, first, j);
    if (i < last) QuickRowSort(matrix, row, i, last);
}

void MatrixRowSort(int[,] matrix) // пробегаем по рядам матрицы и сортируем каждый из них
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        QuickRowSort(matrix, i, 0, matrix.GetLength(1)-1);
    }
}

int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество строк: ");
int[,] matrix = Fill2DArray(n, m, 10, -10); // задаем матрицу
Console.WriteLine("Исходный массив:");
Print2DArray(matrix); // выводим исходный массив
Console.WriteLine("Массив с отсортированными строками:");
MatrixRowSort(matrix); //производим сортировку по рядам
//Print2DArray(matrix); // выводим отсортированный массив