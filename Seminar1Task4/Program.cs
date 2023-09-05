Console.WriteLine("Input first number!");
double a = double.Parse(Console.ReadLine()??"0");
Console.WriteLine("Input second number!");
double b = double.Parse(Console.ReadLine()??"0");
Console.WriteLine("Input third number!");
double c = double.Parse(Console.ReadLine()??"0");

double max = a;
if (b > max)
{
    max = b;
}
if (c > max) 
{
    max = c;
}

Console.WriteLine("Maximum is " + max);
