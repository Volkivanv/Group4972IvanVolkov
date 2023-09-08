// №13 Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

int numberLength(long number) //функция для определения длины числа
{
    int length = 0;
    while (number > 0)
    {
        length++;
        number /= 10;
    }
    return length;
}

Console.WriteLine("введите число");
long n = long.Parse(Console.ReadLine() ?? "0");
int digitNumber = 3; // какую цифру с начала нужно отобразить
if (n >= Convert.ToInt32(Math.Pow(10, digitNumber - 1))) // проверка что количество 
                                                         //знаков хватит для отображения
{
    //Console.WriteLine(numberLength(n) + " это длина " + n);
    //отбрасываем последние знаки числа, так чтобы осталось digitNumber знаков
    long tempN = n / Convert.ToInt32((Math.Pow(10, numberLength(n) - (digitNumber))));
    Console.WriteLine(digitNumber + " цифра с начала " + tempN % 10); //выводим последнюю цифру оставшегося
}
else // если количество знаков меньше нужного, выводим сообщение пользователю об этом;
{
    Console.WriteLine("Ваше число имеет меньше " + digitNumber + " цифр");
}

