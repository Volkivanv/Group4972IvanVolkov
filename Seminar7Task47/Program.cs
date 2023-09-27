// №47 Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую 
// цифру разного цвета(цветов всего 16)

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//создается массив из вещественных чисел
double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      // Введите свое решение ниже
    double[,] array2D = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2D[i, j] = new Random().Next(minLimitRandom, maxLimitRandom) + new Random().NextDouble();
        }
    }
    return array2D;

  }

// распечатать двухмерный массив с использованием цветной печати цифр
void Print2DArray(double[, ] matrix) {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            PrintColorString(matrix[i,j].ToString("0.00"));
            Console.Write("\t");
        }
        Console.WriteLine();
    }  
  }
//печать строки, чтобы каждая буква была случайного цвета
 void PrintColorString(string inStr)
 {
     ConsoleColor[] colors = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    char[] chars = inStr.ToCharArray();
    for(int i = 0; i < chars.Length; i++){
        Console.ForegroundColor = colors[new System.Random().Next(0,16)];
        Console.Write(chars[i].ToString());
        Console.ResetColor();
    }
 }

int n = ReadData("Введите количество строк");
int m = ReadData("Введите количество стобцов");
double[,] arr = CreateRandomMatrix(n, m, -10, 10);
Print2DArray(arr);

