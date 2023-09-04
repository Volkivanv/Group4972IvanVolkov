// Задача №1
// Напишите программу, которая на вход принимает два числа
//  и проверяет, является ли первое число квадратом второго
Console.WriteLine("введите первое число, а потом второе");
int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
if(numA*numA == numB)
{
   Console.WriteLine("Второе число равняется квадратом первого"); 
} else {
    Console.WriteLine("Не квадрат второго");
}