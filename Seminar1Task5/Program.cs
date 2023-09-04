// Задача №5
// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

int N = int.Parse(Console.ReadLine()??"0");
//int minusN = -N;
for(int i = -N; i <= N; i++)
{
    Console.Write(i.ToString()+ ", ");
}