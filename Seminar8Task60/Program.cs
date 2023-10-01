// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


// Заполнение матрицы
int[,,] Fill3DArray(int countLevel, int countRow, int countColumn)
{
    int start = new Random().Next(10, 20); //задаем начальное число
    int[,,] array3D = new int[countLevel, countRow, countColumn];
    for (int k = 0; k < countLevel; k++)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                start += new Random().Next(1, 3); //задаем случайный прирост
                array3D[k, i, j] = start;
            }
        }
    }
    return array3D;
}

//Вывод матрицы на экран
void Print3DArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        Console.WriteLine($"Слой № {k}");
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($"{matrix[k, i, j]} ({k},{i},{j}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
int k = ReadData("Задайте количество слоев: ");
int n = ReadData("Задайте количество строк: ");
int m = ReadData("Задайте количество столбцов: ");
int[,,] arr3D = Fill3DArray(k, n, m);
Console.WriteLine("Вывод трехмерной матрицы");
Print3DArray(arr3D);

