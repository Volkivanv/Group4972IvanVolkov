// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input WeekDay");
int day = int.Parse(Console.ReadLine()??"0");
string[] dayOfWeek = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
if (day > 0 && day < 8)
{
    Console.WriteLine("День недели "+ dayOfWeek[day-1]);
} else {
    Console.WriteLine("Неверный ввод");
}

// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));