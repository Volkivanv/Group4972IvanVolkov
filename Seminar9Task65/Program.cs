//                                 Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// ---------------------------
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string RecMN(int n, int m)
{
    string res = string.Empty;
    if (n <= m)
    {
        return n.ToString();
    } else {
        return m.ToString() + " "+ RecMN(n, m+1);
    }
}

int m = ReadData("Введите m");
int n = ReadData("Введите n");
string result = RecMN(m, n);
Console.WriteLine(result);

