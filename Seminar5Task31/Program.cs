// Задача 31:
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [ 9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,
// 8,1,0, 7,2, 1,8, 3, 1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// 20.

int[] randomArray(int len, int lowBorder, int highBorder){
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void outPutArray(int[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}
(int, int) NegativePositiveSum(int[] arr)
{
    int positive = 0;
    int negative = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0) positive+=arr[i];
        if(arr[i] < 0) negative+=arr[i];
        
    }
    return (positive, negative);
}
int[]array = randomArray(12,-9,9);
outPutArray(array);
(int pos, int neg) sum = NegativePositiveSum(array);
Console.WriteLine($"Cумма больше 0 {sum.pos}, а меньше 0 {sum.neg}");
