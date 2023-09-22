
//System.Math;

double ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    Double value = int.Parse(Console.ReadLine() ?? "0");
    return value;
}

double distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine(msg);
}

double x1 = ReadData("Введите x1: ");
double x2 = ReadData("Введите X2: ");
double y1 = ReadData("Введите y1: ");
double y2 = ReadData("Введите y2: ");
PrintResult("Расстояние: " + distance(x1, y1, x2, y2));
