// Задача 18:
// Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string QuterBorderAsk(int numQuter) // по координатам точки определяем номер четверти
{
    if (numQuter == 1) return "x > 0 и y > 0";
    if (numQuter == 2) return "x < 0 и y > 0";
    if (numQuter == 3) return "x < 0 и y < 0";
    if (numQuter == 3) return "x > 0 и y < 0";
    return "empty";
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine("Координаты находятся в диапазоне следующих значений: " + msg);
}

int quater = ReadData("Введите название четверти");
PrintResult(QuterBorderAsk(quater));