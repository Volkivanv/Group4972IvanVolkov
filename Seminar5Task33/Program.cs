// Задача 33:
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3]
// --> нет
// -
// 3; массив [6, 7, 19, 345, 3] --> да
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int[] RandomArray(int len, int lowBorder, int highBorder){
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void OutPutArray(int[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}

int FindElement(int[] arr, int num)
{
    int pos = -1;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num){
            pos = i;
            return pos;
        }
    }
    return pos;
}

int[] array = RandomArray(12, -10, 10);
OutPutArray(array);
int num = ReadData("Введите число");
Console.WriteLine($"Число {num} встречается в массиве на {FindElement(array, num)} месте");