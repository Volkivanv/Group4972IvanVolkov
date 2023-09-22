// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2]
// --> 1
// [1, 2, 3, 6, 2]
// --> 0
// [10, 11, 12, 13, 14]
// --> 5

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

// int FindElement(int[] arr, int num)
// {
//     int pos = -1;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == num){
//             pos = i;
//             return pos;
//         }
//     }
//     return pos;
// }

int CountElDiapason(int[] arr, int min, int max)
{
    int count = 0;
    if(min > max){
        int temp = min;
        min = max;
        max = min;
    }
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max){
            count++;
        }
    }
    return count;
}

int[] array = RandomArray(123, 0, 1000);
OutPutArray(array);
int count = CountElDiapason(array, 10,99);
Console.WriteLine($"Количество элементов удовлетворяющих условию от 10 до 99: { count}");