// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void GenLineRec(int num)
{
    Console.Write(num + " "); // вывод
    if(num <=1) //Точка остановки
    {

    } else {
        GenLineRec(num-1); // Рекурентная формула
    }
}

int num = ReadData("Введите число N: ");
GenLineRec(num);