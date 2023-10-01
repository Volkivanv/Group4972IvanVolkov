
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void GenLineRec(int num)
{
    Console.Write(num + " ");
    if(num <=1)
    {

    } else {
        GenLineRec(num-1);
    }
}

int num = ReadData("Введите число N: ");
GenLineRec(num);