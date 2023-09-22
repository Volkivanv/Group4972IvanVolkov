// №19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
 Dictionary<int, int> palindromFour(){
    Dictionary<int, int> dict = new Dictionary<int, int>(); 
    for(int i = 10; i < 100; i++){
        int j = i % 10 * 10 + i / 10 %10;
        dict.Add(i,j);
    }
    return dict;
 }

 bool isPalindrom(int num)
 {
    Dictionary<int,int> dictPal = palindromFour();
     if(num%100 == dictPal[num/1000]) return true;
     return false;
 }

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int number = ReadData("Введите пятизначное число");
Console.WriteLine(isPalindrom(number));

