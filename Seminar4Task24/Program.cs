// See https://aka.ms/new-console-template for more information

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int sumNumber(int n)
{
    return n*(n+1)/2;
}
int n = ReadData("Введите число");
Console.WriteLine("Сумма чисел от 1 до N = " + sumNumber(n));
