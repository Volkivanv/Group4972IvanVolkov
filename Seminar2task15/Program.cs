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

// ВАРИАНТ 2
// решение через dictionary

// Приглашение в консоли ввести число
Console.WriteLine("Введите положительное число");

// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int day = int.Parse(Console.ReadLine() ?? "0");

// Проверка введеного числа на день недели
if (day > 7 || day < 1)
{
    // Выводим результат в консоль
    Console.WriteLine("Число " + day + " не является днем недели, введите число от 1 до 7! ");
}

else
{   
    // Иницилизация словаря со значениями
    Dictionary<int, string> dayOfWeek = new Dictionary<int, string>
{
    { 1, "Понедельник - Рабочий день" },
    { 2, "Вторник - Рабочий день" },
    { 3, "Среда - Рабочий день" },
    { 4, "Четверг - Рабочий день" },
    { 5, "Пятница - Рабочий день" },
    { 6, "Суббота - Выходной день" },
    { 7, "Воскресенье - Выходной день" },
};

    //Получим элемент по ключу == day
    Console.WriteLine(dayOfWeek[day]);
}