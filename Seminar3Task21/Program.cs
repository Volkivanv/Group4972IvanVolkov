double Distance(double[] pointA, double[] pointB) //вычисляем длину
{
    // Введите свое решение ниже
    return Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) +
                     Math.Pow(pointA[1] - pointB[1], 2) +
                     Math.Pow(pointA[2] - pointB[2], 2));
}

string InputPoint(string msg) //ввод точки в виде строки
{
    Console.WriteLine(msg);
    return Console.ReadLine()??"0";
}

double[] point(string sPoint) //парсим строку на координаты
{
    double[] pnt = new double[3];
    char[] cPoint = sPoint.ToCharArray();
    int j = 0;
    for (int i = 0; i < pnt.Length; i++)
    {
        string coordinate = string.Empty;
        while ((cPoint[j] < '0' || cPoint[j] > '9') && cPoint[j] != '.' && cPoint[j] != '-')
        {
            j++;
        }
        while (cPoint[j] >= '0' && cPoint[j] <= '9' || cPoint[j] == '.' || cPoint[j] == '-')
        {
            coordinate = coordinate + cPoint[j].ToString();
            j++;
        }
        pnt[i] = double.Parse(coordinate ??"0");
    }
    return pnt;
}
string pointA = InputPoint("Введите точку А в виде А(x1,y1,z1)");
 //  Console.WriteLine (pointA);
double[] pNTA = point(pointA);

string pointB = InputPoint("Введите точку B в виде B(x1,y1,z1)");
double[] pNTB = point(pointB);
Console.WriteLine(Distance(pNTA, pNTB));
