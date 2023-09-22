// Задача №28
// Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N
using System.Numerics;

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

BigInteger factorial(int n)
{
    BigInteger fact = 1;
    for(int i = 1; i <=n; i++){
        fact*=i;
    }
    return fact;
} 
int n = ReadData("Введите число");
Console.WriteLine("Факториал числа " + factorial(n));