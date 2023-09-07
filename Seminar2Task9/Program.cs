// Задача №9
// Напишите программу,
//  которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

void variant1()
{
    Console.WriteLine("Способ 1");
    System.Random numberGenerator = new System.Random();

    int n = numberGenerator.Next(0, 100);
    int maxDigit = n % 10;
    Console.WriteLine(n);
    while (n > 0)
    {
        if (n % 10 > maxDigit)
        {
            maxDigit = n % 10;
        }
        n /= 10;
    }
    Console.WriteLine(maxDigit);
}
void variant2()
{
    Console.WriteLine("Способ 2");

    System.Random numberGenerator1 = new System.Random();
    int number1 = numberGenerator1.Next(10, 100);
    Console.WriteLine(number1);

    Console.WriteLine((number1 / 10 > number1 % 10) ? (int)(number1 / 10) : (int)(number1 % 10));
}
void variant3()
{
    Console.WriteLine("Способ 3");
    System.Random numberGenerator = new System.Random();

    int n = numberGenerator.Next(0, 100);
    int maxDigit = n % 10;
    Console.WriteLine(n);
   char[] DigitChar = n.ToString().ToCharArray();
   Console.WriteLine(DigitChar[0] > DigitChar[1]? DigitChar[0]: DigitChar[1]);
}

variant1();
variant2();
variant3();