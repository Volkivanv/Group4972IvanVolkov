
// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SumInRange(int m, int n)
{
    if(m > n) // если m > n, то меняем местами
    {
        int temp = m;
        m = n;
        n = temp;
    }

   if(n > m) {  // если m < n то вызываем рекурентную формулу.
    return n + SumInRange(m, n-1); 
   } else { // точка останова - когда n сравнялась с m
    return m;
   }
}

int m = ReadData("Введите нижнюю границу M");
int n = ReadData("Введите верхнюю границу N");
Console.WriteLine($"Сумма целых чисел в промежутке от M до M составляет {SumInRange(m, n)}");