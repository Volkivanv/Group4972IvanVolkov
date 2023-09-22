// №23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом




int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// string BuildLine(int n, int pow)
// {
//     string res = "";
//     for(int i = 1; i <= n; i++)
//     {
//         res = res + Math.Pow(i, pow)+ " ";
//     }
//     return res;
// }


void PrintResult(int n, int pow) // печатаем результат
{
    int origRow = Console.CursorTop;
    int origCol = Console.CursorLeft;
    for (int i = 1; i <= n; i++)
    {
        int ipow = Convert.ToInt32(Math.Pow(i, pow));

        // int lengthI =   Convert.ToInt32(Math.Log10(i));
        // int lengthPow = Convert.ToInt32(Math.Log10(ipow));
        Console.SetCursorPosition(origCol, origRow);
        Console.Write("| " + i + " ");

        origRow++;
        Console.SetCursorPosition(origCol, origRow);
        Console.Write("| " + ipow + " ");
        origRow--;
        origCol = Console.CursorLeft;
    }
    Console.SetCursorPosition(origCol, origRow);
    Console.Write("| ");

    origRow++;
    Console.SetCursorPosition(origCol, origRow);
    Console.Write("| ");
}

Console.Clear();
int n = ReadData("Введите число");
PrintResult(n, 3);
