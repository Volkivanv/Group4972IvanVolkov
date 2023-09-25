// №43 Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// (Задание со звездочкой) Найдите площадь треугольника образованного 
// пересечением 3 прямых


Line[] inputLines() //вводим прямые линии через коэффициент при х и константу
{
    int numLines = 3;
    Line[] lines = new Line[0]; // используем массив пар значений
    for (int i = 0; i < numLines; i++)
    {
        Line tempLine = new Line(); 
        Console.WriteLine($"Input k{i}= ");
        tempLine.k = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Input b{i}= ");
        tempLine.b = double.Parse(Console.ReadLine() ?? "0");
        lines = lines.Append(tempLine).ToArray();

    }
    return lines;
}

bool Parallel(Line[] lines) // проверка линий на параллельность
{
    for (int i = 0; i < lines.Length; i++)
    {
        for (int j = i + 1; j < lines.Length; j++)
        {
            if (lines[i].k == lines[j].k)
                return true;
        }
    }
    return false;
}

Point Intersection(Line line1, Line line2) //поиск пересечения для пары линий
{
    Point point = new Point(); // для каждой точки используем пару x y

    point.x = (line2.b - line1.b) / (line1.k - line2.k);
    point.y = (line1.k * line2.b - line2.k * line1.b) / (line1.k - line2.k);
    return point;
}

Point[] GetVertexes(Line[] lines) // создание массива пересечений
{
    Point[] points = new Point[0];

    for (int i = 0; i < lines.Length; i++)
    {
        for (int j = i + 1; j < lines.Length; j++)
        {
            points = points.Append(Intersection(lines[i], lines[j])).ToArray();
        }
    }
    return points;
}

double TriangleArea(Point[] points) //вычисление площади
{
    return 1.0/2*Math.Abs((points[2].x - points[0].x)*(points[1].y - points[0].y) +
                          (points[0].x - points[1].x)*(points[2].y - points[0].y));
}

Line[] lines = inputLines();

if(!Parallel(lines))
{
    Point[] points = GetVertexes(lines);
    double area = TriangleArea(points);
    Console.WriteLine($"Площадь треугольника составляет {area}");
} else {
    Console.WriteLine($"Какие то две линии параллельны между собой");
}


public class Line // пара для линии
{
    public double k;
    public double b;
}

public class Point // пара для для точки
{
    public double x;
    public double y;
}