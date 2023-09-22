// №34 Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// (со звездочкой) Отсортировать массив методом пузырька
int[] RandomArray(int len, int lowBorder, int highBorder){ // инициализация массива
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void OutPutArray(int[] arr) // вывод массива
{
    Console.WriteLine($"{String.Join(',', arr)}");
}

void BubbleSort(int[] arr) // сортировка пузырьком
{
    for(int i = 0; i < arr.Length; i++)
    {
        for(int j = 0; j < arr.Length-1-i; j++)
        {
            if(arr[j] > arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
}

int SumEven(int[] arr) //считаем сумму четных
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) sum+= arr[i];
    }
    return sum;
}

Console.Clear();
int[] array = RandomArray(15, 99, 999);
Console.WriteLine("Исходный массив");
OutPutArray(array);
BubbleSort(array);
Console.WriteLine("отсортированный массив");
OutPutArray(array);
Console.WriteLine($"сумма четных: {SumEven(array)}");

