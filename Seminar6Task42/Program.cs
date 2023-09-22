// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45
// --> 101101
// 3
// --> 11
// 2
// --> 10
// 20 мин

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int DecToBin(int dec)
{
    int bin = 0;
    int i = 0;
    while(dec>0){
      
       bin += (dec%2)*(int)Math.Pow(10,i);
       dec/=2;
        i++; 
    }
    return bin;
}

int dec = ReadData("Введите число");
Console.WriteLine($"в десятичной системе {dec}");
int bin = DecToBin(dec);
Console.WriteLine($"в двоичной системе {bin}");
Console.WriteLine(Convert.ToString(dec,2));