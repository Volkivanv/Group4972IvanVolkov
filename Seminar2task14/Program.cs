﻿// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()??"0");
if((n % 7 == 0) && (n % 23 == 0)){
    Console.WriteLine("Число " + n + " делится на 7 и на 23 одновременно");
} else {
    Console.WriteLine("Число " + n + "не делится на 7 и на 23 одновременно");
}