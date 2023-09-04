int N = int.Parse(Console.ReadLine()??"0");
if (N < 1000 && N > 99){
    Console.WriteLine("Последняя цифра " + N%10);
} else {
    Console.WriteLine("ошибка ввода");
}
