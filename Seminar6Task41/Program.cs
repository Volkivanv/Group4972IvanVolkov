// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// (Задание со звездочкой) Пользователь вводит число нажатий,
//  затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

using System.Text.RegularExpressions;
using System.Globalization;

string InputExpression(string msg) //ввод строки
{
    Console.WriteLine(msg);
    return Console.ReadLine()??"0";
}

double[] ParseExpression(string str) // парсинг строки на числа с помощью регулярного выражения
{
    double[] result = Regex.Matches(str, @"([-+]?\d+(?:\.\d+)?)")
    .OfType<Match>()
    .Select(m => double.Parse(m.Groups[1].Value, 
        CultureInfo.GetCultureInfo("en-EN")) * (m.Groups[1].Value.StartsWith("0.0") ? 10 : 1))
    .ToArray();

    return result;
}

int numberPositive(double[] arr) //подсчет положительных чисел
{
    int posNum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >=0) 
            posNum++;
    }
    return posNum;
}



void OutPutArray(double[] arr) // вывод массива
{
    Console.WriteLine($"{String.Join("; ", arr)}");
}


string expression = InputExpression("Введите строку. "+ 
"Для чисел, в качестве десятичного разделителя применяйте точку!");
double[] values = ParseExpression(expression);
Console.WriteLine("Массив из введенных чисел: ");
OutPutArray(values);
Console.WriteLine($"Количество положительных {numberPositive(values)}");