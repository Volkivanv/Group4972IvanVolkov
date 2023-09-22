// Задача 44:
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}



void PrintFibbonaciNum(int n)
{

    int first = 0;
    int second = 1;
    for(int i = 0; i < n; i++)
    {   int temp = second;
        second +=first;
        Console.Write($"{second}, ");
        first = temp;
    }

}

int num = ReadData("введите число");
PrintFibbonaciNum(num);
