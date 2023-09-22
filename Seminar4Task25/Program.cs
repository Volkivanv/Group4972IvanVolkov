// №25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

string InputExpression(string msg) //ввод точки в виде строки
{
    Console.WriteLine(msg);
    return Console.ReadLine()??"0";
}

double[] Pair(string sExpression) //парсим строку на числа
{
    double[] pair = new double[2];
    char[] cExpression = sExpression.ToCharArray();
    int j = 0;
    for (int i = 0; i < pair.Length; i++)
    {
        string value = string.Empty;
        //пропускаем все кроме кроме цифр, точки и минуса
        while ((cExpression[j] < '0' || cExpression[j] > '9') && 
        cExpression[j] != '.' && cExpression[j] != '-') 
        {
            j++;
            if(j >= cExpression.Length) break;
        }
        //из цифр точки и минусов собираем числа
        while (cExpression[j] >= '0' && cExpression[j] <= '9' || cExpression[j] == '.' ||
         cExpression[j] == '-')
        {
            value = value + cExpression[j].ToString();
            j++;
            if(j >= cExpression.Length || cExpression[j] == '-') break; //если следующий знак - или стока кончается, то прерываем цикл
        }
        pair[i] = double.Parse(value ??"0");
    }
    return pair;
}
//выясняем какое действие надо совершить
char Action(double[] pair, string sExpression)
{
    int begin = pair[0].ToString().Length;
    char[] cExpression = sExpression.Trim().ToCharArray();
    int end = cExpression.Length - pair[1].ToString().Length;
    for(int i = begin; i < end; i++)
    {
        if(cExpression[i] == '+' || cExpression[i] == '-' || cExpression[i] == '*' || 
        cExpression[i] == '/' || cExpression[i] == '^') return cExpression[i];
    }
    return '+';

}
// Целочисленное возведение в степень
double ZPower(double basis, int pow)
{
    double res = 1;
    for(int i = 0; i < Math.Abs(pow); i++)
    {
        res*=basis;
    }
    if(pow < 0) return 1 / res;
    return res;
}

//Вычисляем выражение
double Result(double[] pair, char act)
{
    switch (act)
    {
        case '+': return pair[0] + pair[1];
        case '-': return pair[0] - pair[1];
        case '*': return pair[0] - pair[1];
        case '/': return pair[0] / pair[1];
        case '^': 
        {
            if(pair[1] != (int)pair[1]) // если степень не целая, применяем встроенную функцию
            {
                return Math.Pow(pair[0], pair[1]);
            } else { // в противном случае применяем целочисленное 
            //возведение в степень, чтобы можно было возводить и отрицательные числа
                return ZPower(pair[0], (int)pair[1]);
            }
        }
        default: return pair[0] * pair[1];
    }
}

Console.Clear();
string expression = InputExpression("Введите выражение в виде А<действие>B: ");

double[] pair = Pair(expression);

char act = Action(pair, expression); 

Console.WriteLine($"Результат выражения {pair[0]} { act.ToString() } {pair[1]} = {Result(pair, act)}");