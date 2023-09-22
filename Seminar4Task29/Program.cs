// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов
// (задание со *) Дополнительно: Написать программу которая из имен через запятую 
// выберет случайное имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора 
// случайного имени метод Random.Next(1,<длина массива имен>+1).

string InputNames(string msg) //ввод строки имен
{
    Console.WriteLine(msg);
    return Console.ReadLine()??"0";
}

string[] SplitTrim(string nameString, char spliter) // разбиение строки на массив с удалением пробелов
{
    string[] names = nameString.Split(spliter); //разделение
    for(int i = 0; i < names.Length; i++)
    {
        names[i] = names[i].Trim(); // удаление пробелов по бокам
    }
    return names;
}
string RandomString(string[] strings) // выбор случайной строки из массива строк
{
    int i = new Random().Next(0, strings.Length);//В моем случае работает нормально без смещения на 1
    return strings[i];
}

Console.Clear();

string nameString = InputNames("Введите, пожалуйста, имена через запятую: ");
string[] names = SplitTrim(nameString,',');


Console.Write($"Случайное имя: {RandomString(names)} ");

