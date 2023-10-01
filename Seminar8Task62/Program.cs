// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Заполнение матрицы
int[,] Scroll2DArray(int countRow, int countColumn)
{
    int value = 1;
    int[,] array2D = new int[countRow, countColumn];
    int k = 0; //отступ
    while(value <= countColumn*countRow){

        //горизонтальный верхний ряд
        for(int j = k; j < countColumn - k - 1; j++)
        {
            array2D[k, j] = value;
            value++;
        }
        //вертикальный правый ряд
        for(int i = k; i < countRow - k - 1; i++)
        {
            array2D[i, countColumn - 1 - k] = value;
            value++;
        }
        //горизонтальный нижний ряд
        for(int j = countColumn - k - 1; j > k; j--)
        {
            array2D[countRow - 1 - k, j] = value;
            value++;
        }
        //вертикальный правый ряд
        for(int i = countRow - k - 1; i > k; i--)
        {
            array2D[i, k] = value;
            value++;
        }
        k++; //прирост отступа после прохода

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

            Console.Write(matrix[i, j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
int n = ReadData("Задайте количество строк: ");
int m = ReadData("Задайте количество столбцов: ");
int[,] scrollMatrix = Scroll2DArray(n,m); // заполняем массив по спирали
Print2DArray(scrollMatrix); //вывод спиральной матрицы
