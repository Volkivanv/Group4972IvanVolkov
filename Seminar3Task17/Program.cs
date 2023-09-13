// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int QuterTest(int x, int y) // по координатам точки определяем номер четверти
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 1;
    if(x > 0 && y < 0) return 4;
    return 0;
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату у: ");
int res = QuterTest(x,y);
PrintResult("Точка находится в четверти № " + res);