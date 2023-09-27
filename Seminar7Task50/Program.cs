// №50 Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintArray (long [,] matrix)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();
    }
    }
// распечатка с цветным искомым элементом
void PrintArrayWithColorInsertion(long [,] matrix, int x, int y) 
    {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = (i == x-1 && j == y-1)? ConsoleColor.DarkYellow: ConsoleColor.Cyan;
            Console.Write(matrix[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    }
// Создание матрицы и заполнение ее числами Фибоначчи
long[,] CreateFibonacciMatrix(int n, int m) 
    {
      // Введите свое решение ниже
      long[,] array2D = new long[n, m];
      long f0 = 0;
      long f1 = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array2D[i, j] = f0;
            f0 = f1;
            f1 = f1 + array2D[i,j];
        }
    }
    return array2D;
    }
 // поиск элемента по строке и столбцу 
long[] FindNumberByPosition (long [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
      long[] result = new long[2];
      if(rowPosition < 1 || 
         rowPosition > matrix.GetLength(0)||
         columnPosition < 1||
         columnPosition > matrix.GetLength(1)){
        result[0] = 0;
        result[1] = 1;
      } else {
        result[0] = matrix[rowPosition-1, columnPosition-1];
        result[1] = 0;
      }
      return result;

    }
// вывод результата
void PrintCheckIfError (long[] results, int X, int Y)
    {
      // Введите свое решение ниже
         if(results[1]!=0) 
         {
           Console.WriteLine($"There is no such index");
         } else {
           Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
         }
    }
Console.Clear();
int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество стобцов");
long[,] arr2D = CreateFibonacciMatrix(n,m);
PrintArray(arr2D);
int x = ReadData("Введите строку X");
int y = ReadData("Введите столбец Y");
PrintArrayWithColorInsertion(arr2D,x,y);
long[] findResult = FindNumberByPosition(arr2D, x, y);
PrintCheckIfError(findResult, x, y);

