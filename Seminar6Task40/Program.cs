int[] ReadData(string msg) // вводим данные
{
    int[] outArr = new int[3];
    Console.WriteLine(msg);
    for(int i = 0; i < outArr.Length; i++)
    {
        outArr[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return outArr;
}

static void QuickSort(int[] arr, int first, int last) //метод быстрой сортировки массива
{
    int i = first;
    int j = last;
    int pivot = (first + last) / 2; //выбираем опорный элемент
    while (i < j) // идем по i с начала, по j с конца, находим слева 
    // элемент больше arr[pivot] а справа меньше и обмениваем их
    {
        while (arr[i] < arr[pivot])
        {
            i++;
        }
        while (arr[j] > arr[pivot])
        {
            j--;
        }
        if (i <= j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
    }
    // рекурсивно применяем к массивам справа и слева от места встречи i и j
    if (first < j) QuickSort(arr, first, j);
    if (i < last) QuickSort(arr, i, last);
}

void CheckTriangle(int[] arr)
{
    if(arr[2] < (arr[0] + arr[1])) 
    {
        Console.WriteLine("Треугольник"); 
        } else

    {
        Console.WriteLine("Не треугольник");
    }
}

int[] arr = ReadData("Введите 3 числа по очереди");
QuickSort(arr,0, arr.Length-1);
CheckTriangle(arr);


