// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

string DayOfWeek(int dayNum)
{ // метод, возвращающий день недели по номеру
    return
    System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName
    ((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum % 7));
}

bool suit = false; // определяем флаг выхода
while (!suit)
{ // 
    Console.WriteLine("введите номер дня недели от 1 до 7");
    int inDayNum = int.Parse(Console.ReadLine() ?? "0"); //вводим день недели
    suit = 0 <= inDayNum && inDayNum <= 7; //попадает ли день недели в нужный диапазон
    if (suit)
    { // если попадает то выводим его название
        Console.WriteLine(inDayNum + " день недели " + DayOfWeek(inDayNum));
    }
    else
    { // если нет, то сообщаем пользователю о неправильном вводе
        Console.WriteLine("День недели введен неправильно. Введите заново номер дня недели от 1 до 7");
    }
}
