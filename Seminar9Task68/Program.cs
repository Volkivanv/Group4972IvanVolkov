// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System.Numerics;

BigInteger ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    BigInteger num = BigInteger.Parse(Console.ReadLine() ?? "0");
    return num;
}

BigInteger Ackerman(BigInteger m, BigInteger n) // Функция Аккермана по рекурентной формуле
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

Console.Clear();
BigInteger m = ReadData("введите m"); 
BigInteger n = ReadData("введите n");
Console.WriteLine($"{Ackerman(m, n)}");