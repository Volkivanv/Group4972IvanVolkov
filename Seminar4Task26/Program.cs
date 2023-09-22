// Задача 26:
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456
// --> 3
// 78
// --> 2
// 89126
// --> 5
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int numLength(int n)
{
    return (int)(Math.Log(n,10)+1); //проверить
}
int n = ReadData("Введите число");
Console.WriteLine(Math.Log(n,10));
Console.WriteLine("количество цифр в числе = " + numLength(n));
