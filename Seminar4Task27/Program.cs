// №27 Напишите программу, которая принимает на
//  вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма 
// через вещественные числа и строки

long ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    long num = long.Parse(Console.ReadLine() ?? "0");
    return num;
}

int DigitSumInt(long number) // считаем через целые числа
{
    int digitSum = 0;
    while(number > 0)
    {
        digitSum += (int)(number % 10);
        number/=10;
    }
    return digitSum;
}

int DigitSumChar(long number) // сумма цифр через Char
{
    int sumNum = 0;
    char[] cNum = number.ToString().ToCharArray();
    for(int i = 0; i < cNum.Length; i++)
    {
        sumNum+=cNum[i] - '0';
    }
    return sumNum;
}

long number = ReadData("Введите число");
DateTime date1 = DateTime.Now;
int sumDigitInt = DigitSumInt(number);
DateTime date2 = DateTime.Now;
int sumDigitChar = DigitSumChar(number);
DateTime date3 = DateTime.Now;
Console.WriteLine($"Через операции с Int: сумма цифр числа {number} составляет {sumDigitInt}. Время работы {date2 - date1}");
Console.WriteLine($"Через операции с Char: сумма цифр числа {number} составляет {sumDigitChar}. Время работы {date3 - date2}");