// Задача 39:
// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый на
// последнем и т.д.)
// [1 2 3 4 5]
// --> [5 4 3 2
// [6 7 3 6]
// --> [6 3 7

//Инициализация массива
int[] RandomArray(int len, int lowBorder, int highBorder)
{
    int[] rA = new int[len];
    for (int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return rA;
}
//Вывод массива
void OutPutArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];

    for(int i = 0; i < arr.Length; i++)
    {
        outArr[arr.Length - 1 - i] = arr[i];
    }

    return outArr;
}

void SwapArray(int[] arr)
{
    int bufferElement = 0;
    for(int i = 0; i  <arr.Length/2; i++)
    {
        bufferElement = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = arr[i];
        arr[i] = bufferElement;
    }
}

Console.Clear();
int[] intArr = RandomArray(10, -20, 20);
Console.WriteLine("Исходный массив");
OutPutArray(intArr);
int[] intArrNew = SwapNewArray(intArr);
Console.WriteLine("Исходный массив");
OutPutArray(intArr);
Console.WriteLine("развернутый массив");
OutPutArray(intArrNew);
SwapArray(intArr);
OutPutArray(intArr);