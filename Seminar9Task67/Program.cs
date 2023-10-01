//                                 Задача 67
// примает на вход число и возвращает сумму цифр
//

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int digitSum(int num)
{
    int sum = 0;
    if(num > 0)
    {
    return sum = digitSum(num/10)+num%10;
    } else return 0;

}

int num = ReadData("Введите число");
Console.WriteLine($"Сумма цифр { digitSum(num)}");