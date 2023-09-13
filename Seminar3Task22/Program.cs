// Задача 22:
// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5
// --> 1, 4, 9, 16,
// 2
// --> 1,4

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string BuildLine(int n, int pow)
{
    string res = "";
    for(int i = 1; i <= n; i++)
    {
        res = res + Math.Pow(i,pow)+ " ";
    }
    return res;
}


void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int n = ReadData("Введите число");
PrintResult(BuildLine(n, 2));